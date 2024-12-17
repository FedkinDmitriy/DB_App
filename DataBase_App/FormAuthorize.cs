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
            textBox_host.Text = "localhost";
            textBox_db.Text = "FitnessCentr";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string host = textBox_host.Text;
            string db = textBox_db.Text;
            string login = textBox_login.Text;
            string password = textBox_password.Text;

            _connection = new NpgsqlConnection($"Host={host};Database={db};Username={login};Password={password}");

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
                MessageBox.Show("Подключение успешно!", "Тест подключения", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
