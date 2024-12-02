using Npgsql;
using System;
using System.Windows.Forms;

namespace DataBase_App
{
    public partial class FormAuthorize : Form
    {
        private NpgsqlConnection _connection;

        public FormAuthorize()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_password.Text;

            _connection = new NpgsqlConnection($"Host=localhost;Database=FitnessCentr;Username={login};Password={password}");

            if (TestDatabaseConnection())
            {
                FormMain mainForm = new FormMain(_connection, login);
                mainForm.Show();
                this.Hide();
            }
        }

        private bool TestDatabaseConnection()
        {
            try
            {
                _connection.Open();
                MessageBox.Show("Подключение успешно!", "Тест подключения", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}", "Тест подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
