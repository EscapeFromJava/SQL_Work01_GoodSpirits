using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectSQL
{
    public partial class MainForm : Form
    {
        private readonly Form _mainForm;
        private readonly string _connstring;

        public MainForm(Form mainForm, string serverName, string dbName)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _connstring = "server = " + serverName + ";" + "integrated security = SSPI;" + "database = " + dbName;

            var connection = new SqlConnection(_connstring);
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Close();
            }
            finally
            {
                connection.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateStoreList();
        }

        public void UpdateStoreList()
        {
            var localDB = new DataBase(_connstring);
            try
            {
                StoreList.Items.Clear();
                var storeListData = localDB.GetProdList();
                foreach (var storeData in storeListData)
                {
                    var item = new ListViewItem(new string[]
                        {
                            storeData.From.ToString(),
                            storeData.To.ToString(),
                            storeData.Cost.ToString()
                        });
                    StoreList.Items.Add(item);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm(this, _connstring);
            addForm.Show();
        }

        private void StoreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in StoreList.Items)
                item.ForeColor = Color.Gray;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectNumber = -1;
            foreach (ListViewItem item in StoreList.Items)
                if (item.Selected)
                    selectNumber = int.Parse(item.Text);
            var localDb = new DataBase(_connstring);
            bool result = localDb.DeleteProd(selectNumber);

            UpdateStoreList();
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Здесь будет результат!";
        }
    }
}
