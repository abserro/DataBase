using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LR7_BD
{
    public partial class FullDelTeacherForm : Form
    {
        private OleDbConnection connection;

        public FullDelTeacherForm()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД_ЛР_6.mdb";
            connection = new OleDbConnection(connectionString);
            connection.Open();
        }

        private void delTeacher_Click(object sender, EventArgs e)
        {
            if (numTeacher.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && maskedTextBox1.Text != "" && maskedTextBox2.Text != "")
            {
                int num = Convert.ToInt32(numTeacher.Text);
                string surname = textBox1.Text;
                string name = textBox2.Text;
                string patronymic = textBox3.Text;
                string post = textBox4.Text;
                int experience = Convert.ToInt32(maskedTextBox1.Text);
                int id = Convert.ToInt32(maskedTextBox2.Text);

                string querty_check = "Select * From Преподаватель Where [Табельный номер] = " + num
                                                                + " and [Фамилия] = '" + surname + "'"
                                                                + " and [Имя] = '" + name + "'"
                                                                + " and [Отчество] = '" + patronymic + "'"
                                                                + " and [Должность] = '" + post + "'"
                                                                + " and [Стаж работы] = " + experience
                                                                + " and [Идентификатор кафедры] = " + id;
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count > 0)
                {
                    string query = "DELETE FROM Преподаватель Where [Табельный номер] = " + num
                                                                + " and [Фамилия] = '" + surname + "'"
                                                                + " and [Имя] = '" + name + "'"
                                                                + " and [Отчество] = '" + patronymic + "'"
                                                                + " and [Должность] = '" + post + "'"
                                                                + " and [Стаж работы] = " + experience
                                                                + " and [Идентификатор кафедры] = " + id;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }
    }
}
