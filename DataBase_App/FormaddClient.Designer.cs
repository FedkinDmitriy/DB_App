namespace DataBase_App
{
    partial class FormaddClient
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
            textBox_firstName = new TextBox();
            textBox_lastName = new TextBox();
            textBox_MiddleName = new TextBox();
            textBox_Telephon = new TextBox();
            textBox_Email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            button_add_edit_Client = new Button();
            SuspendLayout();
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(129, 12);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(214, 23);
            textBox_firstName.TabIndex = 0;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Location = new Point(129, 41);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(214, 23);
            textBox_lastName.TabIndex = 1;
            // 
            // textBox_MiddleName
            // 
            textBox_MiddleName.Location = new Point(129, 70);
            textBox_MiddleName.Name = "textBox_MiddleName";
            textBox_MiddleName.Size = new Size(214, 23);
            textBox_MiddleName.TabIndex = 2;
            // 
            // textBox_Telephon
            // 
            textBox_Telephon.Location = new Point(129, 99);
            textBox_Telephon.Name = "textBox_Telephon";
            textBox_Telephon.Size = new Size(214, 23);
            textBox_Telephon.TabIndex = 3;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(129, 128);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(214, 23);
            textBox_Email.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 20);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 49);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 78);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 107);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 136);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(129, 215);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(129, 157);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(214, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 165);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 12;
            label6.Text = "Дата рождения";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 223);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 13;
            label7.Text = "Дата активации";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(129, 186);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 23);
            comboBox1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 194);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 15;
            label8.Text = "Абонемент";
            // 
            // button_add_edit_Client
            // 
            button_add_edit_Client.Dock = DockStyle.Bottom;
            button_add_edit_Client.Location = new Point(0, 323);
            button_add_edit_Client.Name = "button_add_edit_Client";
            button_add_edit_Client.Size = new Size(360, 44);
            button_add_edit_Client.TabIndex = 16;
            button_add_edit_Client.Text = "Добавить/Изменить";
            button_add_edit_Client.UseVisualStyleBackColor = true;
            button_add_edit_Client.Click += button_add_edit_Client_Click;
            // 
            // FormaddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(360, 367);
            Controls.Add(button_add_edit_Client);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Telephon);
            Controls.Add(textBox_MiddleName);
            Controls.Add(textBox_lastName);
            Controls.Add(textBox_firstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormaddClient";
            Text = "Клиент";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_firstName;
        private TextBox textBox_lastName;
        private TextBox textBox_MiddleName;
        private TextBox textBox_Telephon;
        private TextBox textBox_Email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private Button button_add_edit_Client;
    }
}