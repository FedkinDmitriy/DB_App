namespace DataBase_App
{
    partial class FormAddCoach
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
            textBox_coachFirstName = new TextBox();
            textBox_coachLastName = new TextBox();
            textBox_coachMiddleName = new TextBox();
            textBox_coachTelephone = new TextBox();
            textBox_coachSpec = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button_add_edit_coach = new Button();
            SuspendLayout();
            // 
            // textBox_coachFirstName
            // 
            textBox_coachFirstName.Location = new Point(116, 12);
            textBox_coachFirstName.Name = "textBox_coachFirstName";
            textBox_coachFirstName.Size = new Size(151, 23);
            textBox_coachFirstName.TabIndex = 0;
            // 
            // textBox_coachLastName
            // 
            textBox_coachLastName.Location = new Point(116, 41);
            textBox_coachLastName.Name = "textBox_coachLastName";
            textBox_coachLastName.Size = new Size(151, 23);
            textBox_coachLastName.TabIndex = 1;
            // 
            // textBox_coachMiddleName
            // 
            textBox_coachMiddleName.Location = new Point(116, 70);
            textBox_coachMiddleName.Name = "textBox_coachMiddleName";
            textBox_coachMiddleName.Size = new Size(151, 23);
            textBox_coachMiddleName.TabIndex = 2;
            // 
            // textBox_coachTelephone
            // 
            textBox_coachTelephone.Location = new Point(116, 99);
            textBox_coachTelephone.Name = "textBox_coachTelephone";
            textBox_coachTelephone.Size = new Size(151, 23);
            textBox_coachTelephone.TabIndex = 3;
            // 
            // textBox_coachSpec
            // 
            textBox_coachSpec.Location = new Point(116, 128);
            textBox_coachSpec.Name = "textBox_coachSpec";
            textBox_coachSpec.Size = new Size(151, 23);
            textBox_coachSpec.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 20);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 49);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 78);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 107);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 136);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 9;
            label5.Text = "Специализация";
            // 
            // button_add_edit_coach
            // 
            button_add_edit_coach.Dock = DockStyle.Bottom;
            button_add_edit_coach.Location = new Point(0, 206);
            button_add_edit_coach.Name = "button_add_edit_coach";
            button_add_edit_coach.Size = new Size(285, 42);
            button_add_edit_coach.TabIndex = 10;
            button_add_edit_coach.Text = "Добавить/Изменить";
            button_add_edit_coach.UseVisualStyleBackColor = true;
            button_add_edit_coach.Click += button_add_edit_coach_Click;
            // 
            // FormAddCoach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(285, 248);
            Controls.Add(button_add_edit_coach);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_coachSpec);
            Controls.Add(textBox_coachTelephone);
            Controls.Add(textBox_coachMiddleName);
            Controls.Add(textBox_coachLastName);
            Controls.Add(textBox_coachFirstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAddCoach";
            Text = "Тренер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_coachFirstName;
        private TextBox textBox_coachLastName;
        private TextBox textBox_coachMiddleName;
        private TextBox textBox_coachTelephone;
        private TextBox textBox_coachSpec;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_add_edit_coach;
    }
}