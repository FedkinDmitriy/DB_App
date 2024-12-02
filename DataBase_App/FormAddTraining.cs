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

namespace DataBase_App
{
    public partial class FormAddTraining : Form
    {
        private NpgsqlConnection _connection;
        private int? _TrainingId; // ID записи, если редактируем

        public FormAddTraining(NpgsqlConnection connection, int? TrainingId = null)
        {
            InitializeComponent();
            _connection = connection;
            _TrainingId = TrainingId;
            LoadCoach();

            if (_TrainingId.HasValue)
            {
                LoadTrainingData();
            }
        }

        private void LoadCoach()
        {
            string query = "SELECT coach_id, CONCAT(first_name, ' ', last_name) AS coach FROM public.\"Coach\"";
            DataTable st = new DataTable();

            using (var adapter = new NpgsqlDataAdapter(query, _connection))
            {
                adapter.Fill(st);
            }

            comboBox_TrainingCoach.DataSource = st;
            comboBox_TrainingCoach.DisplayMember = "coach";
            comboBox_TrainingCoach.ValueMember = "coach_id";
        }

        private void LoadTrainingData()
        {
            string query = "SELECT title, coach, max_users FROM public.\"Training\" WHERE training_id = @TrainingId";

            using (var cmd = new NpgsqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@TrainingId", _TrainingId.Value);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBox_TrainingTitile.Text = reader.GetString(0);
                        comboBox_TrainingCoach.SelectedValue = reader.GetInt32(1);
                        numericUpDown_QuantityUsers.Value = reader.GetDecimal(2);
                    }
                }
            }
        }

        private void button_add_edit_training_Click(object sender, EventArgs e)
        {
            string title = textBox_TrainingTitile.Text.Trim();
            int coach = (int)comboBox_TrainingCoach.SelectedValue;
            int maxUsers = (int)numericUpDown_QuantityUsers.Value;

            try
            {
                if (_TrainingId.HasValue)
                {
                    // Обновление
                    string query = "UPDATE public.\"Training\" SET title = @title, coach = @coach, " +
                                   "max_users = @maxUsers WHERE training_id = @TrainingId";

                    using (var cmd = new NpgsqlCommand(query, _connection))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@coach", coach);
                        cmd.Parameters.AddWithValue("@maxUsers", maxUsers);
                        cmd.Parameters.AddWithValue("@TrainingId", _TrainingId.Value);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Тренировка успешно обновлёна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Добавление новой тренировки
                    string query = "INSERT INTO public.\"Training\" (title, coach, max_users) " +
                                   "VALUES (@title, @coach, @maxUsers )";

                    using (var cmd = new NpgsqlCommand(query, _connection))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@coach", coach);
                        cmd.Parameters.AddWithValue("@maxUsers", maxUsers);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Тренировка успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
