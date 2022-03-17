using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FrmLogin : Form
    {

        FacebookLogic facebookLogic;
        private AppSettings m_AppSettings;

        public FrmLogin()
        {
            InitializeComponent();

            //facebookLogic = new FacebookLogic();
            //m_AppSettings = AppSettings.LoadFromFile();
            //if (m_AppSettings.RemmeberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            //{
            //    try
            //    {
            //        facebookLogic.Connect(m_AppSettings.LastAccessToken);
            //        this.Hide();
            //       // new FormMain(facebookLogic).Show();
                    
            //    }
            //    catch (Exception mes)
            //    {
            //        MessageBox.Show(mes.Message + ", please login again");
            //        m_AppSettings.LastAccessToken = string.Empty;
            //    }
            //}
           
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (CheckUserLogin())
            {
              //  new FormMain(facebookLogic).Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        public bool CheckUserLogin()
        {
            bool isLogin = false;
            try
            {
                if (facebookLogic.Login() == true)
                {
                    
                    if (m_AppSettings.RemmeberUser && facebookLogic.AccessToken != null)
                    {
                        m_AppSettings.LastAccessToken = facebookLogic.AccessToken;
                        m_AppSettings.SaveToFile();
                    }
                    isLogin = true;
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
                isLogin=false;
            }
            return isLogin;
        }
    }
}
