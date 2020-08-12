using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class SaleReport : Form
    {

       // private OleDbCommand xCommand;
        private OleDbConnection xConnection;
        private OleDbDataAdapter xDataAdapter;
        private DataSet xDataSet;
        DataTable saleTable = new DataTable();
        public SaleReport()
        {
            InitializeComponent();
        }
        
        private void SaleReport_Load(object sender, EventArgs e)
        {
            xConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Chap_ShoroDB.mdb;Jet OLEDB:Database Password=basit12");
            DGV1.DataSource = saleTable;

            RefreshGridSaleReport();
            DGV1.Columns[0].Width = 50;
            int totalIndex = xDataSet.Tables[0].Rows.Count;
            lblSellCountNumber_SellReport.Text = totalIndex.ToString();
                double total = 0;
                for (int i = 0; i < totalIndex; i++)
                {
                    double iAmount = Convert.ToDouble(DGV1.Rows[i].Cells[3].Value.ToString());
                    total += iAmount;
                }
                lblSellAmountNumber_SellReport.Text = total.ToString();

                cbmf.Visible = false;
                cbyf.Visible = false;
                lblMonthSellReport.Visible = false;
                lblYearSellReport.Visible = false;
                lblTo.Visible = false;
                lblFrom.Visible = false;
                cbmf.Text = "";
                cbyf.Text = "";
                dtFrom.Visible = false;
                dtTo.Visible = false;
                rdWhole.Checked = true;

        }
        private void RefreshGridSaleReport()
        {
            try
            {
                xConnection.Open();
                xDataSet = new DataSet();
                xDataAdapter = new OleDbDataAdapter("Select * from Tbl_Bill", xConnection);
                xDataAdapter.Fill(xDataSet);
                DGV1.DataSource = xDataSet.Tables[0];
                DGV1.Columns[0].Width = 50;
                DGV1.Columns[1].Width = 70;
                DGV1.Columns[2].Width = 70;
                DGV1.Columns[3].Width = 70;
                DGV1.Columns[4].Width = 70;
                DGV1.Columns[5].Width = 150;
                DGV1.Columns[5].DefaultCellStyle.Format = ("dd-MMM-yyyy hh:mm:ss tt");
                xConnection.Close();
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(":: Following Error Occured :: \n" + ex.Message.ToString(), ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblReportBy_Click(object sender, EventArgs e)
        {

        }

        private void lblSellsCount_SellReport_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblSellAmount_SellReport_Click(object sender, EventArgs e)
        {

        }

        private void btnShowReport_SalesReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdDaily.Checked==true) 
               {
                        string s = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss tt");
                        var a = DateTime.Now.Date.AddDays(-1);
                        string y = a.ToString("dd/MMM/yyyy") + " 04:00:00 PM";
                       // y = "#" + y + "#";
                        //Select * from Tbl_Bill where Bill_Date between #27-May-2019 04:00:00 PM# AND #28-May-2019 06:22:00 AM#;
                        string x = "Select * from Tbl_Bill where Bill_Date between #"+y+"# AND #"+s+"#";
                        xDataSet = new DataSet();
                        xDataAdapter = new OleDbDataAdapter(x, xConnection);
                        xDataAdapter.Fill(xDataSet);
                      
                        DGV1.DataSource = xDataSet.Tables[0];
                        DGV1.Columns[0].Width = 50;
                        DGV1.Columns[1].Width = 70;
                        DGV1.Columns[2].Width = 70;
                        DGV1.Columns[3].Width = 70;
                        DGV1.Columns[4].Width = 70;
                        DGV1.Columns[5].Width = 150;
                        DGV1.Columns[5].DefaultCellStyle.Format=("dd-MMM-yyyy hh:mm:ss tt");
                        xConnection.Close();
              
               }
                else if (rdDuration.Checked == true) {
                    string s = dtTo.Text.ToString();
                    string y = dtFrom.Text.ToString(); 
                    // y = "#" + y + "#";
                    //Select * from Tbl_Bill where Bill_Date between #27-May-2019 04:00:00 PM# AND #28-May-2019 06:22:00 AM#;
                    string x = "Select * from Tbl_Bill where Bill_Date between #" + y + "# AND #" + s + "#";
                    xDataSet = new DataSet();
                    xDataAdapter = new OleDbDataAdapter(x, xConnection);
                    xDataAdapter.Fill(xDataSet);

                    DGV1.DataSource = xDataSet.Tables[0];
                    DGV1.Columns[0].Width = 50;
                    DGV1.Columns[1].Width = 70;
                    DGV1.Columns[2].Width = 70;
                    DGV1.Columns[3].Width = 70;
                    DGV1.Columns[4].Width = 70;
                    DGV1.Columns[5].Width = 150;
                    DGV1.Columns[5].DefaultCellStyle.Format = ("dd-MMM-yyyy hh:mm:ss tt");
                    xConnection.Close();
                
                }

                else if (rdYear.Checked == true)
                {
                    if ((cbyf.Text != ""))
                    {
                        xDataSet = new DataSet();
                        xDataAdapter = new OleDbDataAdapter("Select * from Tbl_Bill where Bill_Date like '%" + cbyf.Text + "%'", xConnection);
                        xDataAdapter.Fill(xDataSet);
                        DGV1.DataSource = xDataSet.Tables[0];
                        DGV1.Columns[0].Width = 50;
                        DGV1.Columns[1].Width = 70;
                        DGV1.Columns[2].Width = 70;
                        DGV1.Columns[3].Width = 70;
                        DGV1.Columns[4].Width = 70;
                        DGV1.Columns[5].Width = 150;
                        DGV1.Columns[5].DefaultCellStyle.Format = ("dd-MMM-yyyy hh:mm:ss tt");
                        xConnection.Close();
                    }
                    else
                    {
                        xDataSet = new DataSet();
                        xDataAdapter = new OleDbDataAdapter("Select * from Tbl_Bill where Bill_Date like '%" + cbyf.Text + "%'", xConnection);
                        xDataAdapter.Fill(xDataSet);
                        DGV1.DataSource = xDataSet.Tables[0];
                        DGV1.Columns[0].Width = 50;
                        DGV1.Columns[1].Width = 70;
                        DGV1.Columns[2].Width = 70;
                        DGV1.Columns[3].Width = 70;
                        DGV1.Columns[4].Width = 70;
                        DGV1.Columns[5].Width = 150;
                        DGV1.Columns[5].DefaultCellStyle.Format = ("dd-MMM-yyyy hh:mm:ss tt");
                        xConnection.Close();
                        MessageBox.Show(":: Error Occured :: \n" + "Select Year", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (rdMonthly.Checked == true) { 
                            if ((cbmf.Text.ToString() != "") && (cbyf.Text.ToString() != ""))
                    {
                        xDataSet = new DataSet();
                        xDataAdapter = new OleDbDataAdapter("Select * from Tbl_Bill WHERE ((Month([Bill_Date])=" + cbmf.Text.ToString() + ") AND (Year([Bill_Date])=" + cbyf.Text.ToString() + ") );", xConnection);
                        xDataAdapter.Fill(xDataSet);
                        DGV1.DataSource = xDataSet.Tables[0];
                        DGV1.Columns[0].Width = 50;
                        DGV1.Columns[1].Width = 70;
                        DGV1.Columns[2].Width = 70;
                        DGV1.Columns[3].Width = 70;
                        DGV1.Columns[4].Width = 70;
                        DGV1.Columns[5].Width = 150;
                        DGV1.Columns[5].DefaultCellStyle.Format = ("dd-MMM-yyyy hh:mm:ss tt");
                        xConnection.Close();
                    }
                            else if ((cbmf.Text.ToString() == "") || (cbyf.Text.ToString() == ""))
                            {
                                MessageBox.Show(":: Error Occured :: \n" + "Select Month and Year both", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                }



                else if (rdWhole.Checked == true)
                {
                    xDataSet = new DataSet();
                    xDataAdapter = new OleDbDataAdapter("Select * from Tbl_Bill ", xConnection);
                    xDataAdapter.Fill(xDataSet);
                    DGV1.DataSource = xDataSet.Tables[0];
                    DGV1.Columns[0].Width = 50;
                    DGV1.Columns[1].Width = 70;
                    DGV1.Columns[2].Width = 70;
                    DGV1.Columns[3].Width = 70;
                    DGV1.Columns[4].Width = 70;
                    DGV1.Columns[5].Width = 150;

                    xConnection.Close();
                }
              
                
            }
            catch (Exception ex) { MessageBox.Show(":: Following Error Occured :: \n" + ex.Message.ToString(), ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            DGV1.Columns[0].Width = 50;
            int totalIndex = xDataSet.Tables[0].Rows.Count;
            if (totalIndex != 0)
            {
                lblSellCountNumber_SellReport.Text = totalIndex.ToString();
                double total = 0;
                for (int i = 0; i < totalIndex; i++)
                {
                    double iAmount = Convert.ToDouble(DGV1.Rows[i].Cells[3].Value.ToString());
                    total += iAmount;
                }
                lblSellAmountNumber_SellReport.Text = total.ToString();
            }
            else {
                lblSellAmountNumber_SellReport.Text = "0";
                lblSellCountNumber_SellReport.Text = "0";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_SalesReport_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure to exit?", ":: From Sale Cell::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void rdYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rdYear.Checked == true)
            {
                cbmf.Visible = false;
                cbyf.Visible = true;
                lblMonthSellReport.Visible = false;
                lblYearSellReport.Visible = true;
                lblTo.Visible = false;
                lblFrom.Visible = false;
                cbmf.Text = "";
                cbyf.Text = "";
                dtFrom.Visible = false;
                dtTo.Visible = false;
            }
           
        }

        private void rdDaily_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDaily.Checked == true)
            {
                cbmf.Visible = false;
                cbyf.Visible = false;
                lblMonthSellReport.Visible = false;
                lblYearSellReport.Visible = false;
                lblTo.Visible = false;
                lblFrom.Visible = false;
                cbmf.Text = "";
                cbyf.Text = "";
                dtFrom.Visible = false;
                dtTo.Visible = false;
            }
           // else {
           //     cbmf.Enabled = true;
           //     cbmf.Text = "";
           //     cbyf.Text = "";
           //     cbyf.Enabled = true;
           // }
        }

        private void rdMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMonthly.Checked == true)
            {
                cbmf.Visible = true;
                cbyf.Visible = true;
                lblMonthSellReport.Visible = true;
                lblYearSellReport.Visible = true;
                lblTo.Visible = false;
                lblFrom.Visible = false;
                cbmf.Text = "";
                cbyf.Text = "";
                dtFrom.Visible = false;
                dtTo.Visible = false;
            }
         //   else {
         //       cbmf.Enabled = false;
        //        cbyf.Enabled = false;
          //  }
        }

        private void rdWhole_CheckedChanged(object sender, EventArgs e)
        {
            if (rdWhole.Checked == true)
            {
                cbmf.Visible = false;
                cbyf.Visible = false;
                lblMonthSellReport.Visible = false;
                lblYearSellReport.Visible = false;
                lblTo.Visible = false;
                lblFrom.Visible = false;
                cbmf.Text = "";
                cbyf.Text = "";
                dtFrom.Visible =false;
                dtTo.Visible = false;
            }
        }

        private void rdDuration_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDuration.Checked == true)
            {
                cbmf.Visible = false;
                cbyf.Visible = false;
                lblMonthSellReport.Visible = false;
                lblYearSellReport.Visible = false;
                lblTo.Visible = true;
                lblFrom.Visible = true;
                cbmf.Text = "";
                cbyf.Text = "";
                dtFrom.Visible = true;
                dtTo.Visible = true;
                dtTo.MaxDate = DateTime.Now;
                dtFrom.MaxDate = DateTime.Now;
            }
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }
       
    }
}
