using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_App
{
    public partial class FormAddSignUp : Form
    {
        private NpgsqlConnection _connection;
        public FormAddSignUp(NpgsqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;

            LoadClients();
            LoadTrainings();
        }

        private void LoadClients()
        {
            try
            {
                string query = "SELECT client_id, CONCAT(first_name, ' ', last_name) AS full_name FROM public.\"Client\"";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, _connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Устанавливаем источник данных ComboBox
                comboBox_client.DataSource = dataTable;
                comboBox_client.DisplayMember = "full_name"; // Отображаемое имя
                comboBox_client.ValueMember = "client_id";  // Скрытое значение
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки клиентов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTrainings()
        {
            try
            {
                string query = "SELECT training_id, title FROM public.\"Training\"";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, _connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Устанавливаем источник данных ComboBox
                comboBox_training.DataSource = dataTable;
                comboBox_training.DisplayMember = "title"; // Отображаемое название
                comboBox_training.ValueMember = "training_id";  // Скрытое значение
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки тренировок: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // кнопка Добавить
        private void Button_addSignUp_Click(object sender, EventArgs e)
        {
            try
            {

                int clientId = Convert.ToInt32(comboBox_client.SelectedValue);
                int trainingId = Convert.ToInt32(comboBox_training.SelectedValue);

                DateTime date = dateTimePicker1.Value;
                bool status = checkBox_status.Checked;

                string query = "INSERT INTO public.\"SignUp\" (client_id, training_id, date_registration, status_st) VALUES (@client_id, @training_id, @date, @status)";
                using (var cmd = new NpgsqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@client_id", clientId);
                    cmd.Parameters.AddWithValue("@training_id", trainingId);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
