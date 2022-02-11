using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProjectSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                string serverName = serverList.SelectedItem.ToString();
                string dbName = dataBaseList.SelectedItem.ToString();

                var newMainFrom = new MainForm(this, serverName, dbName);
                //Hide();
                newMainFrom.ShowDialog();
            }
            catch 
            {
                MessageBox.Show("Не выбран сервер или БД");
                Close();
            }
        }

        private void serverList_Click(object sender, EventArgs e)
        {
            if (serverList.Items.Count == 0)
            {
                serverList.DataSource = GetServerList();
                try
                {
                    serverList.SelectedIndex = 0;
                }
                catch
                {
                    MessageBox.Show("Ни один сервер не найден");
                }
            }
        }
        private void dataBaseList_Click(object sender, EventArgs e)
        {
            try
            {
                string serverName = serverList.SelectedItem.ToString();
                if (dataBaseList.Items.Count == 0)
                    dataBaseList.DataSource = GetDbList(serverName);
            }
            catch
            {
                MessageBox.Show("Базы данных не обнаружены");
            }
        }

        private static IEnumerable<string> GetDbList(string serverName)
        {
            string connString = "server = " + serverName + ";" + "integrated security = SSPI";
            var connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                var command = new SqlCommand("exec sp_databases", connection);
                List<string> dbList = new List<string>();
                var reader = command.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                        dbList.Add(reader[0].ToString());
                    reader.Close();
                }
                return dbList;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }

        private static IEnumerable<string> GetServerList()
        {
            var ssdt = SqlDataSourceEnumerator.Instance.GetDataSources();
            List<string> srvList = new List<string>();
            string newServ;

            for (int i = 0; i < ssdt.Rows.Count; i++)
            {
                newServ = ssdt.Rows[i].ItemArray[0] + "\\" + ssdt.Rows[i].ItemArray[1];
                srvList.Add(newServ);
            }

            return srvList;
        }
    }
}
