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
            //LoadTrainings();
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

        // кнопка Добавить
        private void Button_addSignUp_Click(object sender, EventArgs e)
        {



            this.DialogResult = DialogResult.OK;
        }
    }
}
