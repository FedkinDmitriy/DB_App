namespace DataBase_App
{
    partial class FormAddTraining
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
            textBox_TrainingTitile = new TextBox();
            comboBox_TrainingCoach = new ComboBox();
            button_add_edit_training = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown_QuantityUsers = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_QuantityUsers).BeginInit();
            SuspendLayout();
            // 
            // textBox_TrainingTitile
            // 
            textBox_TrainingTitile.Location = new Point(126, 12);
            textBox_TrainingTitile.Name = "textBox_TrainingTitile";
            textBox_TrainingTitile.Size = new Size(154, 23);
            textBox_TrainingTitile.TabIndex = 0;
            // 
            // comboBox_TrainingCoach
            // 
            comboBox_TrainingCoach.FormattingEnabled = true;
            comboBox_TrainingCoach.Location = new Point(126, 41);
            comboBox_TrainingCoach.Name = "comboBox_TrainingCoach";
            comboBox_TrainingCoach.Size = new Size(154, 23);
            comboBox_TrainingCoach.TabIndex = 2;
            // 
            // button_add_edit_training
            // 
            button_add_edit_training.Dock = DockStyle.Bottom;
            button_add_edit_training.Location = new Point(0, 171);
            button_add_edit_training.Name = "button_add_edit_training";
            button_add_edit_training.Size = new Size(295, 47);
            button_add_edit_training.TabIndex = 3;
            button_add_edit_training.Text = "Добавить/Изменить";
            button_add_edit_training.UseVisualStyleBackColor = true;
            button_add_edit_training.Click += button_add_edit_training_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 49);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Тренер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 78);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 6;
            label3.Text = "Макс. количество";
            // 
            // numericUpDown_QuantityUsers
            // 
            numericUpDown_QuantityUsers.Location = new Point(127, 70);
            numericUpDown_QuantityUsers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_QuantityUsers.Name = "numericUpDown_QuantityUsers";
            numericUpDown_QuantityUsers.Size = new Size(153, 23);
            numericUpDown_QuantityUsers.TabIndex = 7;
            numericUpDown_QuantityUsers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormAddTraining
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(295, 218);
            Controls.Add(numericUpDown_QuantityUsers);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_add_edit_training);
            Controls.Add(comboBox_TrainingCoach);
            Controls.Add(textBox_TrainingTitile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAddTraining";
            Text = "Тренировка";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_QuantityUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_TrainingTitile;
        private ComboBox comboBox_TrainingCoach;
        private Button button_add_edit_training;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown_QuantityUsers;
    }
}