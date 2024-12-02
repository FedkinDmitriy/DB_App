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
            toolStripButton_editSignUp = new ToolStripButton();
            tabPage2 = new TabPage();
            dataGridView_Client = new DataGridView();
            toolStrip_client = new ToolStrip();
            toolStripButton_loadClient = new ToolStripButton();
            toolStripButton_addClient = new ToolStripButton();
            toolStripButton_editClient = new ToolStripButton();
            toolStripButton_deleteClient = new ToolStripButton();
            tabPage3 = new TabPage();
            dataGridView_Coach = new DataGridView();
            toolStrip_coach = new ToolStrip();
            toolStripButton_loadCoach = new ToolStripButton();
            toolStripButton_addCoach = new ToolStripButton();
            toolStripButton_editCoach = new ToolStripButton();
            toolStripButton_deleteCoach = new ToolStripButton();
            tabPage4 = new TabPage();
            dataGridView_Training = new DataGridView();
            toolStrip_training = new ToolStrip();
            toolStripButton_loadTraining = new ToolStripButton();
            toolStripButton_addTraining = new ToolStripButton();
            toolStripButton_editTraining = new ToolStripButton();
            toolStripButton_deleteTraining = new ToolStripButton();
            tabPage5 = new TabPage();
            dataGridView_Ticket = new DataGridView();
            toolStrip_ticket = new ToolStrip();
            toolStripButton_loadTicket = new ToolStripButton();
            toolStripButton_addTicket = new ToolStripButton();
            toolStripButton_editTicket = new ToolStripButton();
            toolStripButton_deleteTicket = new ToolStripButton();
            tabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_signUp).BeginInit();
            toolStrip_signUp.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Client).BeginInit();
            toolStrip_client.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Coach).BeginInit();
            toolStrip_coach.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Training).BeginInit();
            toolStrip_training.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Ticket).BeginInit();
            toolStrip_ticket.SuspendLayout();
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
            toolStripButton_deleteSignUp.Click += toolStripButton_deleteSignUp_Click;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView_Client);
            tabPage2.Controls.Add(toolStrip_client);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(616, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Клиенты";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Client
            // 
            dataGridView_Client.AllowUserToAddRows = false;
            dataGridView_Client.AllowUserToDeleteRows = false;
            dataGridView_Client.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Client.Dock = DockStyle.Fill;
            dataGridView_Client.Location = new Point(3, 28);
            dataGridView_Client.MultiSelect = false;
            dataGridView_Client.Name = "dataGridView_Client";
            dataGridView_Client.ReadOnly = true;
            dataGridView_Client.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Client.Size = new Size(610, 382);
            dataGridView_Client.TabIndex = 2;
            // 
            // toolStrip_client
            // 
            toolStrip_client.Items.AddRange(new ToolStripItem[] { toolStripButton_loadClient, toolStripButton_addClient, toolStripButton_editClient, toolStripButton_deleteClient });
            toolStrip_client.Location = new Point(3, 3);
            toolStrip_client.Name = "toolStrip_client";
            toolStrip_client.Size = new Size(610, 25);
            toolStrip_client.TabIndex = 0;
            toolStrip_client.Text = "toolStrip1";
            // 
            // toolStripButton_loadClient
            // 
            toolStripButton_loadClient.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_loadClient.Image = (Image)resources.GetObject("toolStripButton_loadClient.Image");
            toolStripButton_loadClient.ImageTransparentColor = Color.Magenta;
            toolStripButton_loadClient.Name = "toolStripButton_loadClient";
            toolStripButton_loadClient.Size = new Size(65, 22);
            toolStripButton_loadClient.Text = "Загрузить";
            toolStripButton_loadClient.Click += toolStripButton_loadClient_Click;
            // 
            // toolStripButton_addClient
            // 
            toolStripButton_addClient.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_addClient.Image = (Image)resources.GetObject("toolStripButton_addClient.Image");
            toolStripButton_addClient.ImageTransparentColor = Color.Magenta;
            toolStripButton_addClient.Name = "toolStripButton_addClient";
            toolStripButton_addClient.Size = new Size(63, 22);
            toolStripButton_addClient.Text = "Добавить";
            toolStripButton_addClient.Click += toolStripButton_addClient_Click;
            // 
            // toolStripButton_editClient
            // 
            toolStripButton_editClient.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_editClient.Image = (Image)resources.GetObject("toolStripButton_editClient.Image");
            toolStripButton_editClient.ImageTransparentColor = Color.Magenta;
            toolStripButton_editClient.Name = "toolStripButton_editClient";
            toolStripButton_editClient.Size = new Size(65, 22);
            toolStripButton_editClient.Text = "Изменить";
            toolStripButton_editClient.Click += toolStripButton_editClient_Click;
            // 
            // toolStripButton_deleteClient
            // 
            toolStripButton_deleteClient.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_deleteClient.Image = (Image)resources.GetObject("toolStripButton_deleteClient.Image");
            toolStripButton_deleteClient.ImageTransparentColor = Color.Magenta;
            toolStripButton_deleteClient.Name = "toolStripButton_deleteClient";
            toolStripButton_deleteClient.Size = new Size(55, 22);
            toolStripButton_deleteClient.Text = "Удалить";
            toolStripButton_deleteClient.Click += toolStripButton_deleteClient_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView_Coach);
            tabPage3.Controls.Add(toolStrip_coach);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(616, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Тренеры";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Coach
            // 
            dataGridView_Coach.AllowUserToAddRows = false;
            dataGridView_Coach.AllowUserToDeleteRows = false;
            dataGridView_Coach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Coach.Dock = DockStyle.Fill;
            dataGridView_Coach.Location = new Point(3, 28);
            dataGridView_Coach.MultiSelect = false;
            dataGridView_Coach.Name = "dataGridView_Coach";
            dataGridView_Coach.ReadOnly = true;
            dataGridView_Coach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Coach.Size = new Size(610, 382);
            dataGridView_Coach.TabIndex = 2;
            // 
            // toolStrip_coach
            // 
            toolStrip_coach.Items.AddRange(new ToolStripItem[] { toolStripButton_loadCoach, toolStripButton_addCoach, toolStripButton_editCoach, toolStripButton_deleteCoach });
            toolStrip_coach.Location = new Point(3, 3);
            toolStrip_coach.Name = "toolStrip_coach";
            toolStrip_coach.Size = new Size(610, 25);
            toolStrip_coach.TabIndex = 0;
            toolStrip_coach.Text = "toolStrip1";
            // 
            // toolStripButton_loadCoach
            // 
            toolStripButton_loadCoach.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_loadCoach.Image = (Image)resources.GetObject("toolStripButton_loadCoach.Image");
            toolStripButton_loadCoach.ImageTransparentColor = Color.Magenta;
            toolStripButton_loadCoach.Name = "toolStripButton_loadCoach";
            toolStripButton_loadCoach.Size = new Size(65, 22);
            toolStripButton_loadCoach.Text = "Загрузить";
            toolStripButton_loadCoach.Click += toolStripButton_loadCoach_Click;
            // 
            // toolStripButton_addCoach
            // 
            toolStripButton_addCoach.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_addCoach.Image = (Image)resources.GetObject("toolStripButton_addCoach.Image");
            toolStripButton_addCoach.ImageTransparentColor = Color.Magenta;
            toolStripButton_addCoach.Name = "toolStripButton_addCoach";
            toolStripButton_addCoach.Size = new Size(63, 22);
            toolStripButton_addCoach.Text = "Добавить";
            toolStripButton_addCoach.Click += toolStripButton_addCoach_Click;
            // 
            // toolStripButton_editCoach
            // 
            toolStripButton_editCoach.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_editCoach.Image = (Image)resources.GetObject("toolStripButton_editCoach.Image");
            toolStripButton_editCoach.ImageTransparentColor = Color.Magenta;
            toolStripButton_editCoach.Name = "toolStripButton_editCoach";
            toolStripButton_editCoach.Size = new Size(65, 22);
            toolStripButton_editCoach.Text = "Изменить";
            toolStripButton_editCoach.Click += toolStripButton_editCoach_Click;
            // 
            // toolStripButton_deleteCoach
            // 
            toolStripButton_deleteCoach.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_deleteCoach.Image = (Image)resources.GetObject("toolStripButton_deleteCoach.Image");
            toolStripButton_deleteCoach.ImageTransparentColor = Color.Magenta;
            toolStripButton_deleteCoach.Name = "toolStripButton_deleteCoach";
            toolStripButton_deleteCoach.Size = new Size(55, 22);
            toolStripButton_deleteCoach.Text = "Удалить";
            toolStripButton_deleteCoach.Click += toolStripButton_deleteCoach_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView_Training);
            tabPage4.Controls.Add(toolStrip_training);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(616, 413);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Тренировки";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Training
            // 
            dataGridView_Training.AllowUserToAddRows = false;
            dataGridView_Training.AllowUserToDeleteRows = false;
            dataGridView_Training.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Training.Dock = DockStyle.Fill;
            dataGridView_Training.Location = new Point(3, 28);
            dataGridView_Training.MultiSelect = false;
            dataGridView_Training.Name = "dataGridView_Training";
            dataGridView_Training.ReadOnly = true;
            dataGridView_Training.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Training.Size = new Size(610, 382);
            dataGridView_Training.TabIndex = 2;
            // 
            // toolStrip_training
            // 
            toolStrip_training.Items.AddRange(new ToolStripItem[] { toolStripButton_loadTraining, toolStripButton_addTraining, toolStripButton_editTraining, toolStripButton_deleteTraining });
            toolStrip_training.Location = new Point(3, 3);
            toolStrip_training.Name = "toolStrip_training";
            toolStrip_training.Size = new Size(610, 25);
            toolStrip_training.TabIndex = 0;
            toolStrip_training.Text = "toolStrip1";
            // 
            // toolStripButton_loadTraining
            // 
            toolStripButton_loadTraining.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_loadTraining.Image = (Image)resources.GetObject("toolStripButton_loadTraining.Image");
            toolStripButton_loadTraining.ImageTransparentColor = Color.Magenta;
            toolStripButton_loadTraining.Name = "toolStripButton_loadTraining";
            toolStripButton_loadTraining.Size = new Size(65, 22);
            toolStripButton_loadTraining.Text = "Загрузить";
            // 
            // toolStripButton_addTraining
            // 
            toolStripButton_addTraining.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_addTraining.Image = (Image)resources.GetObject("toolStripButton_addTraining.Image");
            toolStripButton_addTraining.ImageTransparentColor = Color.Magenta;
            toolStripButton_addTraining.Name = "toolStripButton_addTraining";
            toolStripButton_addTraining.Size = new Size(63, 22);
            toolStripButton_addTraining.Text = "Добавить";
            // 
            // toolStripButton_editTraining
            // 
            toolStripButton_editTraining.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_editTraining.Image = (Image)resources.GetObject("toolStripButton_editTraining.Image");
            toolStripButton_editTraining.ImageTransparentColor = Color.Magenta;
            toolStripButton_editTraining.Name = "toolStripButton_editTraining";
            toolStripButton_editTraining.Size = new Size(65, 22);
            toolStripButton_editTraining.Text = "Изменить";
            // 
            // toolStripButton_deleteTraining
            // 
            toolStripButton_deleteTraining.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_deleteTraining.Image = (Image)resources.GetObject("toolStripButton_deleteTraining.Image");
            toolStripButton_deleteTraining.ImageTransparentColor = Color.Magenta;
            toolStripButton_deleteTraining.Name = "toolStripButton_deleteTraining";
            toolStripButton_deleteTraining.Size = new Size(55, 22);
            toolStripButton_deleteTraining.Text = "Удалить";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dataGridView_Ticket);
            tabPage5.Controls.Add(toolStrip_ticket);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(616, 413);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Абонементы";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Ticket
            // 
            dataGridView_Ticket.AllowUserToAddRows = false;
            dataGridView_Ticket.AllowUserToDeleteRows = false;
            dataGridView_Ticket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Ticket.Dock = DockStyle.Fill;
            dataGridView_Ticket.Location = new Point(3, 28);
            dataGridView_Ticket.MultiSelect = false;
            dataGridView_Ticket.Name = "dataGridView_Ticket";
            dataGridView_Ticket.ReadOnly = true;
            dataGridView_Ticket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Ticket.Size = new Size(610, 382);
            dataGridView_Ticket.TabIndex = 2;
            // 
            // toolStrip_ticket
            // 
            toolStrip_ticket.Items.AddRange(new ToolStripItem[] { toolStripButton_loadTicket, toolStripButton_addTicket, toolStripButton_editTicket, toolStripButton_deleteTicket });
            toolStrip_ticket.Location = new Point(3, 3);
            toolStrip_ticket.Name = "toolStrip_ticket";
            toolStrip_ticket.Size = new Size(610, 25);
            toolStrip_ticket.TabIndex = 0;
            toolStrip_ticket.Text = "toolStrip1";
            // 
            // toolStripButton_loadTicket
            // 
            toolStripButton_loadTicket.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_loadTicket.Image = (Image)resources.GetObject("toolStripButton_loadTicket.Image");
            toolStripButton_loadTicket.ImageTransparentColor = Color.Magenta;
            toolStripButton_loadTicket.Name = "toolStripButton_loadTicket";
            toolStripButton_loadTicket.Size = new Size(65, 22);
            toolStripButton_loadTicket.Text = "Загрузить";
            // 
            // toolStripButton_addTicket
            // 
            toolStripButton_addTicket.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_addTicket.Image = (Image)resources.GetObject("toolStripButton_addTicket.Image");
            toolStripButton_addTicket.ImageTransparentColor = Color.Magenta;
            toolStripButton_addTicket.Name = "toolStripButton_addTicket";
            toolStripButton_addTicket.Size = new Size(63, 22);
            toolStripButton_addTicket.Text = "Добавить";
            // 
            // toolStripButton_editTicket
            // 
            toolStripButton_editTicket.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_editTicket.Image = (Image)resources.GetObject("toolStripButton_editTicket.Image");
            toolStripButton_editTicket.ImageTransparentColor = Color.Magenta;
            toolStripButton_editTicket.Name = "toolStripButton_editTicket";
            toolStripButton_editTicket.Size = new Size(65, 22);
            toolStripButton_editTicket.Text = "Изменить";
            // 
            // toolStripButton_deleteTicket
            // 
            toolStripButton_deleteTicket.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_deleteTicket.Image = (Image)resources.GetObject("toolStripButton_deleteTicket.Image");
            toolStripButton_deleteTicket.ImageTransparentColor = Color.Magenta;
            toolStripButton_deleteTicket.Name = "toolStripButton_deleteTicket";
            toolStripButton_deleteTicket.Size = new Size(55, 22);
            toolStripButton_deleteTicket.Text = "Удалить";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Client).EndInit();
            toolStrip_client.ResumeLayout(false);
            toolStrip_client.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Coach).EndInit();
            toolStrip_coach.ResumeLayout(false);
            toolStrip_coach.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Training).EndInit();
            toolStrip_training.ResumeLayout(false);
            toolStrip_training.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Ticket).EndInit();
            toolStrip_ticket.ResumeLayout(false);
            toolStrip_ticket.PerformLayout();
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
        private ToolStrip toolStrip_client;
        private ToolStripButton toolStripButton_loadClient;
        private ToolStripButton toolStripButton_addClient;
        private ToolStripButton toolStripButton_editClient;
        private ToolStripButton toolStripButton_deleteClient;
        private ToolStrip toolStrip_coach;
        private ToolStrip toolStrip_training;
        private ToolStrip toolStrip_ticket;
        private ToolStripButton toolStripButton_loadCoach;
        private ToolStripButton toolStripButton_addCoach;
        private ToolStripButton toolStripButton_editCoach;
        private ToolStripButton toolStripButton_deleteCoach;
        private ToolStripButton toolStripButton_loadTraining;
        private ToolStripButton toolStripButton_addTraining;
        private ToolStripButton toolStripButton_editTraining;
        private ToolStripButton toolStripButton_deleteTraining;
        private DataGridView dataGridView_Client;
        private DataGridView dataGridView_Coach;
        private DataGridView dataGridView_Training;
        private DataGridView dataGridView_Ticket;
        private ToolStripButton toolStripButton_loadTicket;
        private ToolStripButton toolStripButton_addTicket;
        private ToolStripButton toolStripButton_editTicket;
        private ToolStripButton toolStripButton_deleteTicket;
    }
}