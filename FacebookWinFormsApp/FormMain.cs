
using FacebookWrapper.ObjectModel;
using GMap.NET.MapProviders;
using MapServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static BasicFacebookFeatures.Enums;

namespace BasicFacebookFeatures
{

    public partial class FormMain : Form
    {
        FacebookLogic facebookLogic;
        private AppSettings m_AppSettings;
        public static bool s_UserAccess = false;
        FrmUserMessage frmUserMessage = null;

        //public void SetFacebookLogic(FacebookLogic facebookLogic)
        //{

        //}
        //public FormMain() { }
        public FormMain()
        {
            InitializeComponent();
            facebookLogic = new FacebookLogic();
            this.StartPosition = FormStartPosition.Manual;
            m_AppSettings = AppSettings.LoadFromFile();
            this.Size = m_AppSettings.LastWindowSize;
            this.checkBoxRememberUser.Checked = m_AppSettings.RemmeberUser;
            buttonCalculationAmountPic.Enabled = true;
            buttonCalctulationAmountOfBirthdayByYearsRange.Enabled = true;
            SetButtonLoginLogout(eLogStatus.Login);
            if (m_AppSettings.RemmeberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                try
                {
                    facebookLogic.Connect(m_AppSettings.LastAccessToken);
                    SetButtonLoginLogout(eLogStatus.Logout);
                    buttonLoginAndLogout.BackColor = Color.Red;
                    pictureBoxProfile.LoadAsync(facebookLogic.SetUserPic());
                    buttonCalctulationAmountOfBirthdayByYearsRange.Enabled = true;
                    buttonCalculationAmountPic.Enabled = true;
                    //fetchPopularPhotos();
                    fetchPersonalDetailes();

                    facebookLogic.CollectionData();

                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message + ", please login again");
                    m_AppSettings.LastAccessToken = string.Empty;
                }
            }
        }

        private void fetchPopularPhotos()
        {
            //facebookLogic.FetchMostPoplarPic();
            //List<int> max = new List<int> { 0, 0, 0, 0, 0 };
            //foreach (Album album in facebookLogic.m_LoggInUser.Albums)
            //{
            //    foreach (Photo photo in album.Photos)
            //    {
            //        for (int i = 0; i < 5; i++)
            //        {
            //            if (photo.LikedBy.Count() > max[i])
            //            {
            //                max.RemoveAt(i);
            //                max.Insert(i, photo.LikedBy.Count());
            //                if (i == 0)
            //                {
            //                    pictureBoxPopular0.LoadAsync(photo.PictureNormalURL);
            //                    pictureBoxPopular0.Visible = true;
            //                }
            //                else if (i == 1)
            //                {
            //                    pictureBoxPopular1.LoadAsync(photo.PictureNormalURL);
            //                    pictureBoxPopular1.Visible = true;
            //                }
            //                else if (i == 2)
            //                {
            //                    pictureBoxPopular2.LoadAsync(photo.PictureNormalURL);
            //                    pictureBoxPopular2.Visible = true;
            //                }
            //                else if (i == 3)
            //                {
            //                    pictureBoxPopular3.LoadAsync(photo.PictureNormalURL);
            //                    pictureBoxPopular3.Visible = true;
            //                }
            //                else if (i == 4)
            //                {
            //                    pictureBoxPopular4.LoadAsync(photo.PictureNormalURL);
            //                    pictureBoxPopular4.Visible = true;
            //                }
            //                break;
            //            }
            //        }
            //    }
            //}
            //if (!pictureBoxPopular0.Visible)
            //{
            //    MessageBox.Show("No Pictures");
            //}
        }

        private void SetButtonLoginLogout(eLogStatus i_eLogStatus)
        {
            if (i_eLogStatus == eLogStatus.Login)
            {
                if (InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        buttonLoginAndLogout.Text = "Login";
                        buttonLoginAndLogout.BackColor = Color.Green;
                    });
                }
                else
                {
                    buttonLoginAndLogout.Text = "Login";
                    buttonLoginAndLogout.BackColor = Color.Green;
                }
            }
            else
            {
                if (InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        buttonLoginAndLogout.Text = "Logout";
                        buttonLoginAndLogout.BackColor = Color.Red;
                    });
                }
                else
                {
                    buttonLoginAndLogout.Text = "Logout";
                    buttonLoginAndLogout.BackColor = Color.Red;
                }
            }
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = facebookLogic.m_LoggInUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.RemmeberUser = this.checkBoxRememberUser.Checked;
            if (m_AppSettings.RemmeberUser)
            {
                m_AppSettings.LastAccessToken = facebookLogic.AccessToken;
                m_AppSettings.SaveToFile();
            }
            else
            {
                facebookLogic.AccessToken = string.Empty;
                m_AppSettings.LastAccessToken = string.Empty;
            }
        }

        private void getYourFriendsLocationOnMap()
        {
            gMapControlFriendsMap.DragButton = MouseButtons.Left;
            gMapControlFriendsMap.MapProvider = GMapProviders.GoogleMap;
            gMapControlFriendsMap.SetPositionByKeywords("Israel");
            gMapControlFriendsMap.MinZoom = 5;
            gMapControlFriendsMap.MaxZoom = 100;
            gMapControlFriendsMap.Zoom = 10;
            MapControl mapControl = new MapControl();
            foreach (string locationList in facebookLogic.GetFriendsLocation())
            {
                string[] locationStrarray = Convert.ToString(locationList).Split(',');
                string lat = locationStrarray[0].Trim();
                string lng = locationStrarray[1].Trim();
                mapControl.AddPointOnMap(ref gMapControlFriendsMap, Convert.ToDouble(lat), Convert.ToDouble(lng));
            }
        }

        private void fetchPersonalDetailes()
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    labelName.Text = (facebookLogic.GetDetailes().UserName);
                    labelBirthday.Text = (facebookLogic.GetDetailes().Birthday.ToString());
                    labelEmail.Text = (facebookLogic.GetDetailes().Email.ToString());
                });
            }
            else
            {
                labelName.Text = (facebookLogic.GetDetailes().UserName);
                labelBirthday.Text = (facebookLogic.GetDetailes().Birthday.ToString());
                labelEmail.Text = (facebookLogic.GetDetailes().Email.ToString());
            }


        }

        private void fetchByRangeYears(int i_yearTo, int i_yearFrom)
        {
            int countOfFemale = 0;
            int countOfMale = 0;
            List<User> userList = new List<User>();
            facebookLogic.FetchByRangeYears(i_yearTo, i_yearFrom, out countOfFemale, out countOfMale);

            int countFriends = userList.Count;
            string tempString = i_yearTo.ToString() + "-" + i_yearFrom.ToString();
            if (countOfMale == 0 && countOfFemale == 0)
            {
                chart1.Series["Male"].Points.AddXY(tempString, countOfMale);
            }

            if (countOfMale > 0)
            {
                chart1.Series["Male"].Points.AddXY(tempString, countOfMale);
                chart1.Series["Male"].IsValueShownAsLabel = true;
            }

            if (countOfFemale > 0)
            {
                chart1.Series["Female"].Points.AddXY(tempString, countOfFemale);
                chart1.Series["Female"].IsValueShownAsLabel = true;
            }
        }

        private void buttonCalctulationAmountOfBirthdayByYearsRange_Click(object sender, EventArgs e)
        {
            if (textBoxFromBirthday.Text != "" && textBoxToBirthday.Text != "")
            {
                int input1 = Convert.ToInt32(textBoxFromBirthday.Text);
                int input2 = Convert.ToInt32(textBoxToBirthday.Text);

                if (input1 < input2)
                {
                    fetchByRangeYears(input1, input2);
                }
                else
                {
                    MessageBox.Show("The range is incorrect");
                }
            }
            else
                MessageBox.Show("The range is incorrect");
        }

        private void buttonClearChart_Click(object sender, EventArgs e)
        {
            chartAnalyse.Series["Amount of Pictures"].Points.Clear();
        }

        private void buttonCalculationAmountPic_Click(object sender, EventArgs e)
        {
            // facebookLogic.FetchPicAmountByRangeDate(2017,2018);
            double from = 0;
            double.TryParse(textBoxPicRangeFrom.Text, out from);
            double to = 0;
            double.TryParse(textBoxPicRangeTo.Text, out to);
            chart2.Series["Amount of Pictures"].Points.AddXY(string.Format("{0}-{1}", from, to),
                facebookLogic.FetchPicAmountByRangeDate(from, to));
            chart2.Series["Amount of Pictures"].IsValueShownAsLabel = true;
        }

        private void buttonLoginAndLogout_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        buttonLoginAndLogout.Enabled = false;
                    });
                    if (buttonLoginAndLogout.Text == "Login")
                    {
                        try
                        {
                            if (facebookLogic.Login() == true)
                            {
                                pictureBoxProfile.Invoke((MethodInvoker)delegate
                                {
                                    pictureBoxProfile.LoadAsync(facebookLogic.SetUserPic());
                                });

                                if (m_AppSettings.RemmeberUser && facebookLogic.AccessToken != null)
                                {
                                    m_AppSettings.LastAccessToken = facebookLogic.AccessToken;
                                    m_AppSettings.SaveToFile();
                                }
                                fetchPersonalDetailes();
                                this.Invoke((MethodInvoker)delegate
                                {
                                    buttonCalctulationAmountOfBirthdayByYearsRange.Enabled = true;
                                    buttonCalculationAmountPic.Enabled = true;
                                });

                                SetButtonLoginLogout(eLogStatus.Logout);


                                facebookLogic.CollectionData();
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    buttonCalctulationAmountOfBirthdayByYearsRange.Enabled = false;
                                    buttonCalculationAmountPic.Enabled = false;
                                });

                                SetButtonLoginLogout(eLogStatus.Login);

                                MessageBox.Show("Login Failed");
                            }
                        }
                        catch (Exception message)
                        {
                            MessageBox.Show(message.Message);

                        }
                    }
                    else if (buttonLoginAndLogout.Text == "Logout")
                    {
                        if (facebookLogic.Logout() == true)
                        {

                            this.Invoke((MethodInvoker)delegate
                            {
                                buttonCalctulationAmountOfBirthdayByYearsRange.Enabled = false;
                                buttonCalculationAmountPic.Enabled = false;
                            });

                            SetButtonLoginLogout(eLogStatus.Login);
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                buttonCalctulationAmountOfBirthdayByYearsRange.Enabled = true;
                                buttonCalculationAmountPic.Enabled = true;
                            });

                            SetButtonLoginLogout(eLogStatus.Logout);

                            MessageBox.Show("logout failed");
                        }
                    }
                }
                finally
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        buttonLoginAndLogout.Enabled = true;
                    });
                }

            }).Start();

        }

        private void buttonGetToPictureByLiked_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmUserMessage == null)
                {
                    frmUserMessage = new FrmUserMessage();
                    frmUserMessage.Owner = this;
                }
                frmUserMessage.Message = "Wait, Collecting Data";
                frmUserMessage.Show();
                frmUserMessage.OwnerMoved();

                string[] picArray = facebookLogic.FetchMostPoplarPic();
                if (frmUserMessage != null)
                {
                    frmUserMessage.Hide();
                    frmUserMessage = null;
                }

                pictureBoxPopular0.LoadAsync(picArray[0]);
                pictureBoxPopular1.LoadAsync(picArray[1]);
                pictureBoxPopular2.LoadAsync(picArray[2]);
                pictureBoxPopular3.LoadAsync(picArray[3]);
                pictureBoxPopular4.LoadAsync(picArray[4]);

            }
            finally
            {
                if (frmUserMessage != null)
                {
                    frmUserMessage.Hide();
                    frmUserMessage = null;

                }
            }


        }

        private void buttonShowFriendsLocation_Click(object sender, EventArgs e)
        {
            getYourFriendsLocationOnMap();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(comboBoxFilter.SelectedItem.ToString()))
            {
                double from = 0;
                double to = 0;
                double.TryParse(textBoxFromYear.Text, out from);
                double.TryParse(textBoxToYear.Text, out to);

                
                if (from <= to && !(string.IsNullOrWhiteSpace(textBoxFromYear.Text) && string.IsNullOrWhiteSpace(textBoxToYear.Text)))
                {
                    if (comboBoxFilter.SelectedItem.ToString() == "Birthday")
                    {

                        if (chartAnalyse.Series.Count == 1)
                        {
                            chartAnalyse.Series[0].Name = "Male";
                            chartAnalyse.Series["Male"].ChartType = SeriesChartType.StackedColumn;
                            chartAnalyse.Series.Add("Female");
                            chartAnalyse.Series["Female"].ChartType = SeriesChartType.StackedColumn;
                        }

                        int countOfFemale = 0;
                        int countOfMale = 0;
                        List<User> userList = new List<User>();
                        facebookLogic.FetchByRangeYears(from, to, out countOfFemale, out countOfMale);

                        int countFriends = userList.Count;
                        string tempString = from.ToString() + "-" + to.ToString();
                        if (countOfMale == 0 && countOfFemale == 0)
                        {
                            chartAnalyse.Series["Male"].Points.AddXY(tempString, countOfMale);
                        }

                        if (countOfMale > 0)
                        {
                            chartAnalyse.Series["Male"].Points.AddXY(tempString, countOfMale);
                            chartAnalyse.Series["Male"].IsValueShownAsLabel = true;
                        }

                        if (countOfFemale > 0)
                        {
                            chartAnalyse.Series["Female"].Points.AddXY(tempString, countOfFemale);
                            chartAnalyse.Series["Female"].IsValueShownAsLabel = true;
                        }
                    }
                    else if (comboBoxFilter.SelectedItem.ToString() == "Picture Post")
                    {

                        if (chartAnalyse.Series.Count > 1)
                        {
                            for (int i = 1; i < chartAnalyse.Series.Count; i++)
                            {
                                chartAnalyse.Series.RemoveAt(i);
                            }

                        }
                        chartAnalyse.Series[0].Name = "Amount of Pictures";
                        chartAnalyse.Series["Amount of Pictures"].Points.AddXY(string.Format("{0}-{1}", from, to),
                        facebookLogic.FetchPicAmountByRangeDate(from, to));
                        chartAnalyse.Series["Amount of Pictures"].IsValueShownAsLabel = true;
                    }


                }
                else
                {
                    MessageBox.Show("You select invild years");
                }
            }
            else
            {
                MessageBox.Show("Please select analyse data");
            }
           

        }
    }
}
