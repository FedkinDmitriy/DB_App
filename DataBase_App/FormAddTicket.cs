using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_App
{
    public partial class FormAddTicket : Form
    {
        private NpgsqlConnection _connection;
        private int? _ticketId; // ID записи, если редактируем

        public FormAddTicket(NpgsqlConnection connection, int? ticketId = null)
        {
            InitializeComponent();
            _connection = connection;
            _ticketId = ticketId;

            if (_ticketId.HasValue)
            {
                LoadTicketData();
            }
        }

        // Загрузка данных для редактирования
        private void LoadTicketData()
        {
            string query = "SELECT title, duration, cost FROM public.\"Season_ticket\" WHERE season_ticket_id = @ticketId";

            using (var cmd = new NpgsqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@ticketId", _ticketId.Value);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBox_TicketTitle.Text = reader.GetString(0);
                        numericUpDown_ticketDuration.Value = reader.GetInt32(1);
                        numericUpDown_ticketCost.Value = reader.GetDecimal(2);
                    }
                }
            }
        }

        private void button_add_edit_Ticket_Click(object sender, EventArgs e)
        {
            string title = textBox_TicketTitle.Text.Trim();
            int duration = (int)numericUpDown_ticketDuration.Value;
            decimal cost = numericUpDown_ticketCost.Value;

            try
            {
                if (_ticketId.HasValue)
                {
                    // Обновление
                    string query = "UPDATE public.\"Season_ticket\" SET title = @title, duration = @duration, cost = @cost WHERE season_ticket_id = @ticketId";

                    using (var cmd = new NpgsqlCommand(query, _connection))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@duration", duration);
                        cmd.Parameters.AddWithValue("@cost", cost);
                        cmd.Parameters.AddWithValue("@ticketId", _ticketId.Value);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Абонемент успешно обновлён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Добавление нового абонемента
                    string query = "INSERT INTO public.\"Season_ticket\" (title, duration, cost) VALUES (@title, @duration, @cost)";

                    using (var cmd = new NpgsqlCommand(query, _connection))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@duration", duration);
                        cmd.Parameters.AddWithValue("@cost", cost);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Абонемент успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK; // Закрытие формы после успешного действия
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
