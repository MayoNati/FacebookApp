using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FrmUserMessage : Form
    {

        public string Message
        {
            set { setMessage(value); }
        }

        private void setMessage(string value)
        {
            lblMessage.Text = value;
            lblMessage.Font = new Font(lblMessage.Font.FontFamily, 300f, lblMessage.Font.Style);

            while (lblMessage.Width / 1.5 < TextRenderer.MeasureText(lblMessage.Text, new Font(lblMessage.Font.FontFamily, lblMessage.Font.Size, lblMessage.Font.Style)).Width)
            {
                lblMessage.Font = new Font(lblMessage.Font.FontFamily, lblMessage.Font.Size - 0.5f, lblMessage.Font.Style);
            }
            Application.DoEvents();
            Thread.Sleep(1000);
        }

        public FrmUserMessage()
        {
            InitializeComponent();
        }

        private void setCenterLocation()
        {
            Point p = new Point(this.Owner.Location.X + this.Owner.Size.Width / 2 - this.Size.Width / 2, this.Owner.Location.Y + this.Owner.Size.Height / 2 - this.Size.Height / 2);
            this.Location = p;
            Application.DoEvents();
        }

        private void frmUserMessage_Shown(object sender, EventArgs e)
        {
            setCenterLocation();
        }

        public void OwnerMoved()
        {
            setCenterLocation();
        }
    }
}
