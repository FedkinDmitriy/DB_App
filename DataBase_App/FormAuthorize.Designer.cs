namespace DataBase_App
{
    partial class FormAuthorize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorize));
            pictureBoxLogin = new PictureBox();
            pictureBoxPassword = new PictureBox();
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonEnter = new Button();
            textBox_host = new TextBox();
            textBox_db = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = (Image)resources.GetObject("pictureBoxLogin.Image");
            pictureBoxLogin.Location = new Point(15, 101);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(50, 50);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogin.TabIndex = 0;
            pictureBoxLogin.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            pictureBoxPassword.Image = (Image)resources.GetObject("pictureBoxPassword.Image");
            pictureBoxPassword.Location = new Point(15, 170);
            pictureBoxPassword.Name = "pictureBoxPassword";
            pictureBoxPassword.Size = new Size(50, 50);
            pictureBoxPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPassword.TabIndex = 1;
            pictureBoxPassword.TabStop = false;
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(83, 126);
            textBox_login.MinimumSize = new Size(200, 25);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(200, 25);
            textBox_login.TabIndex = 2;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(83, 195);
            textBox_password.MinimumSize = new Size(200, 25);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(200, 25);
            textBox_password.TabIndex = 3;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 101);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 170);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // buttonEnter
            // 
            buttonEnter.Cursor = Cursors.Hand;
            buttonEnter.Dock = DockStyle.Bottom;
            buttonEnter.Location = new Point(0, 242);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(304, 44);
            buttonEnter.TabIndex = 6;
            buttonEnter.Text = "Вход";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // textBox_host
            // 
            textBox_host.Location = new Point(83, 12);
            textBox_host.Name = "textBox_host";
            textBox_host.Size = new Size(200, 25);
            textBox_host.TabIndex = 7;
            // 
            // textBox_db
            // 
            textBox_db.Location = new Point(83, 54);
            textBox_db.Name = "textBox_db";
            textBox_db.Size = new Size(200, 25);
            textBox_db.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(35, 17);
            label3.TabIndex = 9;
            label3.Text = "Host";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 62);
            label4.Name = "label4";
            label4.Size = new Size(24, 17);
            label4.TabIndex = 10;
            label4.Text = "DB";
            // 
            // FormAuthorize
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(304, 286);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox_db);
            Controls.Add(textBox_host);
            Controls.Add(buttonEnter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Controls.Add(pictureBoxPassword);
            Controls.Add(pictureBoxLogin);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAuthorize";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogin;
        private PictureBox pictureBoxPassword;
        private TextBox textBox_login;
        private TextBox textBox_password;
        private Label label1;
        private Label label2;
        private Button buttonEnter;
        private TextBox textBox_host;
        private TextBox textBox_db;
        private Label label3;
        private Label label4;
    }
}