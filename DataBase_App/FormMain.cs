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
    public partial class FormMain : Form
    {
        private NpgsqlConnection _connection;
        private string _currentUser;
        public FormMain(NpgsqlConnection connection, string currentUser)
        {
            InitializeComponent();
            _connection = connection;
            _currentUser = currentUser;
            _connection.Open(); //открываем на весь сеанс (можно потом изменить)
        }

        //при закрытии формы закрываем подключение
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Закрытие подключения при закрытии главной формы
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
            // Закрытие приложения
            Application.Exit();
        }

        //кнопка Загрузить в SignUp
        private void toolStripButton_loadSignUp_Click(object sender, EventArgs e)
        {
            string query = "SELECT s.sign_up_id, c.first_name, c.last_name, t.title, s.date_registration, s.status_st FROM public.\"SignUp\" s JOIN public.\"Client\" c ON s.client_id = c.client_id JOIN public.\"Training\" t ON s.training_id = t.training_id";

            try
            {
                // Создаем объект NpgsqlDataAdapter для выполнения запроса
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, _connection);

                // Создаем объект DataTable для хранения данных
                DataTable dataTable = new DataTable();

                // Заполняем DataTable результатами запроса
                adapter.Fill(dataTable);

                // Привязываем DataTable к DataGridView
                dataGridView_signUp.DataSource = dataTable;
                dataGridView_signUp.Columns["sign_up_id"].Visible = false; // скрываем id 
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //кнопка Добавить в SignUp
        private void toolStripButton_addSignUp_Click(object sender, EventArgs e)
        {
            FormAddSignUp formAdd = new FormAddSignUp(_connection);
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Запись добавлена!");
            }
        }

        //кнопка Изменить
        private void toolStripButton_editSignUp_Click(object sender, EventArgs e)
        {
            if (dataGridView_signUp.SelectedRows.Count > 0)
            {
                try
                {
                    // Получаем данные из выделенной строки
                    DataGridViewRow selectedRow = dataGridView_signUp.SelectedRows[0];

                    int signUpId = Convert.ToInt32(selectedRow.Cells["sign_up_id"].Value); // Получаем ID записи
                    int clientId = GetClientIdByName($"{selectedRow.Cells["first_name"].Value} {selectedRow.Cells["last_name"].Value}");
                    int trainingId = GetTrainingIdByTitle(selectedRow.Cells["title"].Value.ToString());
                    DateTime date = Convert.ToDateTime(selectedRow.Cells["date_registration"].Value);
                    bool status = Convert.ToBoolean(selectedRow.Cells["status_st"].Value);

                    // Открываем форму для редактирования записи
                    FormAddSignUp formEdit = new FormAddSignUp(_connection, signUpId, clientId, trainingId, date, status);
                   // FormAddSignUp formEdit = new FormAddSignUp(_connection, signUpId: null, clientId: clientId, trainingId: trainingId, date: date, status: status);
                    if (formEdit.ShowDialog() == DialogResult.OK)
                    {
                        toolStripButton_loadSignUp_Click(null, null); // Перезагружаем данные
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обработке выделенной записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // функция client_id по имени клиента
        private int GetClientIdByName(string fullName)
        {
            string query = "SELECT client_id FROM public.\"Client\" WHERE CONCAT(first_name, ' ', last_name) = @fullName";
            using (var cmd = new NpgsqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@fullName", fullName);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // функция для получения training_id по названию тренировки
        private int GetTrainingIdByTitle(string title)
        {
            string query = "SELECT training_id FROM public.\"Training\" WHERE title = @title";
            using (var cmd = new NpgsqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@title", title);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
