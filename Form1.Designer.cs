namespace Psychic_train_terry_was_right
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtUsername = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnSignup = new Button();
            picGithub = new PictureBox();
            picInstagram = new PictureBox();
            picLibrary = new PictureBox();
            btnClose = new Button();
            picHint = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGithub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInstagram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLibrary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHint).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Fuchsia;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(203, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(248, 153);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Indigo;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(86, 303);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(193, 25);
            txtUsername.TabIndex = 4;
            txtUsername.Text = "Username (q)";
            txtUsername.MouseClick += txtUsername_MouseClick;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(21, 288);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(21, 376);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(87, 333);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 2);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(87, 424);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 2);
            panel2.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Indigo;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(87, 394);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(193, 25);
            txtPassword.TabIndex = 10;
            txtPassword.Text = "Password (q)";
            txtPassword.MouseClick += txtPassword_MouseClick;
            txtPassword.Enter += txtPassword_Enter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Cyan;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLogin.Location = new Point(21, 449);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(430, 67);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Fuchsia;
            btnSignup.FlatStyle = FlatStyle.Popup;
            btnSignup.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSignup.ForeColor = Color.Cyan;
            btnSignup.Location = new Point(21, 547);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(430, 67);
            btnSignup.TabIndex = 12;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // picGithub
            // 
            picGithub.Image = (Image)resources.GetObject("picGithub.Image");
            picGithub.Location = new Point(197, 634);
            picGithub.Name = "picGithub";
            picGithub.Size = new Size(82, 75);
            picGithub.SizeMode = PictureBoxSizeMode.Zoom;
            picGithub.TabIndex = 13;
            picGithub.TabStop = false;
            picGithub.Click += picGithub_Click;
            // 
            // picInstagram
            // 
            picInstagram.Image = (Image)resources.GetObject("picInstagram.Image");
            picInstagram.Location = new Point(12, 620);
            picInstagram.Name = "picInstagram";
            picInstagram.Size = new Size(217, 102);
            picInstagram.SizeMode = PictureBoxSizeMode.Zoom;
            picInstagram.TabIndex = 14;
            picInstagram.TabStop = false;
            picInstagram.Click += picInstagram_Click;
            // 
            // picLibrary
            // 
            picLibrary.Image = (Image)resources.GetObject("picLibrary.Image");
            picLibrary.Location = new Point(305, 634);
            picLibrary.Name = "picLibrary";
            picLibrary.Size = new Size(80, 75);
            picLibrary.SizeMode = PictureBoxSizeMode.Zoom;
            picLibrary.TabIndex = 15;
            picLibrary.TabStop = false;
            picLibrary.Click += picLibrary_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightGray;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(387, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(64, 34);
            btnClose.TabIndex = 16;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // picHint
            // 
            picHint.BackColor = Color.Transparent;
            picHint.Image = (Image)resources.GetObject("picHint.Image");
            picHint.Location = new Point(351, 376);
            picHint.Name = "picHint";
            picHint.Size = new Size(100, 57);
            picHint.SizeMode = PictureBoxSizeMode.Zoom;
            picHint.TabIndex = 17;
            picHint.TabStop = false;
            picHint.MouseDown += picHint_MouseDown;
            picHint.MouseUp += picHint_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(473, 738);
            Controls.Add(picHint);
            Controls.Add(btnClose);
            Controls.Add(picLibrary);
            Controls.Add(picGithub);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(picInstagram);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGithub).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInstagram).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLibrary).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtUsername;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnSignup;
        private PictureBox picGithub;
        private PictureBox picInstagram;
        private PictureBox picLibrary;
        private Button btnClose;
        private PictureBox picHint;
    }
}
