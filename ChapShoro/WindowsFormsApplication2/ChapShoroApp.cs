using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ChapShoroApp : Form
    {
       

        public ChapShoroApp()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTable10_Click(object sender, EventArgs e)
        {

        }

        private void btnSellReport_Click(object sender, EventArgs e)
        {
            
            SaleReport s = new SaleReport();
            s.MdiParent = this;
            s.Show();
        }
        
        private void ChapShoroApp_Load(object sender, EventArgs e)
        {

        }

        


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure to exit?", ":: CHAP SHORO APP::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        
        
        private void btnTable1_Click(object sender, EventArgs e)
        {

            POS p1 = new POS();
            p1.MdiParent = this;
            p1.Text = "Point Of Sale";
            p1.Show();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            Expenses ex = new Expenses();
            ex.MdiParent = this;
            ex.Show();
        }

      
      
    }
}
