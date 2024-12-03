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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_checkCount = new Button();
            textBox_countUse = new TextBox();
            SuspendLayout();
            // 
            // comboBox_client
            // 
            comboBox_client.FormattingEnabled = true;
            comboBox_client.Location = new Point(99, 47);
            comboBox_client.Name = "comboBox_client";
            comboBox_client.Size = new Size(193, 23);
            comboBox_client.TabIndex = 0;
            // 
            // comboBox_training
            // 
            comboBox_training.FormattingEnabled = true;
            comboBox_training.Location = new Point(99, 76);
            comboBox_training.Name = "comboBox_training";
            comboBox_training.Size = new Size(193, 23);
            comboBox_training.TabIndex = 1;
            // 
            // Button_addSignUp
            // 
            Button_addSignUp.Dock = DockStyle.Bottom;
            Button_addSignUp.Location = new Point(0, 209);
            Button_addSignUp.Name = "Button_addSignUp";
            Button_addSignUp.Size = new Size(304, 47);
            Button_addSignUp.TabIndex = 2;
            Button_addSignUp.Text = "Добавить/Изменить";
            Button_addSignUp.UseVisualStyleBackColor = true;
            Button_addSignUp.Click += Button_addSignUp_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(99, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(193, 23);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 5;
            label1.Text = "Клиент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 6;
            label2.Text = "Тренировка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 7;
            label3.Text = "Дата записи";
            // 
            // button_checkCount
            // 
            button_checkCount.Location = new Point(105, 180);
            button_checkCount.Name = "button_checkCount";
            button_checkCount.Size = new Size(75, 23);
            button_checkCount.TabIndex = 8;
            button_checkCount.Text = "Проверить";
            button_checkCount.UseVisualStyleBackColor = true;
            button_checkCount.Click += button_checkCount_Click;
            // 
            // textBox_countUse
            // 
            textBox_countUse.Location = new Point(192, 180);
            textBox_countUse.Name = "textBox_countUse";
            textBox_countUse.Size = new Size(100, 23);
            textBox_countUse.TabIndex = 9;
            // 
            // FormAddSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(304, 256);
            Controls.Add(textBox_countUse);
            Controls.Add(button_checkCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox_status);
            Controls.Add(dateTimePicker1);
            Controls.Add(Button_addSignUp);
            Controls.Add(comboBox_training);
            Controls.Add(comboBox_client);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAddSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Запись на тренировку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_client;
        private ComboBox comboBox_training;
        private Button Button_addSignUp;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox_status;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_checkCount;
        private TextBox textBox_countUse;
    }
}