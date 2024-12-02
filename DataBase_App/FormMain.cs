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
               // MessageBox.Show("Запись добавлена!");
                toolStripButton_loadSignUp_Click(null, null);
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

        // кнопка Удалить Запись
        private void toolStripButton_deleteSignUp_Click(object sender, EventArgs e)
        {
            if (dataGridView_signUp.SelectedRows.Count > 0)
            {
                try
                {
                    // Получаем данные из выделенной строки
                    DataGridViewRow selectedRow = dataGridView_signUp.SelectedRows[0];
                    int signUpId = Convert.ToInt32(selectedRow.Cells["sign_up_id"].Value);

                    // Подтверждение удаления
                    var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        string query = "DELETE FROM public.\"SignUp\" WHERE sign_up_id = @signUpId";

                        using (var cmd = new NpgsqlCommand(query, _connection))
                        {
                            cmd.Parameters.AddWithValue("@signUpId", signUpId);
                            cmd.ExecuteNonQuery();
                        }

                        // Перезагрузка данных
                        toolStripButton_loadSignUp_Click(null, null);
                        MessageBox.Show("Запись успешно удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        //интерфейс Клиентов



        // загрузить
        private void toolStripButton_loadClient_Click(object sender, EventArgs e)
        {
            string query = "SELECT c.client_id, c.first_name, c.last_name, c.middle_name, c.telephon, c.email, c.date_of_birth, s.title, c.start_st FROM public.\"Client\" c JOIN public.\"Season_ticket\" s ON c.season_ticket = s.season_ticket_id";

            try
            {
                // Создаем объект NpgsqlDataAdapter для выполнения запроса
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, _connection);

                // Создаем объект DataTable для хранения данных
                DataTable dataTable = new DataTable();

                // Заполняем DataTable результатами запроса
                adapter.Fill(dataTable);

                // Привязываем DataTable к DataGridView
                dataGridView_Client.DataSource = dataTable;
                dataGridView_Client.Columns["client_id"].Visible = false; // скрываем id 
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // добавить клиента
        private void toolStripButton_addClient_Click(object sender, EventArgs e)
        {
            FormaddClient formAdd = new FormaddClient(_connection);
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
               // MessageBox.Show("Запись добавлена!");
                toolStripButton_loadClient_Click(null, null);
            }
        }

        // редактировать клиента
        private void toolStripButton_editClient_Click(object sender, EventArgs e)
        {
            int? clientId = GetSelectedClientId();
            if (clientId.HasValue)
            {
                FormaddClient formEdit = new FormaddClient(_connection, clientId.Value);
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                   // MessageBox.Show("Запись обновлена!");
                    toolStripButton_loadClient_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите клиента для редактирования.");
            }
        }

        private int? GetSelectedClientId()
        {
            if (dataGridView_Client.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView_Client.SelectedRows[0].Cells["client_id"].Value);
            }
            return null;
        }
        // удалить клиента
        private void toolStripButton_deleteClient_Click(object sender, EventArgs e)
        {
            int? clientId = GetSelectedClientId(); // Получаем ID выбранного клиента

            if (clientId.HasValue)
            {
                // Подтверждение удаления
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого клиента?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Выполняем запрос на удаление
                        string query = "DELETE FROM public.\"Client\" WHERE client_id = @clientId";

                        using (var cmd = new NpgsqlCommand(query, _connection))
                        {
                            cmd.Parameters.AddWithValue("@clientId", clientId.Value);
                            int affectedRows = cmd.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Клиент успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Не удалось удалить клиента. Возможно, запись уже была удалена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Перезагружаем данные
                        toolStripButton_loadClient_Click(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите клиента для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        // интерфейс Тренеров


        // загрузить
        private void toolStripButton_loadCoach_Click(object sender, EventArgs e)
        {
            string query = "SELECT coach_id, first_name, last_name, middle_name, telephon, specilization FROM public.\"Coach\"";

            try
            {
                // Создаем объект NpgsqlDataAdapter для выполнения запроса
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, _connection);

                // Создаем объект DataTable для хранения данных
                DataTable dataTable = new DataTable();

                // Заполняем DataTable результатами запроса
                adapter.Fill(dataTable);

                // Привязываем DataTable к DataGridView
                dataGridView_Coach.DataSource = dataTable;
                dataGridView_Coach.Columns["coach_id"].Visible = false; // скрываем id 
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? GetSelectedCoachId()
        {
            if (dataGridView_Coach.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView_Coach.SelectedRows[0].Cells["coach_id"].Value);
            }
            return null;
        }
        // удалить тренера
        private void toolStripButton_deleteCoach_Click(object sender, EventArgs e)
        {
            int? coachId = GetSelectedCoachId();

            if (coachId.HasValue)
            {
                // Подтверждение удаления
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого тренера?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Выполняем запрос на удаление
                        string query = "DELETE FROM public.\"Coach\" WHERE coach_id = @coachId";

                        using (var cmd = new NpgsqlCommand(query, _connection))
                        {
                            cmd.Parameters.AddWithValue("@coachId", coachId.Value);
                            int affectedRows = cmd.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Тренер успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Не удалось удалить тренера. Возможно, запись уже была удалена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Перезагружаем данные
                        toolStripButton_loadCoach_Click(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении тренера: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите тренера для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //добавить тренера 

        private void toolStripButton_addCoach_Click(object sender, EventArgs e)
        {
            FormAddCoach formAdd = new FormAddCoach(_connection);
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Запись добавлена!");
                toolStripButton_loadCoach_Click(null, null);
            }
        }

        //изменить тренера
        private void toolStripButton_editCoach_Click(object sender, EventArgs e)
        {
            int? coachId = GetSelectedCoachId();
            if (coachId.HasValue)
            {
                FormAddCoach formEdit = new FormAddCoach(_connection, coachId.Value);
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                   // MessageBox.Show("Запись обновлена!");
                    toolStripButton_loadCoach_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите тренера для редактирования.");
            }
        }




        // интерфейс Тренировки

        // загрузить тренировки

        private void toolStripButton_loadTraining_Click(object sender, EventArgs e)
        {
            string query = "SELECT tr.training_id, tr.title, CONCAT(ch.first_name,' ',ch.last_name) AS coach, tr.max_users FROM public.\"Training\" tr JOIN public.\"Coach\" ch ON tr.coach = ch.coach_id";

            try
            {
                // Создаем объект NpgsqlDataAdapter для выполнения запроса
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, _connection);

                // Создаем объект DataTable для хранения данных
                DataTable dataTable = new DataTable();

                // Заполняем DataTable результатами запроса
                adapter.Fill(dataTable);

                // Привязываем DataTable к DataGridView
                dataGridView_Training.DataSource = dataTable;
                dataGridView_Training.Columns["training_id"].Visible = false; // скрываем id 
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //удалить тренировки
        private void toolStripButton_deleteTraining_Click(object sender, EventArgs e)
        {
            int? trainingId = GetSelectedTrainingId();

            if (trainingId.HasValue)
            {
                // Подтверждение удаления
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого тренировку?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Выполняем запрос на удаление
                        string query = "DELETE FROM public.\"Training\" WHERE training_id = @trainingId";

                        using (var cmd = new NpgsqlCommand(query, _connection))
                        {
                            cmd.Parameters.AddWithValue("@trainingId", trainingId.Value);
                            int affectedRows = cmd.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Тренеровка успешно удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Не удалось удалить тренеровку. Возможно, запись уже была удалена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Перезагружаем данные
                        toolStripButton_loadTraining_Click(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении тренеровки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите тренеровку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int? GetSelectedTrainingId()
        {
            if (dataGridView_Training.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView_Training.SelectedRows[0].Cells["training_id"].Value);
            }
            return null;
        }

        //добавить тренировку
        private void toolStripButton_addTraining_Click(object sender, EventArgs e)
        {
            FormAddTraining formAdd = new FormAddTraining(_connection);
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
               // MessageBox.Show("Запись добавлена!");
                toolStripButton_loadTraining_Click(null, null);
            }
        }
        //изменить тренировку
        private void toolStripButton_editTraining_Click(object sender, EventArgs e)
        {
            int? trainingId = GetSelectedTrainingId();
            if (trainingId.HasValue)
            {
                FormAddTraining formEdit = new FormAddTraining(_connection, trainingId.Value);
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                   // MessageBox.Show("Запись обновлена!");
                    toolStripButton_loadTraining_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите тренеровку для редактирования.");
            }
        }






        // интерфейс абонементы 

        // загрузить

        private void toolStripButton_loadTicket_Click(object sender, EventArgs e)
        {
            string query = "SELECT season_ticket_id, title, duration, cost FROM public.\"Season_ticket\"";

            try
            {
                // Создаем объект NpgsqlDataAdapter для выполнения запроса
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, _connection);

                // Создаем объект DataTable для хранения данных
                DataTable dataTable = new DataTable();

                // Заполняем DataTable результатами запроса
                adapter.Fill(dataTable);

                // Привязываем DataTable к DataGridView
                dataGridView_Ticket.DataSource = dataTable;
                dataGridView_Ticket.Columns["season_ticket_id"].Visible = false; // скрываем id 
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // удалить
        private void toolStripButton_deleteTicket_Click(object sender, EventArgs e)
        {
            int? ticketId = GetSelectedTicketId();

            if (ticketId.HasValue)
            {
                // Подтверждение удаления
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот абонемент?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Выполняем запрос на удаление
                        string query = "DELETE FROM public.\"Season_ticket\" WHERE season_ticket_id = @ticketId";

                        using (var cmd = new NpgsqlCommand(query, _connection))
                        {
                            cmd.Parameters.AddWithValue("@ticketId", ticketId.Value);
                            int affectedRows = cmd.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Абонемент успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Не удалось удалить абонемент. Возможно, запись уже была удалена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Перезагружаем данные
                        toolStripButton_loadTicket_Click(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении абонемента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите абонемент для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // добавить
        private void toolStripButton_addTicket_Click(object sender, EventArgs e)
        {
            FormAddTicket formAdd = new FormAddTicket(_connection);
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
               // MessageBox.Show("Запись добавлена!");
                toolStripButton_loadTicket_Click(null, null);
            }
        }

        // изменить
        private void toolStripButton_editTicket_Click(object sender, EventArgs e)
        {
            int? ticketId = GetSelectedTicketId();
            if (ticketId.HasValue)
            {
                FormAddTicket formEdit = new FormAddTicket(_connection, ticketId.Value);
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                   // MessageBox.Show("Запись обновлена!");
                    toolStripButton_loadTicket_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите абонемент для редактирования.");
            }
        }

        private int? GetSelectedTicketId()
        {
            if (dataGridView_Ticket.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView_Ticket.SelectedRows[0].Cells["season_ticket_id"].Value);
            }
            return null;
        }
    }
}
