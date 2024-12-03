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
        private int? _signUpId; // ID записи, если редактируем

        public FormAddSignUp(NpgsqlConnection connection, int? signUpId = null, int? clientId = null, int? trainingId = null, DateTime? date = null, bool? status = null)
        {
            InitializeComponent();
            _connection = connection;
            _signUpId = signUpId;

            LoadClients();
            LoadTrainings();

            // Если переданы данные записи, устанавливаем их в соответствующие элементы управления
            if (clientId.HasValue)
                comboBox_client.SelectedValue = clientId.Value;

            if (trainingId.HasValue)
                comboBox_training.SelectedValue = trainingId.Value;

            if (date.HasValue)
                dateTimePicker1.Value = date.Value;

            if (status.HasValue)
                checkBox_status.Checked = status.Value;
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
                //string query = "SELECT training_id, title FROM public.\"Training\"";
                string query = "SELECT training_id, CONCAT(title, ' (max: ', max_users, ')') AS training_info FROM public.\"Training\"";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, _connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Устанавливаем источник данных ComboBox
                comboBox_training.DataSource = dataTable;
                comboBox_training.DisplayMember = "training_info"; // Отображаемое название
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

                string query;

                if (_signUpId.HasValue)
                {
                    // Обновление записи
                    query = "UPDATE public.\"SignUp\" SET client_id = @client_id, training_id = @training_id, date_registration = @date, status_st = @status WHERE sign_up_id = @sign_up_id";
                }
                else
                {
                    // Добавление новой записи
                    query = "INSERT INTO public.\"SignUp\" (client_id, training_id, date_registration, status_st) VALUES (@client_id, @training_id, @date, @status)";
                }

                using (var cmd = new NpgsqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@client_id", clientId);
                    cmd.Parameters.AddWithValue("@training_id", trainingId);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@status", status);

                    if (_signUpId.HasValue)
                        cmd.Parameters.AddWithValue("@sign_up_id", _signUpId.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Операция успешно выполнена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении операции: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // кнопка Проверить
        private void button_checkCount_Click(object sender, EventArgs e)
        {
            try
            {
                int trainingId = Convert.ToInt32(comboBox_training.SelectedValue);
                // Запрос для подсчета количества записей
                string query = "SELECT count(training_id) AS current_use FROM public.\"SignUp\" WHERE training_id = @trainingId";
                // Используем NpgsqlCommand для параметризованного запроса
                using (var cmd = new NpgsqlCommand(query, _connection))
                {
                    // Добавляем параметр
                    cmd.Parameters.AddWithValue("@trainingId", trainingId);
                    // Выполняем запрос и считываем результат
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    // Выводим результат в текстовое поле
                    textBox_countUse.Text = count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

//try
//{

//    int clientId = Convert.ToInt32(comboBox_client.SelectedValue);
//    int trainingId = Convert.ToInt32(comboBox_training.SelectedValue);

//    DateTime date = dateTimePicker1.Value;
//    bool status = checkBox_status.Checked;

//    string query = "INSERT INTO public.\"SignUp\" (client_id, training_id, date_registration, status_st) VALUES (@client_id, @training_id, @date, @status)";
//    using (var cmd = new NpgsqlCommand(query, _connection))
//    {
//        cmd.Parameters.AddWithValue("@client_id", clientId);
//        cmd.Parameters.AddWithValue("@training_id", trainingId);
//        cmd.Parameters.AddWithValue("@date", date);
//        cmd.Parameters.AddWithValue("@status", status);

//        cmd.ExecuteNonQuery();
//        //MessageBox.Show("Запись успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        this.DialogResult = DialogResult.OK;
//    }
//}
//catch (Exception ex)
//{
//    MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//}


//public FormAddSignUp(NpgsqlConnection connection)
//{
//    InitializeComponent();
//    _connection = connection;

//    LoadClients();
//    LoadTrainings();
//}