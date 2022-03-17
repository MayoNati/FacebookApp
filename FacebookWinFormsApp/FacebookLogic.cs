using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static BasicFacebookFeatures.Enums;

namespace BasicFacebookFeatures
{
    public class FacebookLogic
    {
        public string AccessToken { get; set; }
        private FacebookWrapper.LoginResult m_LoginResult;
        public FacebookWrapper.ObjectModel.User m_LoggInUser;
        private List<Post> m_PostList = new List<Post>();
        private List<Album> m_AlbumList = new List<Album>();
        private List<User> m_FriendsList = new List<User>();
        private List<Photo> m_PhotoList = new List<Photo>();
        private UserProfile m_UserProfile = new UserProfile();
        private List<string> m_AllPhotos = new List<string>();
        public bool Login()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 10000;
            bool flag = false;

            try
            {
                FacebookWrapper.LoginResult m_LoginResult = FacebookService.Login("289790089925279", "email",
               "public_profile",
               "user_age_range",
               "user_birthday",
               "user_events",
               "user_friends",
               "user_gender",
               "user_hometown",
               "user_likes",
               "user_link",
               "user_location",
               "user_photos",
               "user_posts",
               "user_videos"
           );

                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    AccessToken = m_LoginResult.AccessToken;
                    m_LoggInUser = m_LoginResult.LoggedInUser;
                    SetUserProfile();
                    flag = true;
                }
            }
            catch (Exception message)
            {
                throw new Exception("Login Failed");
            }


            return flag;
        }

        private void SetUserProfile()
        {

            m_UserProfile.UserName = m_LoggInUser.Name;
            m_UserProfile.Birthday = m_LoggInUser.Birthday;
            m_UserProfile.Email = m_LoggInUser.Email;
            m_UserProfile.HomeTown = m_LoggInUser.Location.Name;

        }

        public string SetUserPic()
        {
            string url = null;
            if (m_LoggInUser != null)
            {
                url = m_LoggInUser.PictureNormalURL;
            }

            return url;
        }

        public bool Logout()
        {
            bool flag = false;
            //   FacebookService.LogoutWithUI();\


            FacebookService.Logout();
            m_LoginResult = null;
            if (m_LoginResult == null || string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                AccessToken = string.Empty;
                flag = true;
            }

            return flag;
        }

        public void Connect(string i_AccessToken)
        {

            try
            {

                m_LoginResult = FacebookService.Connect(i_AccessToken);
                m_LoggInUser = m_LoginResult.LoggedInUser;
                AccessToken = m_LoginResult.AccessToken;
                SetUserProfile();
            }
            catch
            {
                AccessToken = string.Empty;
                throw new Exception("Login Expired");
            }

        }

        public string GetUserLocation()
        {
            string addressName = string.Empty;

            return addressName;
        }

        public void FetchByRangeYears(double i_yearFrom, double i_yearTo, out int i_CountOfFemale, out int i_CountOfMale)
        {
            int countFemale = 0;
            int countMale = 0;
            if (m_FriendsList.Count == 0)
            {
                updateFriendsList();
            }
            try
            {
                foreach (User friend in m_FriendsList)
                {
                    string year = friend.Birthday.Substring(6, 4);
                    if (int.TryParse(year, out int validateYear))
                    {
                        if (validateYear >= i_yearFrom && validateYear <= i_yearTo)
                        {
                            if (friend.Gender == User.eGender.female)
                            {
                                countFemale++;
                            }
                            else if (friend.Gender == User.eGender.male)
                            {
                                countMale++;
                            }
                        }
                    }
                }

                i_CountOfFemale = countFemale;
                i_CountOfMale = countMale;

            }
            catch (Exception)
            {
                throw;
            }

        }

        public int FetchPicAmountByRangeDate(double i_yearFrom, double i_yearTo)
        {
            int[] months = new int[12];
            Dictionary<int, int[]> picCountByData = fetchAllPostByPicTypeAndTime();
            int count = 0;

            foreach (KeyValuePair<int, int[]> picCountByDataItem in picCountByData)
            {
                if (i_yearFrom <= picCountByDataItem.Key && i_yearTo >= picCountByDataItem.Key)
                {
                    //var s=picCountByDataItem.Value.Sum();
                    count += picCountByDataItem.Value.Sum();
                }
            }

            return count;


        }

        public string[] FetchMostPoplarPic()
        {

            List<string> allPhotos = new List<string>();
            string[] picArray = new string[5];
            Dictionary<string, int> photoAndLike = new Dictionary<string, int>();

            if (m_AlbumList.Count == 0)
            {
                updateAlbumList();
            }
            try
            {

                Random rnd = new Random();

                if (m_AllPhotos.Count == 0)
                {
                    foreach (Album album in m_AlbumList)
                    {
                        foreach (Photo photo in album.Photos)
                        {
                            m_AllPhotos.Add(photo.PictureNormalURL);
                        }
                    }
                }

                foreach (string photoList in m_AllPhotos)
                {
                    photoAndLike.Add(photoList, rnd.Next(0, 100));
                }

                for (int i = 0; i < 5; i++)
                {
                    int like = rnd.Next(0, 100);
                    int maxValue = photoAndLike.Values.Max(); // 4
                    string keyOfMaxValue = photoAndLike.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                    picArray[i] = keyOfMaxValue;
                    photoAndLike.Remove(keyOfMaxValue);
                }
            }
            catch
            {
                throw new Exception("Fetch most poplar pic failed");
            }
            return picArray;
        }

        private Dictionary<int, int[]> fetchAllPostByPicTypeAndTime()
        {
            if (m_PostList.Count == 0)
            {
                updatePostList();
            }

            Dictionary<int, int[]> picCountByData = new Dictionary<int, int[]>();
            try
            {
                foreach (Post post in m_PostList)
                {
                    if (post.Type == FacebookWrapper.ObjectModel.Post.eType.photo)
                    {

                        int year = post.CreatedTime.Value.Year;
                        int month = post.CreatedTime.Value.Month;

                        if (picCountByData.ContainsKey(year))
                        {
                            picCountByData[year][month - 1] += 1;
                        }
                        else
                        {
                            picCountByData.Add(year, new int[12]);
                            picCountByData[year][month - 1] += 1;
                        }
                    }
                }

                ;
            }
            catch (Exception)
            {
                return null;
            }

            return picCountByData;
        }

        private void updatePostList()
        {
            m_PostList.Clear();
            try
            {
                foreach (Post post in m_LoggInUser.Posts)
                {
                    m_PostList.Add(post);
                }
            }
            catch
            {
                throw new InvalidOperationException("Update Posts failed");
            }
        }

        private void updateAlbumList()
        {
            m_AlbumList.Clear();
            try
            {
                foreach (Album album in m_LoggInUser.Albums)
                {
                    m_AlbumList.Add(album);
                }
            }
            catch
            {
                throw new InvalidOperationException("Update Posts failed");
            }
        }

        private void updatePhotosList()
        {
            FacebookObjectCollection<Photo> ph = new FacebookObjectCollection<Photo>();
            List<FacebookObjectCollection<Photo>> phList = new List<FacebookObjectCollection<Photo>>();
            Dictionary<string, int> photoAndLike = new Dictionary<string, int>();
            Random rnd = new Random();
            m_PhotoList.Clear();
            if (m_AlbumList.Count == 0)
            {
                updateAlbumList();
            }
            try
            {
                //m_AllPhotos.Clear();
                foreach (Album album in m_AlbumList)
                {

                    //ph = album.Photos;
                    //phList.Add(album.Photos);
                    foreach (Photo photo in album.Photos)
                    {
                        try
                        {
                            photoAndLike.Add(photo.PictureNormalURL, rnd.Next(0, 100));
                            //m_AllPhotos.Add(photo.PictureNormalURL);
                            //m_PhotoList.Add(photo);
                        }
                        catch { }
                    }
                }
                //foreach (List<FacebookObjectCollection<Photo>> photo1 in phList)
                //{
                //    try
                //    {
                //        m_PhotoList.Add(((FacebookObjectCollection<Photo>)photo1));
                //    }
                //    catch { }
                //}
            }
            catch (Exception mess)
            {
                throw new InvalidOperationException("Update Posts failed");
            }
        }

        private void updateFriendsList()
        {
            m_FriendsList.Clear();
            try
            {
                foreach (User friend in m_LoggInUser.Friends)
                {
                    m_FriendsList.Add(friend);
                }
            }
            catch
            {
                throw new InvalidOperationException("Update Posts failed");
            }
        }

        public UserProfile GetDetailes()
        {
            return m_UserProfile;
        }

        public List<string> GetFriendsLocation()
        {
            double latitud = 0;
            double Longitude = 0;
            List<string> locationList = new List<string>();
            if (m_FriendsList.Count == 0)
            {
                updateFriendsList();
            }
            foreach (User friend in m_FriendsList)
            {
                try
                {
                    latitud = Convert.ToDouble(friend.Location.Location.Latitude);
                }
                catch
                {
                    latitud = getRandomValue(eLatAndLng.Latitude);
                }

                try
                {
                    Longitude = Convert.ToDouble(friend.Location.Location.Longitude);
                }
                catch
                {
                    Longitude = getRandomValue(eLatAndLng.Longitude);
                }
                locationList.Add(string.Format("{0},{1}", latitud, Longitude));
            }
            return locationList;
        }

        private double getRandomValue(eLatAndLng latAndLng)
        {
            Random rd = new Random();
            double randomValue = 0;
            if (latAndLng == eLatAndLng.Latitude)
            {
                randomValue = rd.NextDouble() * (32.025859 - 32.0373867) + 32.0373867;
                // randomValue = rd.NextDouble(32.025859,32.0373867);
            }
            else if (latAndLng == eLatAndLng.Longitude)
            {
                randomValue = rd.NextDouble() * (34.977161 - 34.78091) + 34.78091;

            }

            return randomValue;

        }

        public void CollectionData()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback((a) => updateFriendsList()));
            ThreadPool.QueueUserWorkItem(new WaitCallback((a) => updatePostList()));
            ThreadPool.QueueUserWorkItem(new WaitCallback((a) => updateAlbumList()));
        }
    }
}