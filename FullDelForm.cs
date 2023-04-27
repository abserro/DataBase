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
    public partial class FullDelForm : Form
    {
        private OleDbConnection connection;

        public FullDelForm()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД_ЛР_6.mdb";
            connection = new OleDbConnection(connectionString);
            connection.Open();
        }

        /// <summary>
        /// удаление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (numAudit.Text != "" && numGroup.Text != "" && idSubject.Text != "" && numTeacher.Text != "" && day.Text != "" && time.Text != "" && type.Text != "")
            {
                int numAuditorium = Convert.ToInt32(numAudit.Text);
                int numGroup = Convert.ToInt32(this.numGroup.Text);
                int idSub = Convert.ToInt32(idSubject.Text);
                int numTeacher = Convert.ToInt32(this.numTeacher.Text);
                // string day = this.day.Text;
                //string day = string.Format("MM-dd-yyyy", this.day.Text);
                string day = this.day.Text;
                string day1 = day[3].ToString() + day[4].ToString() + "/" + day[0].ToString() + day[1].ToString() + "/" + day[6].ToString() + day[7].ToString() + day[8].ToString() + day[9].ToString();
                string time = this.time.Text;
                string time1 = time[0].ToString() + time[1].ToString() + ":" + time[3].ToString() + time[4].ToString();
                string type = this.type.Text;

                string querty_check = "Select * From Занятие Where [Номер аудитории] = " + numAuditorium 
                                                                + " and [Номер группы] = " + numGroup
                                                                + " and [Идентификатор предмета] = " + idSub
                                                                + " and [Табельный номер] = " + numTeacher
                                                                + " and [День проведения] = #" + day1 + "#"
                                                                + " and [Время проведения] = #" + time1 + "#"
                                                                + " and [Тип] = '" + type + "'";
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count > 0)
                {
                    string query = "DELETE FROM Занятие Where [Номер аудитории] = " + numAuditorium
                                                                + " and [Номер группы] = " + numGroup
                                                                + " and [Идентификатор предмета] = " + idSub
                                                                + " and [Табельный номер] = " + numTeacher
                                                                + " and [День проведения] = #" + day1 + "#"
                                                                + " and [Время проведения] = #" + time1 + "#"
                                                                + " and [Тип] = '" + type + "'";
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
