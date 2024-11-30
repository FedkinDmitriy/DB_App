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
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = (Image)resources.GetObject("pictureBoxLogin.Image");
            pictureBoxLogin.Location = new Point(12, 14);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(50, 50);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogin.TabIndex = 0;
            pictureBoxLogin.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            pictureBoxPassword.Image = (Image)resources.GetObject("pictureBoxPassword.Image");
            pictureBoxPassword.Location = new Point(12, 83);
            pictureBoxPassword.Name = "pictureBoxPassword";
            pictureBoxPassword.Size = new Size(50, 50);
            pictureBoxPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPassword.TabIndex = 1;
            pictureBoxPassword.TabStop = false;
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(80, 39);
            textBox_login.MinimumSize = new Size(200, 25);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(200, 25);
            textBox_login.TabIndex = 2;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(80, 108);
            textBox_password.MinimumSize = new Size(200, 25);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(200, 25);
            textBox_password.TabIndex = 3;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 14);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 83);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // buttonEnter
            // 
            buttonEnter.Cursor = Cursors.Hand;
            buttonEnter.Dock = DockStyle.Bottom;
            buttonEnter.Location = new Point(0, 157);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(304, 44);
            buttonEnter.TabIndex = 6;
            buttonEnter.Text = "Вход";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // FormAuthorize
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(304, 201);
            Controls.Add(buttonEnter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Controls.Add(pictureBoxPassword);
            Controls.Add(pictureBoxLogin);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
    }
}