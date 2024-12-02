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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DataBase_App
{
    public partial class FormAddCoach : Form
    {

        private NpgsqlConnection _connection;
        private int? _coachId; // ID записи, если редактируем

        public FormAddCoach(NpgsqlConnection connection, int? coachId = null)
        {
            InitializeComponent();

            _connection = connection;
            _coachId = coachId;

            // Если тренер существует, загружаем данные
            if (_coachId.HasValue)
            {
                LoadCoachData();
            }
        }

        // Загрузка данных тренера для редактирования
        private void LoadCoachData()
        {
            string query = "SELECT first_name, last_name, middle_name, telephon, specilization " +
                           "FROM public.\"Coach\" WHERE coach_id = @coachId";

            using (var cmd = new NpgsqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@coachId", _coachId.Value);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBox_coachFirstName.Text = reader.GetString(0);
                        textBox_coachLastName.Text = reader.GetString(1);
                        textBox_coachMiddleName.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        textBox_coachTelephone.Text = reader.GetString(3);
                        textBox_coachSpec.Text = reader.GetString(4);
                    }
                }
            }
        }

        private void button_add_edit_coach_Click(object sender, EventArgs e)
        {
            string firstName = textBox_coachFirstName.Text.Trim();
            string lastName = textBox_coachLastName.Text.Trim();
            string middleName = textBox_coachMiddleName.Text.Trim();
            string telephone = textBox_coachTelephone.Text.Trim();
            string specilization = textBox_coachSpec.Text.Trim();

            try
            {
                if (_coachId.HasValue)
                {
                    // Обновление
                    string query = "UPDATE public.\"Coach\" SET first_name = @firstName, last_name = @lastName, middle_name = @middleName, " +
                                   "telephon = @telephone, specilization = @specilization  WHERE coach_id = @coachId";

                    using (var cmd = new NpgsqlCommand(query, _connection))
                    {
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@middleName", (object)middleName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@telephone", telephone);
                        cmd.Parameters.AddWithValue("@specilization", specilization);
                        cmd.Parameters.AddWithValue("@coachId", _coachId.Value);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Тренер успешно обновлён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Добавление нового тренера
                    string query = "INSERT INTO public.\"Coach\" (first_name, last_name, middle_name, telephon, specilization) " +
                                   "VALUES (@firstName, @lastName, @middleName, @telephone, @specilization )";

                    using (var cmd = new NpgsqlCommand(query, _connection))
                    {
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@middleName", (object)middleName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@telephone", telephone);
                        cmd.Parameters.AddWithValue("@specilization", specilization);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Тренер успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
