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
    public partial class FormaddClient : Form
    {
        private NpgsqlConnection _connection;
        private int? _clientId; // ID записи, если редактируем
        public FormaddClient(NpgsqlConnection connection, int? clientId = null)
        {
            InitializeComponent();
            _connection = connection;
            _clientId = clientId;
            LoadSeasonTicket();

            // Если клиент существует, загружаем данные
            if (_clientId.HasValue)
            {
                LoadClientData();
            }
        }

        private void button_add_edit_Client_Click(object sender, EventArgs e)
        {
            string firstName = textBox_firstName.Text.Trim();
            string lastName = textBox_lastName.Text.Trim();
            string middleName = textBox_MiddleName.Text.Trim();
            string telephone = textBox_Telephon.Text.Trim();
            string email = textBox_Email.Text.Trim();
            DateTime dateOfBirth = dateTimePicker2.Value;
            DateTime activationDate = dateTimePicker1.Value;
            int seasonTicket = (int)comboBox1.SelectedValue;

            try
            {
                if (_clientId.HasValue)
                {
                    // Обновление клиента
                    string query = "UPDATE public.\"Client\" SET first_name = @firstName, last_name = @lastName, middle_name = @middleName, " +
                                   "telephon = @telephone, email = @email, date_of_birth = @dateOfBirth, " +
                                   "season_ticket = @seasonTicket, start_st = @activationDate  WHERE client_id = @clientId";

                    using (var cmd = new NpgsqlCommand(query, _connection))
                    {
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@middleName", (object)middleName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@telephone", telephone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@seasonTicket", seasonTicket);
                        cmd.Parameters.AddWithValue("@activationDate", activationDate);
                        cmd.Parameters.AddWithValue("@clientId", _clientId.Value);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Клиент успешно обновлён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Добавление нового клиента
                    string query = "INSERT INTO public.\"Client\" (first_name, last_name, middle_name, telephon, email, date_of_birth, season_ticket, start_st) " +
                                   "VALUES (@firstName, @lastName, @middleName, @telephone, @email, @dateOfBirth, @seasonTicket, @activationDate )";

                    using (var cmd = new NpgsqlCommand(query, _connection))
                    {
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@middleName", (object)middleName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@telephone", telephone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@seasonTicket", seasonTicket);
                        cmd.Parameters.AddWithValue("@activationDate", activationDate);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Клиент успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK; // Закрытие формы после успешного действия
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSeasonTicket()
        {
            string query = "SELECT season_ticket_id, title FROM public.\"Season_ticket\"";
            DataTable st = new DataTable();

            using (var adapter = new NpgsqlDataAdapter(query, _connection))
            {
                adapter.Fill(st);
            }

            comboBox1.DataSource = st;
            comboBox1.DisplayMember = "title";
            comboBox1.ValueMember = "season_ticket_id";
        }

        // Загрузка данных клиента для редактирования
        private void LoadClientData()
        {
            string query = "SELECT first_name, last_name, middle_name, telephon, email, date_of_birth, season_ticket, start_st " +
                           "FROM public.\"Client\" WHERE client_id = @clientId";

            using (var cmd = new NpgsqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@clientId", _clientId.Value);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBox_firstName.Text = reader.GetString(0);
                        textBox_lastName.Text = reader.GetString(1);
                        textBox_MiddleName.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        textBox_Telephon.Text = reader.GetString(3);
                        textBox_Email.Text = reader.GetString(4);
                        dateTimePicker2.Value = reader.GetDateTime(5);
                        comboBox1.SelectedValue = reader.GetInt32(7);
                        //dateTimePicker1.Value = reader.GetDateTime(6);
                    }
                }
            }
        }


    }
}
