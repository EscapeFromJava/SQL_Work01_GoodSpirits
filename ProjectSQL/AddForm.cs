using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSQL
{
    public partial class AddForm : Form
    {
        private readonly MainForm _mainForm;
        private readonly string _connstring;
        public AddForm(MainForm mainForm, string connstring)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _connstring = connstring;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string fromP = boxFrom.Text;
            string toP = boxTo.Text;
            int costP = int.Parse(boxCost.Text);

            var localDb = new DataBase(_connstring);
            bool result = localDb.AddNewProd(fromP, toP, costP);
            if (result)
                ClearForm();
            _mainForm.UpdateStoreList();
        }
        private void ClearForm()
        {
            boxFrom.Clear();
            boxTo.Clear();
            boxCost.Clear();
        }
    }
}
