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
    public partial class FullDelCafForm : Form
    {
        private OleDbConnection connection;

        public FullDelCafForm()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД_ЛР_6.mdb";
            connection = new OleDbConnection(connectionString);
            connection.Open();
        }

        private void delTeacher_Click(object sender, EventArgs e)
        {
            if (idDepart.Text != "" && maskedTextBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && maskedTextBox2.Text != "")
            {
                int idDep = Convert.ToInt32(idDepart.Text);
                int numberTab = Convert.ToInt32(maskedTextBox1.Text);
                string name = textBox2.Text;
                string sortName = textBox3.Text;
                int countBids = Convert.ToInt32(maskedTextBox2.Text);

                string querty_check = "Select * From Кафедра Where [Идентификатор кафедры] = " + idDep
                                                                + " and [Табельный номер] = " + numberTab
                                                                + " and [Название] = '" + name + "'"
                                                                + " and [Сокращенное название] = '" + sortName + "'"
                                                                + " and [Количество ставок] = " + countBids;
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count > 0)
                {
                    string query = "DELETE FROM Кафедра Where [Идентификатор кафедры] = " + idDep
                                                                + " and [Табельный номер] = " + numberTab
                                                                + " and [Название] = '" + name + "'"
                                                                + " and [Сокращенное название] = '" + sortName + "'"
                                                                + " and [Количество ставок] = " + countBids;
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
