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
            string query = "SELECT c.first_name, c.last_name, t.title, s.date_registration, s.status_st FROM public.\"SignUp\" s JOIN public.\"Client\" c ON s.client_id = c.client_id JOIN public.\"Training\" t ON s.training_id = t.training_id";

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
                //MessageBox.Show("Запись добавлена!");
            }
        }
    }
}
