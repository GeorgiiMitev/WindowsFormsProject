namespace SocialNetwork
{
    partial class socialPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(socialPageForm));
            this.pictureBoxBackgroundIMG = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newPostsPanel = new System.Windows.Forms.Panel();
            this.joinDateLabel = new System.Windows.Forms.Label();
            this.wallTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxPFP = new System.Windows.Forms.PictureBox();
            this.buttonChangePFP = new System.Windows.Forms.Button();
            this.buttonChangeBackground = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.buttonWall = new System.Windows.Forms.Button();
            this.buttonPhotos = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.photoGalleryPanel = new System.Windows.Forms.Panel();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxAboutMe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundIMG)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPFP)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBackgroundIMG
            // 
            this.pictureBoxBackgroundIMG.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBoxBackgroundIMG.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackgroundIMG.Name = "pictureBoxBackgroundIMG";
            this.pictureBoxBackgroundIMG.Size = new System.Drawing.Size(808, 204);
            this.pictureBoxBackgroundIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackgroundIMG.TabIndex = 0;
            this.pictureBoxBackgroundIMG.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.newPostsPanel);
            this.panel1.Controls.Add(this.joinDateLabel);
            this.panel1.Controls.Add(this.wallTextBox);
            this.panel1.Location = new System.Drawing.Point(202, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 394);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // newPostsPanel
            // 
            this.newPostsPanel.AutoScroll = true;
            this.newPostsPanel.Location = new System.Drawing.Point(45, 183);
            this.newPostsPanel.Name = "newPostsPanel";
            this.newPostsPanel.Size = new System.Drawing.Size(506, 198);
            this.newPostsPanel.TabIndex = 2;
            // 
            // joinDateLabel
            // 
            this.joinDateLabel.AutoSize = true;
            this.joinDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinDateLabel.Location = new System.Drawing.Point(42, 143);
            this.joinDateLabel.Name = "joinDateLabel";
            this.joinDateLabel.Size = new System.Drawing.Size(116, 18);
            this.joinDateLabel.TabIndex = 1;
            this.joinDateLabel.Text = "date placeholder";
            // 
            // wallTextBox
            // 
            this.wallTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.wallTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallTextBox.Location = new System.Drawing.Point(45, 46);
            this.wallTextBox.Multiline = true;
            this.wallTextBox.Name = "wallTextBox";
            this.wallTextBox.Size = new System.Drawing.Size(506, 73);
            this.wallTextBox.TabIndex = 0;
            this.wallTextBox.Enter += new System.EventHandler(this.wallTextBox_Enter);
            this.wallTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wallTextBox_KeyDown);
            this.wallTextBox.Leave += new System.EventHandler(this.wallTextBox_Leave);
            // 
            // pictureBoxPFP
            // 
            this.pictureBoxPFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPFP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPFP.Image")));
            this.pictureBoxPFP.Location = new System.Drawing.Point(12, 110);
            this.pictureBoxPFP.Name = "pictureBoxPFP";
            this.pictureBoxPFP.Size = new System.Drawing.Size(184, 183);
            this.pictureBoxPFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPFP.TabIndex = 2;
            this.pictureBoxPFP.TabStop = false;
            // 
            // buttonChangePFP
            // 
            this.buttonChangePFP.BackColor = System.Drawing.Color.White;
            this.buttonChangePFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePFP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonChangePFP.Location = new System.Drawing.Point(127, 226);
            this.buttonChangePFP.Name = "buttonChangePFP";
            this.buttonChangePFP.Size = new System.Drawing.Size(60, 58);
            this.buttonChangePFP.TabIndex = 3;
            this.buttonChangePFP.Text = "+";
            this.buttonChangePFP.UseVisualStyleBackColor = false;
            this.buttonChangePFP.Click += new System.EventHandler(this.buttonChangePFP_Click);
            // 
            // buttonChangeBackground
            // 
            this.buttonChangeBackground.BackColor = System.Drawing.Color.White;
            this.buttonChangeBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeBackground.Location = new System.Drawing.Point(736, 135);
            this.buttonChangeBackground.Name = "buttonChangeBackground";
            this.buttonChangeBackground.Size = new System.Drawing.Size(60, 58);
            this.buttonChangeBackground.TabIndex = 3;
            this.buttonChangeBackground.Text = "+";
            this.buttonChangeBackground.UseVisualStyleBackColor = false;
            this.buttonChangeBackground.Click += new System.EventHandler(this.buttonChangeBackground_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(217, 135);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(241, 32);
            this.userName.TabIndex = 4;
            this.userName.Text = "name placeholder";
            // 
            // buttonWall
            // 
            this.buttonWall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWall.Location = new System.Drawing.Point(202, 201);
            this.buttonWall.Name = "buttonWall";
            this.buttonWall.Size = new System.Drawing.Size(111, 36);
            this.buttonWall.TabIndex = 5;
            this.buttonWall.Text = "Wall";
            this.buttonWall.UseVisualStyleBackColor = true;
            this.buttonWall.Click += new System.EventHandler(this.buttonWall_Click);
            // 
            // buttonPhotos
            // 
            this.buttonPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPhotos.Location = new System.Drawing.Point(310, 201);
            this.buttonPhotos.Name = "buttonPhotos";
            this.buttonPhotos.Size = new System.Drawing.Size(111, 36);
            this.buttonPhotos.TabIndex = 5;
            this.buttonPhotos.Text = "Photos";
            this.buttonPhotos.UseVisualStyleBackColor = true;
            this.buttonPhotos.Click += new System.EventHandler(this.buttonPhotos_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFriends.Location = new System.Drawing.Point(418, 201);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(111, 36);
            this.buttonFriends.TabIndex = 5;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAbout.Location = new System.Drawing.Point(526, 201);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(111, 36);
            this.buttonAbout.TabIndex = 5;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.photoGalleryPanel);
            this.panel2.Controls.Add(this.buttonAddPhoto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(202, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 394);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // photoGalleryPanel
            // 
            this.photoGalleryPanel.AutoScroll = true;
            this.photoGalleryPanel.Location = new System.Drawing.Point(63, 77);
            this.photoGalleryPanel.Name = "photoGalleryPanel";
            this.photoGalleryPanel.Size = new System.Drawing.Size(485, 316);
            this.photoGalleryPanel.TabIndex = 2;
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Location = new System.Drawing.Point(400, 23);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(151, 34);
            this.buttonAddPhoto.TabIndex = 1;
            this.buttonAddPhoto.Text = "Add photos";
            this.buttonAddPhoto.UseVisualStyleBackColor = true;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Photos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(202, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(606, 394);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.listBoxFriends);
            this.panel4.Location = new System.Drawing.Point(63, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(485, 316);
            this.panel4.TabIndex = 2;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(0, 0);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(479, 308);
            this.listBoxFriends.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "My Friends";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBoxAboutMe);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(202, 235);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(606, 394);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxAboutMe
            // 
            this.textBoxAboutMe.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAboutMe.Location = new System.Drawing.Point(63, 77);
            this.textBoxAboutMe.Multiline = true;
            this.textBoxAboutMe.Name = "textBoxAboutMe";
            this.textBoxAboutMe.Size = new System.Drawing.Size(473, 276);
            this.textBoxAboutMe.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "About me";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearch.Location = new System.Drawing.Point(0, 524);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(203, 25);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.Text = "Search for friends...";
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(-1, 546);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(203, 43);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(0, 589);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(100, 40);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(99, 589);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(103, 40);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // socialPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 629);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonPhotos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonWall);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.buttonChangeBackground);
            this.Controls.Add(this.buttonChangePFP);
            this.Controls.Add(this.pictureBoxPFP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxBackgroundIMG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "socialPageForm";
            this.Text = "My social page";
            this.Load += new System.EventHandler(this.socialPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundIMG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPFP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackgroundIMG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxPFP;
        private System.Windows.Forms.Button buttonChangePFP;
        private System.Windows.Forms.Button buttonChangeBackground;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button buttonWall;
        private System.Windows.Forms.Button buttonPhotos;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.TextBox wallTextBox;
        private System.Windows.Forms.Label joinDateLabel;
        private System.Windows.Forms.Panel newPostsPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.Panel photoGalleryPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxAboutMe;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonExit;
    }
}