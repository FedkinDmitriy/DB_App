namespace DataBase_App
{
    partial class FormAddTicket
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
            textBox_TicketTitle = new TextBox();
            numericUpDown_ticketDuration = new NumericUpDown();
            numericUpDown_ticketCost = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_add_edit_Ticket = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ticketDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ticketCost).BeginInit();
            SuspendLayout();
            // 
            // textBox_TicketTitle
            // 
            textBox_TicketTitle.Location = new Point(136, 12);
            textBox_TicketTitle.Name = "textBox_TicketTitle";
            textBox_TicketTitle.Size = new Size(165, 23);
            textBox_TicketTitle.TabIndex = 0;
            // 
            // numericUpDown_ticketDuration
            // 
            numericUpDown_ticketDuration.Location = new Point(136, 41);
            numericUpDown_ticketDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_ticketDuration.Name = "numericUpDown_ticketDuration";
            numericUpDown_ticketDuration.Size = new Size(165, 23);
            numericUpDown_ticketDuration.TabIndex = 1;
            numericUpDown_ticketDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown_ticketCost
            // 
            numericUpDown_ticketCost.DecimalPlaces = 2;
            numericUpDown_ticketCost.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown_ticketCost.Location = new Point(136, 70);
            numericUpDown_ticketCost.Name = "numericUpDown_ticketCost";
            numericUpDown_ticketCost.Size = new Size(165, 23);
            numericUpDown_ticketCost.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 49);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 4;
            label2.Text = "Продолжительность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 78);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Цена";
            // 
            // button_add_edit_Ticket
            // 
            button_add_edit_Ticket.Dock = DockStyle.Bottom;
            button_add_edit_Ticket.Location = new Point(0, 155);
            button_add_edit_Ticket.Name = "button_add_edit_Ticket";
            button_add_edit_Ticket.Size = new Size(310, 49);
            button_add_edit_Ticket.TabIndex = 6;
            button_add_edit_Ticket.Text = "Добавить/Изменить";
            button_add_edit_Ticket.UseVisualStyleBackColor = true;
            button_add_edit_Ticket.Click += button_add_edit_Ticket_Click;
            // 
            // FormAddTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(310, 204);
            Controls.Add(button_add_edit_Ticket);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown_ticketCost);
            Controls.Add(numericUpDown_ticketDuration);
            Controls.Add(textBox_TicketTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAddTicket";
            Text = "Абонемент";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ticketDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ticketCost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_TicketTitle;
        private NumericUpDown numericUpDown_ticketDuration;
        private NumericUpDown numericUpDown_ticketCost;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_add_edit_Ticket;
    }
}