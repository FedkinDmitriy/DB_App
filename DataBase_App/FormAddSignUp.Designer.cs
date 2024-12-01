namespace DataBase_App
{
    partial class FormAddSignUp
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
            comboBox_client = new ComboBox();
            comboBox_training = new ComboBox();
            Button_addSignUp = new Button();
            dateTimePicker1 = new DateTimePicker();
            checkBox_status = new CheckBox();
            SuspendLayout();
            // 
            // comboBox_client
            // 
            comboBox_client.FormattingEnabled = true;
            comboBox_client.Location = new Point(130, 47);
            comboBox_client.Name = "comboBox_client";
            comboBox_client.Size = new Size(162, 23);
            comboBox_client.TabIndex = 0;
            // 
            // comboBox_training
            // 
            comboBox_training.FormattingEnabled = true;
            comboBox_training.Location = new Point(130, 76);
            comboBox_training.Name = "comboBox_training";
            comboBox_training.Size = new Size(162, 23);
            comboBox_training.TabIndex = 1;
            // 
            // Button_addSignUp
            // 
            Button_addSignUp.Location = new Point(217, 406);
            Button_addSignUp.Name = "Button_addSignUp";
            Button_addSignUp.Size = new Size(75, 23);
            Button_addSignUp.TabIndex = 2;
            Button_addSignUp.Text = "Добавить";
            Button_addSignUp.UseVisualStyleBackColor = true;
            Button_addSignUp.Click += Button_addSignUp_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(92, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // checkBox_status
            // 
            checkBox_status.AutoSize = true;
            checkBox_status.Location = new Point(204, 134);
            checkBox_status.Name = "checkBox_status";
            checkBox_status.Size = new Size(88, 19);
            checkBox_status.TabIndex = 4;
            checkBox_status.Text = "Абонемент";
            checkBox_status.UseVisualStyleBackColor = true;
            // 
            // FormAddSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 441);
            Controls.Add(checkBox_status);
            Controls.Add(dateTimePicker1);
            Controls.Add(Button_addSignUp);
            Controls.Add(comboBox_training);
            Controls.Add(comboBox_client);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAddSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_client;
        private ComboBox comboBox_training;
        private Button Button_addSignUp;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox_status;
    }
}