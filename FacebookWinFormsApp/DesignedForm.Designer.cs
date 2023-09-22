namespace BasicFacebookFeatures
{
    partial class DesignedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignedForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.facebookLable = new System.Windows.Forms.Label();
            this.facebookLogo = new System.Windows.Forms.PictureBox();
            this.albumsButton = new System.Windows.Forms.Button();
            this.postsButton = new System.Windows.Forms.Button();
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupsButton = new System.Windows.Forms.Button();
            this.newPostButton = new System.Windows.Forms.Button();
            this.mostLikedButton = new System.Windows.Forms.Button();
            this.numberOfPhotosButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderLable = new System.Windows.Forms.Label();
            this.albumsListBox = new BasicFacebookFeatures.ListForm();
            this.numberOfPhotosLableForm = new BasicFacebookFeatures.LabelForm();
            this.lableBoxesFirst = new BasicFacebookFeatures.LabelForm();
            this.groupsListBox = new BasicFacebookFeatures.ListForm();
            this.postsListBox = new BasicFacebookFeatures.ListForm();
            this.newPostInsideForm = new BasicFacebookFeatures.NewPostForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).BeginInit();
            this.layoutPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.textBoxAppID);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(203, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 44);
            this.panel1.TabIndex = 1;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(550, 15);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 26);
            this.textBoxAppID.TabIndex = 55;
            this.textBoxAppID.Text = "617465447233798";
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginButton.Location = new System.Drawing.Point(808, 3);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(90, 38);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Enabled = false;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logoutButton.Location = new System.Drawing.Point(903, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(93, 38);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 163);
            this.panel2.TabIndex = 2;
            // 
            // facebookLable
            // 
            this.facebookLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facebookLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.facebookLable.ForeColor = System.Drawing.SystemColors.Control;
            this.facebookLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.facebookLable.Location = new System.Drawing.Point(38, 71);
            this.facebookLable.Name = "facebookLable";
            this.facebookLable.Size = new System.Drawing.Size(101, 30);
            this.facebookLable.TabIndex = 0;
            this.facebookLable.Text = "FaceBook";
            this.facebookLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // facebookLogo
            // 
            this.facebookLogo.Image = ((System.Drawing.Image)(resources.GetObject("facebookLogo.Image")));
            this.facebookLogo.ImageLocation = "";
            this.facebookLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.facebookLogo.Location = new System.Drawing.Point(61, 25);
            this.facebookLogo.Name = "facebookLogo";
            this.facebookLogo.Size = new System.Drawing.Size(54, 43);
            this.facebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.facebookLogo.TabIndex = 0;
            this.facebookLogo.TabStop = false;
            // 
            // albumsButton
            // 
            this.albumsButton.Enabled = false;
            this.albumsButton.FlatAppearance.BorderSize = 0;
            this.albumsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albumsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.albumsButton.ForeColor = System.Drawing.Color.White;
            this.albumsButton.Image = ((System.Drawing.Image)(resources.GetObject("albumsButton.Image")));
            this.albumsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.albumsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.albumsButton.Location = new System.Drawing.Point(3, 254);
            this.albumsButton.Name = "albumsButton";
            this.albumsButton.Size = new System.Drawing.Size(180, 66);
            this.albumsButton.TabIndex = 1;
            this.albumsButton.Text = "Albums";
            this.albumsButton.UseVisualStyleBackColor = true;
            this.albumsButton.Click += new System.EventHandler(this.AlbumsButton_Click);
            // 
            // postsButton
            // 
            this.postsButton.Enabled = false;
            this.postsButton.FlatAppearance.BorderSize = 0;
            this.postsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.postsButton.ForeColor = System.Drawing.Color.White;
            this.postsButton.Image = ((System.Drawing.Image)(resources.GetObject("postsButton.Image")));
            this.postsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.postsButton.Location = new System.Drawing.Point(3, 110);
            this.postsButton.Name = "postsButton";
            this.postsButton.Size = new System.Drawing.Size(180, 66);
            this.postsButton.TabIndex = 0;
            this.postsButton.Text = "Posts";
            this.postsButton.UseVisualStyleBackColor = true;
            this.postsButton.Click += new System.EventHandler(this.PostsButton_Click);
            // 
            // layoutPanel
            // 
            this.layoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.layoutPanel.Controls.Add(this.panel3);
            this.layoutPanel.Controls.Add(this.postsButton);
            this.layoutPanel.Controls.Add(this.groupsButton);
            this.layoutPanel.Controls.Add(this.albumsButton);
            this.layoutPanel.Controls.Add(this.newPostButton);
            this.layoutPanel.Controls.Add(this.mostLikedButton);
            this.layoutPanel.Controls.Add(this.numberOfPhotosButton);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(203, 630);
            this.layoutPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.facebookLable);
            this.panel3.Controls.Add(this.facebookLogo);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 101);
            this.panel3.TabIndex = 0;
            // 
            // groupsButton
            // 
            this.groupsButton.Enabled = false;
            this.groupsButton.FlatAppearance.BorderSize = 0;
            this.groupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupsButton.ForeColor = System.Drawing.Color.White;
            this.groupsButton.Image = ((System.Drawing.Image)(resources.GetObject("groupsButton.Image")));
            this.groupsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupsButton.Location = new System.Drawing.Point(3, 182);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(180, 66);
            this.groupsButton.TabIndex = 2;
            this.groupsButton.Text = "Groups";
            this.groupsButton.UseVisualStyleBackColor = true;
            this.groupsButton.Click += new System.EventHandler(this.GroupsButton_Click);
            // 
            // newPostButton
            // 
            this.newPostButton.Enabled = false;
            this.newPostButton.FlatAppearance.BorderSize = 0;
            this.newPostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPostButton.ForeColor = System.Drawing.Color.White;
            this.newPostButton.Image = ((System.Drawing.Image)(resources.GetObject("newPostButton.Image")));
            this.newPostButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newPostButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newPostButton.Location = new System.Drawing.Point(3, 326);
            this.newPostButton.Name = "newPostButton";
            this.newPostButton.Size = new System.Drawing.Size(180, 66);
            this.newPostButton.TabIndex = 3;
            this.newPostButton.Text = "New post";
            this.newPostButton.UseVisualStyleBackColor = true;
            this.newPostButton.Click += new System.EventHandler(this.NewPostButton_Click);
            // 
            // mostLikedButton
            // 
            this.mostLikedButton.Enabled = false;
            this.mostLikedButton.FlatAppearance.BorderSize = 0;
            this.mostLikedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostLikedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mostLikedButton.ForeColor = System.Drawing.Color.White;
            this.mostLikedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mostLikedButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mostLikedButton.Location = new System.Drawing.Point(3, 398);
            this.mostLikedButton.Name = "mostLikedButton";
            this.mostLikedButton.Size = new System.Drawing.Size(180, 66);
            this.mostLikedButton.TabIndex = 4;
            this.mostLikedButton.Text = "Most Liked Post";
            this.mostLikedButton.UseVisualStyleBackColor = true;
            this.mostLikedButton.Click += new System.EventHandler(this.MostLikedButton_Click);
            // 
            // numberOfPhotosButton
            // 
            this.numberOfPhotosButton.Enabled = false;
            this.numberOfPhotosButton.FlatAppearance.BorderSize = 0;
            this.numberOfPhotosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberOfPhotosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.numberOfPhotosButton.ForeColor = System.Drawing.Color.White;
            this.numberOfPhotosButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.numberOfPhotosButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numberOfPhotosButton.Location = new System.Drawing.Point(3, 470);
            this.numberOfPhotosButton.Name = "numberOfPhotosButton";
            this.numberOfPhotosButton.Size = new System.Drawing.Size(180, 66);
            this.numberOfPhotosButton.TabIndex = 5;
            this.numberOfPhotosButton.Text = "Total number of photos";
            this.numberOfPhotosButton.UseVisualStyleBackColor = true;
            this.numberOfPhotosButton.Click += new System.EventHandler(this.NumberOfPhotosButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.profilePictureBox.Location = new System.Drawing.Point(183, 0);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(132, 117);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameLabel.Location = new System.Drawing.Point(1007, 97);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 20);
            this.nameLabel.TabIndex = 5;
            // 
            // genderLable
            // 
            this.genderLable.AutoSize = true;
            this.genderLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.genderLable.Location = new System.Drawing.Point(1007, 60);
            this.genderLable.Name = "genderLable";
            this.genderLable.Size = new System.Drawing.Size(0, 20);
            this.genderLable.TabIndex = 6;
            // 
            // albumsListBox
            // 
            this.albumsListBox.Location = new System.Drawing.Point(183, 123);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(1011, 507);
            this.albumsListBox.TabIndex = 9;
            // 
            // numberOfPhotosLableForm
            // 
            this.numberOfPhotosLableForm.Location = new System.Drawing.Point(186, 123);
            this.numberOfPhotosLableForm.Name = "numberOfPhotosLableForm";
            this.numberOfPhotosLableForm.Size = new System.Drawing.Size(1008, 507);
            this.numberOfPhotosLableForm.TabIndex = 12;
            // 
            // lableBoxesFirst
            // 
            this.lableBoxesFirst.Location = new System.Drawing.Point(186, 123);
            this.lableBoxesFirst.Name = "lableBoxesFirst";
            this.lableBoxesFirst.Size = new System.Drawing.Size(1008, 507);
            this.lableBoxesFirst.TabIndex = 11;
            // 
            // groupsListBox
            // 
            this.groupsListBox.Location = new System.Drawing.Point(183, 121);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(1011, 509);
            this.groupsListBox.TabIndex = 8;
            // 
            // postsListBox
            // 
            this.postsListBox.Location = new System.Drawing.Point(183, 121);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(1011, 509);
            this.postsListBox.TabIndex = 7;
            // 
            // newPostInsideForm
            // 
            this.newPostInsideForm.Location = new System.Drawing.Point(183, 123);
            this.newPostInsideForm.Name = "newPostInsideForm";
            this.newPostInsideForm.Size = new System.Drawing.Size(1011, 507);
            this.newPostInsideForm.TabIndex = 10;
            // 
            // DesignedForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1202, 630);
            this.Controls.Add(this.postsListBox);
            this.Controls.Add(this.albumsListBox);
            this.Controls.Add(this.numberOfPhotosLableForm);
            this.Controls.Add(this.lableBoxesFirst);
            this.Controls.Add(this.groupsListBox);
            this.Controls.Add(this.genderLable);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.newPostInsideForm);
            this.Name = "DesignedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DesignedForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).EndInit();
            this.layoutPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox facebookLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label facebookLable;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.Button albumsButton;
        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genderLable;
        private ListForm postsListBox;
        private ListForm groupsListBox;
        private ListForm albumsListBox;
        private System.Windows.Forms.Button postsButton;
        private System.Windows.Forms.Button newPostButton;
        private NewPostForm newPostInsideForm;
        private System.Windows.Forms.Button mostLikedButton;
        private LabelForm lableBoxesFirst;
        private System.Windows.Forms.Button numberOfPhotosButton;
        private LabelForm numberOfPhotosLableForm;
    }
}