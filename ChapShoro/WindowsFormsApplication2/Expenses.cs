using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Expenses : Form
    {
        private OleDbConnection xConnection;
        private OleDbDataAdapter xDataAdapter;
        private DataSet xDataSet;
        DataTable saleTable = new DataTable();
        public Expenses()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbExpendOn.Text != "" && tbAmount.Text != "") { 
                
            }
        }
    }
}
