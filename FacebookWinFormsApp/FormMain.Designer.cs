namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.groupBoxFriendsMap = new System.Windows.Forms.GroupBox();
            this.buttonShowFriendsLocation = new System.Windows.Forms.Button();
            this.gMapControlFriendsMap = new GMap.NET.WindowsForms.GMapControl();
            this.buttonClearChart = new System.Windows.Forms.Button();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textToPost = new System.Windows.Forms.Label();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.pictureBoxPopular0 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPopular1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPopular3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPopular4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPopular2 = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonLoginAndLogout = new System.Windows.Forms.Button();
            this.groupBoxTopPic = new System.Windows.Forms.GroupBox();
            this.buttonGetToPictureByLiked = new System.Windows.Forms.Button();
            this.groupBoxAnalyse = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFromYear = new System.Windows.Forms.TextBox();
            this.textBoxToYear = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.chartAnalyse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.groupBoxFriendsMap.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular2)).BeginInit();
            this.groupBoxTopPic.SuspendLayout();
            this.groupBoxAnalyse.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalyse)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(17, 111);
            this.checkBoxRememberUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(140, 24);
            this.checkBoxRememberUser.TabIndex = 53;
            this.checkBoxRememberUser.Text = "Remember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(10, 26);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(171, 196);
            this.pictureBoxProfile.TabIndex = 54;
            this.pictureBoxProfile.TabStop = false;
            // 
            // groupBoxFriendsMap
            // 
            this.groupBoxFriendsMap.Controls.Add(this.buttonShowFriendsLocation);
            this.groupBoxFriendsMap.Controls.Add(this.gMapControlFriendsMap);
            this.groupBoxFriendsMap.Location = new System.Drawing.Point(698, 1);
            this.groupBoxFriendsMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFriendsMap.Name = "groupBoxFriendsMap";
            this.groupBoxFriendsMap.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFriendsMap.Size = new System.Drawing.Size(516, 537);
            this.groupBoxFriendsMap.TabIndex = 61;
            this.groupBoxFriendsMap.TabStop = false;
            this.groupBoxFriendsMap.Text = "Friends Map";
            // 
            // buttonShowFriendsLocation
            // 
            this.buttonShowFriendsLocation.Location = new System.Drawing.Point(162, 26);
            this.buttonShowFriendsLocation.Name = "buttonShowFriendsLocation";
            this.buttonShowFriendsLocation.Size = new System.Drawing.Size(220, 44);
            this.buttonShowFriendsLocation.TabIndex = 85;
            this.buttonShowFriendsLocation.Text = "Show Your friends location";
            this.buttonShowFriendsLocation.UseVisualStyleBackColor = true;
            this.buttonShowFriendsLocation.Click += new System.EventHandler(this.buttonShowFriendsLocation_Click);
            // 
            // gMapControlFriendsMap
            // 
            this.gMapControlFriendsMap.Bearing = 0F;
            this.gMapControlFriendsMap.CanDragMap = true;
            this.gMapControlFriendsMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControlFriendsMap.GrayScaleMode = false;
            this.gMapControlFriendsMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlFriendsMap.LevelsKeepInMemory = 5;
            this.gMapControlFriendsMap.Location = new System.Drawing.Point(9, 79);
            this.gMapControlFriendsMap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gMapControlFriendsMap.MarkersEnabled = true;
            this.gMapControlFriendsMap.MaxZoom = 2;
            this.gMapControlFriendsMap.MinZoom = 2;
            this.gMapControlFriendsMap.MouseWheelZoomEnabled = true;
            this.gMapControlFriendsMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControlFriendsMap.Name = "gMapControlFriendsMap";
            this.gMapControlFriendsMap.NegativeMode = false;
            this.gMapControlFriendsMap.PolygonsEnabled = true;
            this.gMapControlFriendsMap.RetryLoadTile = 0;
            this.gMapControlFriendsMap.RoutesEnabled = true;
            this.gMapControlFriendsMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControlFriendsMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControlFriendsMap.ShowTileGridLines = false;
            this.gMapControlFriendsMap.Size = new System.Drawing.Size(501, 452);
            this.gMapControlFriendsMap.TabIndex = 77;
            this.gMapControlFriendsMap.Zoom = 0D;
            // 
            // buttonClearChart
            // 
            this.buttonClearChart.Location = new System.Drawing.Point(570, 66);
            this.buttonClearChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClearChart.Name = "buttonClearChart";
            this.buttonClearChart.Size = new System.Drawing.Size(104, 39);
            this.buttonClearChart.TabIndex = 64;
            this.buttonClearChart.Text = "Clear Chart";
            this.buttonClearChart.UseVisualStyleBackColor = true;
            this.buttonClearChart.Click += new System.EventHandler(this.buttonClearChart_Click);
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Controls.Add(this.groupBox3);
            this.groupBoxProfile.Controls.Add(this.pictureBoxProfile);
            this.groupBoxProfile.Location = new System.Drawing.Point(294, 1);
            this.groupBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProfile.Size = new System.Drawing.Size(398, 226);
            this.groupBoxProfile.TabIndex = 68;
            this.groupBoxProfile.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelEmail);
            this.groupBox3.Controls.Add(this.labelBirthday);
            this.groupBox3.Controls.Add(this.labelName);
            this.groupBox3.Location = new System.Drawing.Point(188, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(196, 204);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(15, 92);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 20);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(15, 55);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(74, 20);
            this.labelBirthday.TabIndex = 1;
            this.labelBirthday.Text = "BirthDay:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // textToPost
            // 
            this.textToPost.AutoSize = true;
            this.textToPost.Location = new System.Drawing.Point(5, 677);
            this.textToPost.Name = "textToPost";
            this.textToPost.Size = new System.Drawing.Size(85, 20);
            this.textToPost.TabIndex = 69;
            this.textToPost.Text = "textToPost";
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Location = new System.Drawing.Point(424, 666);
            this.buttonSetStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(107, 28);
            this.buttonSetStatus.TabIndex = 71;
            this.buttonSetStatus.Text = "SetStatus";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // pictureBoxPopular0
            // 
            this.pictureBoxPopular0.ErrorImage = null;
            this.pictureBoxPopular0.InitialImage = null;
            this.pictureBoxPopular0.Location = new System.Drawing.Point(6, 87);
            this.pictureBoxPopular0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxPopular0.Name = "pictureBoxPopular0";
            this.pictureBoxPopular0.Size = new System.Drawing.Size(91, 115);
            this.pictureBoxPopular0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPopular0.TabIndex = 6;
            this.pictureBoxPopular0.TabStop = false;
            // 
            // pictureBoxPopular1
            // 
            this.pictureBoxPopular1.Location = new System.Drawing.Point(103, 87);
            this.pictureBoxPopular1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxPopular1.Name = "pictureBoxPopular1";
            this.pictureBoxPopular1.Size = new System.Drawing.Size(88, 114);
            this.pictureBoxPopular1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPopular1.TabIndex = 72;
            this.pictureBoxPopular1.TabStop = false;
            // 
            // pictureBoxPopular3
            // 
            this.pictureBoxPopular3.Location = new System.Drawing.Point(291, 88);
            this.pictureBoxPopular3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxPopular3.Name = "pictureBoxPopular3";
            this.pictureBoxPopular3.Size = new System.Drawing.Size(88, 111);
            this.pictureBoxPopular3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPopular3.TabIndex = 73;
            this.pictureBoxPopular3.TabStop = false;
            // 
            // pictureBoxPopular4
            // 
            this.pictureBoxPopular4.Location = new System.Drawing.Point(385, 87);
            this.pictureBoxPopular4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxPopular4.Name = "pictureBoxPopular4";
            this.pictureBoxPopular4.Size = new System.Drawing.Size(88, 112);
            this.pictureBoxPopular4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPopular4.TabIndex = 74;
            this.pictureBoxPopular4.TabStop = false;
            // 
            // pictureBoxPopular2
            // 
            this.pictureBoxPopular2.Location = new System.Drawing.Point(197, 87);
            this.pictureBoxPopular2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxPopular2.Name = "pictureBoxPopular2";
            this.pictureBoxPopular2.Size = new System.Drawing.Size(88, 112);
            this.pictureBoxPopular2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPopular2.TabIndex = 75;
            this.pictureBoxPopular2.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(112, 666);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(304, 26);
            this.textBoxStatus.TabIndex = 77;
            // 
            // buttonLoginAndLogout
            // 
            this.buttonLoginAndLogout.Location = new System.Drawing.Point(17, 10);
            this.buttonLoginAndLogout.Name = "buttonLoginAndLogout";
            this.buttonLoginAndLogout.Size = new System.Drawing.Size(271, 90);
            this.buttonLoginAndLogout.TabIndex = 78;
            this.buttonLoginAndLogout.Text = "Login";
            this.buttonLoginAndLogout.UseVisualStyleBackColor = true;
            this.buttonLoginAndLogout.Click += new System.EventHandler(this.buttonLoginAndLogout_Click);
            // 
            // groupBoxTopPic
            // 
            this.groupBoxTopPic.Controls.Add(this.buttonGetToPictureByLiked);
            this.groupBoxTopPic.Controls.Add(this.pictureBoxPopular1);
            this.groupBoxTopPic.Controls.Add(this.pictureBoxPopular4);
            this.groupBoxTopPic.Controls.Add(this.pictureBoxPopular3);
            this.groupBoxTopPic.Controls.Add(this.pictureBoxPopular0);
            this.groupBoxTopPic.Controls.Add(this.pictureBoxPopular2);
            this.groupBoxTopPic.Location = new System.Drawing.Point(701, 555);
            this.groupBoxTopPic.Name = "groupBoxTopPic";
            this.groupBoxTopPic.Size = new System.Drawing.Size(513, 221);
            this.groupBoxTopPic.TabIndex = 84;
            this.groupBoxTopPic.TabStop = false;
            this.groupBoxTopPic.Text = "Top 5 picture by like";
            // 
            // buttonGetToPictureByLiked
            // 
            this.buttonGetToPictureByLiked.Location = new System.Drawing.Point(136, 32);
            this.buttonGetToPictureByLiked.Name = "buttonGetToPictureByLiked";
            this.buttonGetToPictureByLiked.Size = new System.Drawing.Size(220, 44);
            this.buttonGetToPictureByLiked.TabIndex = 76;
            this.buttonGetToPictureByLiked.Text = "Get top 5 picture by liked";
            this.buttonGetToPictureByLiked.UseVisualStyleBackColor = true;
            this.buttonGetToPictureByLiked.Click += new System.EventHandler(this.buttonGetToPictureByLiked_Click);
            // 
            // groupBoxAnalyse
            // 
            this.groupBoxAnalyse.Controls.Add(this.label4);
            this.groupBoxAnalyse.Controls.Add(this.label3);
            this.groupBoxAnalyse.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxAnalyse.Controls.Add(this.buttonClearChart);
            this.groupBoxAnalyse.Controls.Add(this.label1);
            this.groupBoxAnalyse.Controls.Add(this.label2);
            this.groupBoxAnalyse.Controls.Add(this.textBoxFromYear);
            this.groupBoxAnalyse.Controls.Add(this.textBoxToYear);
            this.groupBoxAnalyse.Controls.Add(this.buttonCalculate);
            this.groupBoxAnalyse.Controls.Add(this.comboBoxFilter);
            this.groupBoxAnalyse.Location = new System.Drawing.Point(12, 232);
            this.groupBoxAnalyse.Name = "groupBoxAnalyse";
            this.groupBoxAnalyse.Size = new System.Drawing.Size(680, 418);
            this.groupBoxAnalyse.TabIndex = 85;
            this.groupBoxAnalyse.TabStop = false;
            this.groupBoxAnalyse.Text = "Analyse Data";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chartAnalyse);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 112);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(664, 300);
            this.flowLayoutPanel1.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "From";
            // 
            // textBoxFromYear
            // 
            this.textBoxFromYear.Location = new System.Drawing.Point(66, 79);
            this.textBoxFromYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFromYear.Name = "textBoxFromYear";
            this.textBoxFromYear.Size = new System.Drawing.Size(95, 26);
            this.textBoxFromYear.TabIndex = 87;
            // 
            // textBoxToYear
            // 
            this.textBoxToYear.Location = new System.Drawing.Point(200, 79);
            this.textBoxToYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxToYear.Name = "textBoxToYear";
            this.textBoxToYear.Size = new System.Drawing.Size(97, 26);
            this.textBoxToYear.TabIndex = 88;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(436, 66);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(123, 39);
            this.buttonCalculate.TabIndex = 89;
            this.buttonCalculate.Text = "Calculation";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Birthday",
            "Picture Post"});
            this.comboBoxFilter.Location = new System.Drawing.Point(100, 34);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(118, 28);
            this.comboBoxFilter.TabIndex = 86;
            // 
            // chartAnalyse
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAnalyse.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAnalyse.Legends.Add(legend2);
            this.chartAnalyse.Location = new System.Drawing.Point(3, 3);
            this.chartAnalyse.Name = "chartAnalyse";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Legend = "Legend1";
            series2.Name = "data";
            this.chartAnalyse.Series.Add(series2);
            this.chartAnalyse.Size = new System.Drawing.Size(661, 294);
            this.chartAnalyse.TabIndex = 0;
            this.chartAnalyse.Text = "chart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Amount of ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "by years range";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 787);
            this.Controls.Add(this.groupBoxAnalyse);
            this.Controls.Add(this.groupBoxTopPic);
            this.Controls.Add(this.buttonLoginAndLogout);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.textToPost);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.groupBoxFriendsMap);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.groupBoxFriendsMap.ResumeLayout(false);
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopular2)).EndInit();
            this.groupBoxTopPic.ResumeLayout(false);
            this.groupBoxAnalyse.ResumeLayout(false);
            this.groupBoxAnalyse.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalyse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
		private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.GroupBox groupBoxFriendsMap;
        private System.Windows.Forms.Button buttonClearChart;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label textToPost;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.PictureBox pictureBoxPopular0;
        private System.Windows.Forms.PictureBox pictureBoxPopular1;
        private System.Windows.Forms.PictureBox pictureBoxPopular3;
        private System.Windows.Forms.PictureBox pictureBoxPopular4;
        private System.Windows.Forms.PictureBox pictureBoxPopular2;
        private GMap.NET.WindowsForms.GMapControl gMapControlFriendsMap;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonLoginAndLogout;
        private System.Windows.Forms.GroupBox groupBoxTopPic;
        private System.Windows.Forms.Button buttonGetToPictureByLiked;
        private System.Windows.Forms.Button buttonShowFriendsLocation;
        private System.Windows.Forms.GroupBox groupBoxAnalyse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFromYear;
        private System.Windows.Forms.TextBox textBoxToYear;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalyse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

