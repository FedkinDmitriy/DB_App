namespace DataBase_App
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tabControlMain = new TabControl();
            tabPage1 = new TabPage();
            dataGridView_signUp = new DataGridView();
            toolStrip_signUp = new ToolStrip();
            toolStripButton_loadSignUp = new ToolStripButton();
            toolStripButton_addSignUp = new ToolStripButton();
            toolStripButton_deleteSignUp = new ToolStripButton();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            toolStripButton_editSignUp = new ToolStripButton();
            tabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_signUp).BeginInit();
            toolStrip_signUp.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPage1);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Controls.Add(tabPage3);
            tabControlMain.Controls.Add(tabPage4);
            tabControlMain.Controls.Add(tabPage5);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(624, 441);
            tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView_signUp);
            tabPage1.Controls.Add(toolStrip_signUp);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(616, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Записи";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_signUp
            // 
            dataGridView_signUp.AllowUserToAddRows = false;
            dataGridView_signUp.AllowUserToDeleteRows = false;
            dataGridView_signUp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_signUp.Dock = DockStyle.Fill;
            dataGridView_signUp.Location = new Point(3, 28);
            dataGridView_signUp.MultiSelect = false;
            dataGridView_signUp.Name = "dataGridView_signUp";
            dataGridView_signUp.ReadOnly = true;
            dataGridView_signUp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_signUp.Size = new Size(610, 382);
            dataGridView_signUp.TabIndex = 1;
            // 
            // toolStrip_signUp
            // 
            toolStrip_signUp.Items.AddRange(new ToolStripItem[] { toolStripButton_loadSignUp, toolStripButton_addSignUp, toolStripButton_deleteSignUp, toolStripButton_editSignUp });
            toolStrip_signUp.Location = new Point(3, 3);
            toolStrip_signUp.Name = "toolStrip_signUp";
            toolStrip_signUp.Size = new Size(610, 25);
            toolStrip_signUp.TabIndex = 0;
            toolStrip_signUp.Text = "toolStrip1";
            // 
            // toolStripButton_loadSignUp
            // 
            toolStripButton_loadSignUp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_loadSignUp.Image = (Image)resources.GetObject("toolStripButton_loadSignUp.Image");
            toolStripButton_loadSignUp.ImageTransparentColor = Color.Magenta;
            toolStripButton_loadSignUp.Name = "toolStripButton_loadSignUp";
            toolStripButton_loadSignUp.Size = new Size(65, 22);
            toolStripButton_loadSignUp.Text = "Загрузить";
            toolStripButton_loadSignUp.Click += toolStripButton_loadSignUp_Click;
            // 
            // toolStripButton_addSignUp
            // 
            toolStripButton_addSignUp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_addSignUp.Image = (Image)resources.GetObject("toolStripButton_addSignUp.Image");
            toolStripButton_addSignUp.ImageTransparentColor = Color.Magenta;
            toolStripButton_addSignUp.Name = "toolStripButton_addSignUp";
            toolStripButton_addSignUp.Size = new Size(63, 22);
            toolStripButton_addSignUp.Text = "Добавить";
            toolStripButton_addSignUp.Click += toolStripButton_addSignUp_Click;
            // 
            // toolStripButton_deleteSignUp
            // 
            toolStripButton_deleteSignUp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_deleteSignUp.Image = (Image)resources.GetObject("toolStripButton_deleteSignUp.Image");
            toolStripButton_deleteSignUp.ImageTransparentColor = Color.Magenta;
            toolStripButton_deleteSignUp.Name = "toolStripButton_deleteSignUp";
            toolStripButton_deleteSignUp.Size = new Size(55, 22);
            toolStripButton_deleteSignUp.Text = "Удалить";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(616, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Клиенты";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(616, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Тренеры";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(616, 413);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Тренировки";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(616, 413);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Абонементы";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // toolStripButton_editSignUp
            // 
            toolStripButton_editSignUp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_editSignUp.Image = (Image)resources.GetObject("toolStripButton_editSignUp.Image");
            toolStripButton_editSignUp.ImageTransparentColor = Color.Magenta;
            toolStripButton_editSignUp.Name = "toolStripButton_editSignUp";
            toolStripButton_editSignUp.RightToLeft = RightToLeft.No;
            toolStripButton_editSignUp.Size = new Size(65, 22);
            toolStripButton_editSignUp.Text = "Изменить";
            toolStripButton_editSignUp.Click += toolStripButton_editSignUp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            FormClosed += FormMain_FormClosed;
            tabControlMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_signUp).EndInit();
            toolStrip_signUp.ResumeLayout(false);
            toolStrip_signUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPage1;
        private DataGridView dataGridView_signUp;
        private ToolStrip toolStrip_signUp;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private ToolStripButton toolStripButton_loadSignUp;
        private ToolStripButton toolStripButton_addSignUp;
        private ToolStripButton toolStripButton_deleteSignUp;
        private ToolStripButton toolStripButton_editSignUp;
    }
}