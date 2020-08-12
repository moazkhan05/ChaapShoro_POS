using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;

namespace WindowsFormsApplication2
{
    public partial class POS : Form
    {
        public ChapShoroApp chap { get; set; }
        private int BillRow;
        private PrintDocument pdoc;
        private OleDbCommand xCommand;
        private OleDbConnection xConnection;
        private OleDbDataAdapter xDataAdapter;
        private DataSet xDataSet;
        DataTable orderTable = new DataTable();

        public POS()
        {
            InitializeComponent();
            cbTable.TextChanged += new EventHandler(cbTable_SelectedIndexChanged);
            tbCustomerName.TextChanged += new EventHandler(tbCustomerName_TextChanged);
            rbTakeAway.TextChanged += new EventHandler(rbTakeAway_CheckedChanged);
            rbDineIn.TextChanged += new EventHandler(rbDineIn_CheckedChanged);
            rbDelivery.TextChanged += new EventHandler(rbDelivery_CheckedChanged);
            btnBillPayed.Visible = false;
            rbDineIn.Checked = true;

            // tbDiscount.Enabled=true;
        }

        /*  private void FillWaiters() {
              xConnection.Open();
              xDataSet = new DataSet();
              xDataAdapter = new OleDbDataAdapter("Select * from Tbl_Waiters", xConnection);
              xDataAdapter.Fill(xDataSet);
              int i = 0;
            
              while (i<xDataSet.Tables[0].Rows.Count) {
                  string name = xDataSet.Tables[0].Rows[i][1].ToString();
                  cbWaiter.Items.Add(name);
                  i++;
              }

              xConnection.Close();
          }*/

        private void RefreshGridFoodItems()
        {
            try
            {
                xConnection.Open();
                xDataSet = new DataSet();
                xDataAdapter = new OleDbDataAdapter("Select * from Tbl_FoodItems", xConnection);
                xDataAdapter.Fill(xDataSet);
                DGV2.DataSource = xDataSet.Tables[0];
                xConnection.Close();
                DGV2.Columns[0].Width = 40;
                DGV2.Columns[1].Width = 150;
                DGV2.Columns[2].Width = 70;
                // lblMembers.Text = "Total Members: " + xDataSet.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(":: Following Error Occured :: \n" + ex.Message.ToString(), ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void POS_Load(object sender, EventArgs e)
        {

            xConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Chap_ShoroDB.mdb;Jet OLEDB:Database Password=basit12");
            RefreshGridFoodItems();
            //FillWaiters();
            orderTable.Columns.Add("Item Id", typeof(int));
            orderTable.Columns.Add("Name", typeof(string));
            orderTable.Columns.Add("Price", typeof(string));
            orderTable.Columns.Add("Qty", typeof(string));
            orderTable.Columns.Add("Amount", typeof(String));
            orderTable.Columns.Add("Discount", typeof(String));


            DGV1.DataSource = orderTable;
            DGV1.Columns[0].Width = 28;
            DGV1.Columns[1].Width = 135;
            DGV1.Columns[2].Width = 65;
            DGV1.Columns[3].Width = 30;
            DGV1.Columns[4].Width = 75;
            DGV1.Columns[5].Width = 35;

            cbTable.Visible = true;
            lblWaiter.Visible = true;
            cbWaiter.Visible = true;
            cbTable.Text = "";
            cbWaiter.Text = "";
            lblCharges.Visible = false;
            tbCharges.Visible = false;
            lblName.Visible = false;
            tbCustomerName.Visible = false;
            lblPhoneNo.Visible = false;
            tbPhoneNo.Visible = false;
            lblAddress.Visible = false;
            tbAddress.Visible = false;
            tbAddress2.Visible = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure to exit?", ":: POS::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAddItemInOrder_Click_1(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show(":: Error Occured :: \n" + "Select Item First", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double total = 0;
                int iFinalBill = 0;
                orderTable.Rows.Add(tbID.Text, tbName.Text, tbPrice.Text, tbQty.Text, tbAmount.Text, "0");
                /*start print code
                PrintPreviewDialog pre = new PrintPreviewDialog();
                PrintDialog pd = new PrintDialog();
                pdoc = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                PaperSize psize = new PaperSize("Custom", 75, 200);
                pd.Document = pdoc;
                pd.Document.DefaultPageSettings.PaperSize = psize;
                pdoc.DefaultPageSettings.PaperSize.Height = 820;
                pdoc.DefaultPageSettings.PaperSize.Width = 300;
                pdoc.PrintPage += new PrintPageEventHandler(pdoc_Token);
                pre.Document = pdoc;
                pre.ShowDialog();
                      

                end print code*/
                for (int i = 0; i < orderTable.Rows.Count; i++)
                {

                    double iAmount = Convert.ToDouble(orderTable.Rows[i][4].ToString());
                    total += iAmount;
                }


                if (!(tbDiscount.Text.Equals("") || tbDiscount.Text.Equals("")))
                {
                    int iDiscount = Int32.Parse(tbDiscount.Text);
                    iDiscount /= 100;
                    iFinalBill = (int)total * iDiscount;
                }
                else
                {
                    iFinalBill = (int)total;
                }
                lblFinalBillAmount.Text = iFinalBill.ToString();
                lbl_TotalAmounnt.Text = total.ToString();
                tbName.Text = "".ToString();
                tbID.Text = "".ToString();
                tbPrice.Text = "".ToString();
                tbQty.Text = "".ToString();
                tbAmount.Text = "".ToString();
                tbSearch.Text = "".ToString();
                cbMenuSelection.Text = "All";
                //tbDiscOnItem.Text = "".ToString();
                RefreshGridFoodItems();
            }
        }

        /*print token

        void pdoc_Token(object sender, PrintPageEventArgs e)
        {
            
            Graphics g = e.Graphics;

            FontFamily fontFamily = new FontFamily("Courier New");
            Font font = new Font(
               fontFamily,
               10,
               FontStyle.Bold,
               GraphicsUnit.Pixel);

            FontFamily fontFamily2 = new FontFamily("Arial");
            Font fontHeads = new Font(
               fontFamily2,
               10.50F,
               FontStyle.Bold,
               GraphicsUnit.Pixel);
            //Font fontHeads = new Font("Arial Black", 10);


            int fontHeight = Convert.ToInt32(font.GetHeight());
            int fontHeadHeight = Convert.ToInt32(fontHeads.GetHeight());

            int startX = 0;
            int startY = 10;
            int offSet = 30;

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            

            g.DrawString("Token", new Font("Courier New", 22, FontStyle.Bold), new SolidBrush(Color.Black), e.PageBounds.Width / 2, startY + offSet, sf);
            offSet = offSet + fontHeadHeight + 7;

            string date = "Date Time:  " + DateTime.Now.ToString() + "";
            g.DrawString(date, new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
            offSet = offSet + fontHeadHeight + 5;

            g.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", fontHeads, new SolidBrush(Color.Black), 0, startY + offSet);
            offSet += (fontHeadHeight + 7);


            int j = orderTable.Rows.Count-1;
                string n=DGV1.Rows[j].Cells[1].Value.ToString();//product name
                g.DrawString("Name:  "+n, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black),startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 7;
                n=DGV1.Rows[j].Cells[3].Value.ToString();
                g.DrawString("Quantity:  " + n, new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 7;

            g.DrawString("___________________________________________________________________________", fontHeads, new SolidBrush(Color.Black), 0, startY + offSet);
            offSet = offSet + fontHeadHeight + 5;


        }


        //end print token
        */
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string sItem = DGV1.CurrentRow.Cells[1].Value.ToString();
            DialogResult DR = MessageBox.Show("Are you sure to Delete" + sItem + "?", ":: POS::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                int total = 0;
                int iFinalBill = 0;
                //orderTable.Rows.Remove(tbName.Text, tbPrice.Text, tbQty.Text, tbAmount.Text);
                int rowIndex = DGV1.CurrentCell.RowIndex;
                DGV1.Rows.RemoveAt(rowIndex);


                for (int i = 0; i < orderTable.Rows.Count; i++)
                {

                    int iAmount = Int32.Parse(orderTable.Rows[i][4].ToString());
                    total += iAmount;
                }
                if (!(tbDiscount.Text.Equals("") || tbDiscount.Text.Equals("")))
                {
                    int iDiscount = Int32.Parse(tbDiscount.Text);
                    iDiscount /= 100;
                    iFinalBill = total * iDiscount;
                }
                else
                {
                    iFinalBill = total;
                }
                lblFinalBillAmount.Text = iFinalBill.ToString();
                lbl_TotalAmounnt.Text = total.ToString();
                tbName.Text = "".ToString();
                tbID.Text = "".ToString();
                tbPrice.Text = "".ToString();
                tbQty.Text = "".ToString();
                tbAmount.Text = "".ToString();
                btnAddItemInOrder.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (tbName.Text == "")
            {
                MessageBox.Show(":: Error Occured :: \n" + "Select Item First", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int rowIndex = DGV1.CurrentCell.RowIndex;
                DGV1.CurrentRow.Cells[0].Value = tbID.Text;
                DGV1.CurrentRow.Cells[1].Value = tbName.Text;
                DGV1.CurrentRow.Cells[2].Value = tbPrice.Text;
                DGV1.CurrentRow.Cells[3].Value = tbQty.Text;
                DGV1.CurrentRow.Cells[4].Value = tbAmount.Text;

                int total = 0;
                int iFinalBill = 0;
                for (int i = 0; i < orderTable.Rows.Count; i++)
                {

                    int iAmount = Int32.Parse(orderTable.Rows[i][4].ToString());
                    total += iAmount;
                }
                if (!(tbDiscount.Text.Equals("") || tbDiscount.Text.Equals("")))
                {
                    int iDiscount = Int32.Parse(tbDiscount.Text);
                    iDiscount /= 100;
                    iFinalBill = total * iDiscount;
                }
                else
                {
                    iFinalBill = total;
                }
                lblFinalBillAmount.Text = iFinalBill.ToString();
                lbl_TotalAmounnt.Text = total.ToString();
                tbName.Text = "".ToString();
                tbPrice.Text = "".ToString();
                tbQty.Text = "".ToString();
                tbAmount.Text = "".ToString();
                btnAddItemInOrder.Visible = true;

            }

        }

        private void btnGenerateBill_Click_1(object sender, EventArgs e)
        {
            if (rbTakeAway.Checked == true)
            {
                double iLblAmount = Convert.ToDouble(lbl_TotalAmounnt.Text.ToString());
                double iFinalBill = Convert.ToDouble(lblFinalBillAmount.Text.ToString());
                int iDisc;
                if (tbDiscount.Text.ToString().Equals("")) { iDisc = 0; } else { iDisc = Int32.Parse(tbDiscount.Text.ToString()); }

                if (iLblAmount != 0.0 && iFinalBill != 0.0)
                {
                    try
                    {
                        saveBillinDB();



                        PrintPreviewDialog pre = new PrintPreviewDialog();
                        PrintDialog pd = new PrintDialog();
                        pdoc = new PrintDocument();
                        PrinterSettings ps = new PrinterSettings();
                        PaperSize psize = new PaperSize("Custom", 75, 200);
                        pd.Document = pdoc;
                        pd.Document.DefaultPageSettings.PaperSize = psize;
                        pdoc.DefaultPageSettings.PaperSize.Height = 820;
                        pdoc.DefaultPageSettings.PaperSize.Width = 300;
                        pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
                        pre.Document = pdoc;
                        pre.ShowDialog();
                        // pdoc.Print();
                        //  pdoc.Print();

                        //this.Dispose();
                        btnAddItemInOrder.Enabled = false;
                        btnUpdate.Enabled = false;
                        btnDeleteItem.Enabled = false;
                        tbDiscount.Enabled = false;
                        rbDelivery.Enabled = false;
                        rbDineIn.Enabled = false;
                        rbTakeAway.Enabled = false;
                        btnPrintToken.Enabled = false;
                        btnSetDiscMulitiple.Enabled = false;
                        tbDiscMultiple.Enabled = false;
                        btnExit.Visible = false;
                        btnGenerateBill.Visible = false;
                        btnBillPayed.Visible = true;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(":: During Bill Generation, following error occured :: \n" + ex.Message.ToString(), ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { MessageBox.Show(":: During Bill Generation, following error occured :: \n" + "You don't have any data to print", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error); }



            }
            else if (rbDineIn.Checked == true)
            {
                if (cbTable.Text != "" && cbWaiter.Text != "")
                {
                    int iLblAmount = Int32.Parse(lbl_TotalAmounnt.Text.ToString());
                    double iFinalBill = Convert.ToDouble(lblFinalBillAmount.Text.ToString());
                    int iDisc;
                    if (tbDiscount.Text.ToString().Equals("")) { iDisc = 0; } else { iDisc = Int32.Parse(tbDiscount.Text.ToString()); }

                    if (iLblAmount != 0 && iFinalBill != 0.0)
                    {
                        try
                        {
                            saveBillinDB();

                            btnBillPayed.Visible = true;
                            PrintPreviewDialog pre = new PrintPreviewDialog();
                            PrintDialog pd = new PrintDialog();
                            pdoc = new PrintDocument();
                            PrinterSettings ps = new PrinterSettings();
                            PaperSize psize = new PaperSize("Custom", 75, 200);
                            pd.Document = pdoc;
                            pd.Document.DefaultPageSettings.PaperSize = psize;
                            pdoc.DefaultPageSettings.PaperSize.Height = 820;
                            pdoc.DefaultPageSettings.PaperSize.Width = 300;
                            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
                            pre.Document = pdoc;
                            pre.ShowDialog();
                            //  pdoc.Print();
                            //  pdoc.Print();
                            // this.Dispose();
                            btnAddItemInOrder.Enabled = false;
                            btnUpdate.Enabled = false;
                            btnDeleteItem.Enabled = false;
                            tbDiscount.Enabled = false;
                            rbDelivery.Enabled = false;
                            rbDineIn.Enabled = false;
                            rbTakeAway.Enabled = false;
                            cbTable.Enabled = false;
                            cbWaiter.Enabled = false;
                            btnExit.Visible = false;
                            btnGenerateBill.Visible = false;
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(":: During Bill Generation, following error occured :: \n" + ex.Message.ToString(), ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else { MessageBox.Show(":: During Bill Generation, following error occured :: \n" + "You don't have any data to print", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
                else
                {
                    MessageBox.Show(":: NOT A PROPER INFO:: \n" + "Info About Table / Waiter is MISSING", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbDelivery.Checked == true)
            {
                if (tbCharges.Text != "" && tbCustomerName.Text != "" && tbPhoneNo.Text != "" && tbAddress.Text != "")
                {
                    int iLblAmount = Int32.Parse(lbl_TotalAmounnt.Text.ToString());
                    double iFinalBill = Convert.ToDouble(lblFinalBillAmount.Text.ToString());
                    int iDisc;
                    if (tbDiscount.Text.ToString().Equals("")) { iDisc = 0; } else { iDisc = Int32.Parse(tbDiscount.Text.ToString()); }

                    if (iLblAmount != 0 && iFinalBill != 0.0)
                    {
                        try
                        {
                            saveBillinDB();

                            btnBillPayed.Visible = true;
                            PrintPreviewDialog pre = new PrintPreviewDialog();
                            PrintDialog pd = new PrintDialog();
                            pdoc = new PrintDocument();
                            PrinterSettings ps = new PrinterSettings();
                            PaperSize psize = new PaperSize("Custom", 75, 200);
                            pd.Document = pdoc;
                            pd.Document.DefaultPageSettings.PaperSize = psize;
                            pdoc.DefaultPageSettings.PaperSize.Height = 820;
                            pdoc.DefaultPageSettings.PaperSize.Width = 300;
                            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
                            pre.Document = pdoc;
                            pre.ShowDialog();

                            //  pdoc.Print();
                            //  pdoc.Print();
                            //  this.Dispose();
                            btnAddItemInOrder.Enabled = false;
                            btnUpdate.Enabled = false;
                            btnDeleteItem.Enabled = false;
                            tbDiscount.Enabled = false;
                            rbDelivery.Enabled = false;
                            rbDineIn.Enabled = false;
                            rbTakeAway.Enabled = false;
                            tbCharges.Enabled = false;
                            tbCustomerName.Enabled = false;
                            tbPhoneNo.Enabled = false;
                            tbAddress.Enabled = false;
                            tbAddress2.Enabled = false;
                            btnExit.Visible = false;
                            btnGenerateBill.Visible = false;
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(":: During Bill Generation, following error occured :: \n" + ex.Message.ToString(), ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else { MessageBox.Show(":: During Bill Generation, following error occured :: \n" + "You don't have any data to print", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
                else
                {
                    MessageBox.Show(":: NOT A PROPER INFO:: \n" + "Info About Customer/ Delivery Charges is MISSING", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { MessageBox.Show(":: During Bill Generation, following error occured :: \n" + "Select OrderType", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void saveBillinDB()
        {
            double iLblAmount = Convert.ToDouble(lbl_TotalAmounnt.Text.ToString());
            double iFinalBill = Convert.ToDouble(lblFinalBillAmount.Text.ToString());
            int iDisc;
            if (tbDiscount.Text.ToString().Equals("")) { iDisc = 0; } else { iDisc = Int32.Parse(tbDiscount.Text.ToString()); }
            xCommand = new OleDbCommand("Insert into Tbl_Bill (Bill_Amount, Bill_Discount ,Final_Bill,Bill_Status, Bill_Date) values(" + iLblAmount + "," + iDisc + "," + iFinalBill + ",'unpayed','" + DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt") + "')", xConnection);
            xConnection.Open();
            xCommand.ExecuteNonQuery();
            xConnection.Close();

            xConnection.Open();
            xDataSet = new DataSet();
            xDataAdapter = new OleDbDataAdapter("Select * from Tbl_Bill", xConnection);
            xDataAdapter.Fill(xDataSet);
            BillRow = xDataSet.Tables[0].Rows.Count;
            xConnection.Close();

        }

        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (tbDiscount.Text == "")
                tbDiscount.Text = "0";

            Graphics g = e.Graphics;

            FontFamily fontFamily = new FontFamily("Courier New");
            Font font = new Font(
               fontFamily,
               10,
               FontStyle.Bold,
               GraphicsUnit.Pixel);

            FontFamily fontFamily2 = new FontFamily("Arial");
            Font fontHeads = new Font(
               fontFamily2,
               10.50F,
               FontStyle.Bold,
               GraphicsUnit.Pixel);
            //Font fontHeads = new Font("Arial Black", 10);


            int fontHeight = Convert.ToInt32(font.GetHeight());
            int fontHeadHeight = Convert.ToInt32(fontHeads.GetHeight());

            int startX = 0;
            int startY = 10;
            int offSet = 30;

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            Image y = Image.FromFile("main.jpg");
            Rectangle m = e.MarginBounds;

            m.Height = y.Height;

            m.Width = y.Width;

            e.Graphics.DrawImage(y, 0, 0, 305, 120);
            offSet = offSet + fontHeight + 77;

            g.DrawString("Kamran Chowrangi, Johar", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), e.PageBounds.Width / 2, startY + offSet, sf);
            offSet = offSet + fontHeadHeight + 7;

            string date = "Date Time:  " + DateTime.Now.ToString() + "";
            g.DrawString(date, new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
            offSet = offSet + fontHeadHeight + 5;

            string typ = "Order Type: ";
            if (rbTakeAway.Checked == true)
            {
                g.DrawString(typ + "Take Away", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 5;
            }
            else if (rbDelivery.Checked == true)
            {
                g.DrawString(typ + "Delivery", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 5;
                g.DrawString("Customer Details", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 5;
                g.DrawString(tbCustomerName.Text.PadRight(8), new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 5;
                g.DrawString(tbPhoneNo.Text.PadRight(8), new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 5;

                g.DrawString(tbAddress.Text, new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 5;
                if (tbAddress2.Text != "")
                {
                    g.DrawString(tbAddress2.Text, new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                    offSet = offSet + fontHeadHeight + 5;
                }
            }
            else
            {

                g.DrawString(typ + "DineIn", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 5;
                g.DrawString("Table #:    " + cbTable.Text.PadRight(8) + "Served By:  " + cbWaiter.Text, new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 5;
                // g.DrawString("Served By:"+cbWaiter.Text, new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                // offSet = offSet + fontHeadHeight + 5;
            }

            xConnection.Open();
            xDataSet = new DataSet();
            xDataAdapter = new OleDbDataAdapter("Select * from Tbl_Bill", xConnection);
            xDataAdapter.Fill(xDataSet);
            string billNo = xDataSet.Tables[0].Rows.Count.ToString();
            xConnection.Close();
            g.DrawString("Reciept No: " + billNo + "", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
            offSet = offSet + fontHeadHeight + 5;

            g.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", fontHeads, new SolidBrush(Color.Black), 0, startY + offSet);
            offSet += 20;
            string n = "Name";
            string p = "Price";
            string q = "Qty";
            string t = "Amount";
            string d = "Discount";

            string appendFormat = "{0,-55} {1,2:N0}{2,8:N0}\n";
            var sb = new StringBuilder();
            sb.Append(String.Format(appendFormat, "Name", "Price", "Qty"));
            string i = sb.ToString();
            g.DrawString(i, fontHeads, new SolidBrush(Color.Black), startX, startY + offSet);
            offSet += 12;
            appendFormat = "{0,65} {1,18:N0}\n\n";
            sb = new StringBuilder();
            sb.Append(String.Format(appendFormat, "Discount", "Amount"));

            i = sb.ToString();
            g.DrawString(i, fontHeads, new SolidBrush(Color.Black), startX, startY + offSet);
            offSet += 12;
            g.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", fontHeads, new SolidBrush(Color.Black), 0, startY + offSet);
            offSet += (fontHeadHeight + 7);


            for (int j = 0; j < DGV1.RowCount - 1; j++)
            {

                n = DGV1.Rows[j].Cells[1].Value.ToString();//product name
                p = DGV1.Rows[j].Cells[2].Value.ToString();//
                q = DGV1.Rows[j].Cells[3].Value.ToString();
                t = DGV1.Rows[j].Cells[4].Value.ToString();
                d = DGV1.Rows[j].Cells[5].Value.ToString() + " %";
                sb = new StringBuilder();
                sb.Append(String.Format("{0,-28}{1,5:N0}{2,4:N0}\n\n", n, p, q));

                i = sb.ToString();
                g.DrawString(i, font, new SolidBrush(Color.Black), startX, startY + offSet + 3);
                offSet = offSet + fontHeight + 7;
                sb = new StringBuilder();
                sb.Append(String.Format("{0,32}{1,12:N0}\n\n", d, t));
                i = "".ToString();
                i = sb.ToString();
                g.DrawString(i, font, new SolidBrush(Color.Black), startX, startY + offSet + 3);
                offSet = offSet + fontHeight + 7;
            }

            g.DrawString("___________________________________________________________________________", fontHeads, new SolidBrush(Color.Black), 0, startY + offSet);
            offSet = offSet + fontHeadHeight + 5;


            string am = lbl_TotalAmounnt.Text;
            g.DrawString("Sub Total:".PadRight(37) + am + "", font, new SolidBrush(Color.Black), startX, startY + offSet);
            offSet = offSet + fontHeight + 5;
            am = tbDiscount.Text + " %";
            g.DrawString("Discount:".PadRight(37) + am + "", font, new SolidBrush(Color.Black), startX, startY + offSet);
            offSet = offSet + fontHeight + 5;
            am = lblFinalBillAmount.Text;
            g.DrawString("Total:".PadRight(37) + am + "", font, new SolidBrush(Color.Black), startX, startY + offSet);
            offSet = offSet + fontHeight + 4;
            if (rbDelivery.Checked == true)
            {
                g.DrawString("Delivery Charges:".PadRight(37) + tbCharges.Text + "", font, new SolidBrush(Color.Black), startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 5;
                double totalWithCharges = ((Convert.ToDouble(lblFinalBillAmount.Text)) + (Convert.ToDouble(tbCharges.Text)));
                g.DrawString("Total with Delivery Charges:".PadRight(37) + totalWithCharges + "", font, new SolidBrush(Color.Black), startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 5;
            }

            g.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", fontHeads, new SolidBrush(Color.Black), 0, startY + offSet);
            offSet = offSet + fontHeadHeight + 7;

            g.DrawString("THANK YOU", new Font("Arial Black", 8), new SolidBrush(Color.Black), e.PageBounds.Width / 2, startY + offSet, sf);
            offSet = offSet + fontHeight + 5;
            string s = "";
            s = "GEEKS OF INDUS";
            string w = "Powered BY:";
            g.DrawString(w, new Font("Courier", 7), new SolidBrush(Color.Black), e.PageBounds.Width / 2, startY + offSet, sf);
            offSet = offSet + fontHeight + 5;

            g.DrawString(s, new Font("Courier", 7, FontStyle.Bold), new SolidBrush(Color.Black), e.PageBounds.Width / 2, startY + offSet, sf);
            offSet = offSet + fontHeight + 5;

            g.DrawString("geeksofindus@gmail.com", new Font("Courier", 7, FontStyle.Underline), new SolidBrush(Color.Black), e.PageBounds.Width / 2, startY + offSet, sf);
            offSet = offSet + fontHeight + 5;
            // g.DrawString("03203711012", new Font("Courier", 7, FontStyle.Underline), new SolidBrush(Color.Black), e.PageBounds.Width / 2, startY + offSet, sf);
            // offSet = offSet + fontHeight + 5;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure to Close This POS?", ":: POS::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void rbDineIn_CheckedChanged(object sender, EventArgs e)
        {

            if (rbDineIn.Checked == true)
            {
                cbTable.SelectedIndex = 6;
                cbTable.Text = "";
                cbWaiter.Text = "";
                cbTable.Visible = true;
                lblWaiter.Visible = true;
                cbWaiter.Visible = true;
                //  cbTable.Enabled = true;
                //    cbWaiter.Enabled = true;
                lblCharges.Visible = false;
                tbCharges.Visible = false;
                lblName.Visible = false;
                tbCustomerName.Visible = false;
                lblPhoneNo.Visible = false;
                tbPhoneNo.Visible = false;
                lblAddress.Visible = false;
                tbAddress.Visible = false;
                tbAddress2.Visible = false;
                this.Text = rbDineIn.Text;
            }

        }

        private void rbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeAway.Checked == true)
            {
                this.Text = rbTakeAway.Text;

                // cbTable.Enabled = false;
                //  cbTable.Text = "";
                //  cbWaiter.Enabled = false;
                // cbWaiter.Text = "";
                // tbCharges.Enabled = false;
                //  tbCharges.Text = "";
                lblWaiter.Visible = false;
                cbWaiter.Visible = false;
                cbTable.Visible = false;
                lblCharges.Visible = false;
                tbCharges.Visible = false;
                lblName.Visible = false;
                tbCustomerName.Visible = false;
                lblPhoneNo.Visible = false;
                tbPhoneNo.Visible = false;
                lblAddress.Visible = false;
                tbAddress.Visible = false;
                tbAddress2.Visible = false;
            }

        }

        private void tbQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbName.Text != "")
            {
                char s = Convert.ToChar(e.KeyData);
                int i = Convert.ToInt32(s);
                e.Handled = !char.IsNumber(s) || !char.IsControl(s) || (s != '.') || (e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Enter);

                if (e.Handled == true)
                {

                    if ((e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Back)
                    {
                        if (!tbQty.Text.Equals(""))
                        {
                            int iPrice = Int32.Parse(tbPrice.Text);
                            int iQty = Int32.Parse(tbQty.Text);
                            int iTotal = iPrice * iQty;
                            tbAmount.Text = iTotal.ToString();
                        }
                        else if (tbQty.Text.Equals(""))
                        {
                            tbAmount.Text = "0";
                        }

                    }


                    else
                    {
                        MessageBox.Show(":: Error Occured :: \n" + "Enter Number", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (tbQty.Text.Equals(""))
                    {
                        tbAmount.Text = "0";
                    }

                    else
                    {
                        int iPrice = Int32.Parse(tbPrice.Text);
                        int iQty = Int32.Parse(tbQty.Text);
                        int iTotal = iPrice * iQty;
                        tbAmount.Text = iTotal.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show(":: Error Occured :: \n" + "Select Item First", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tbDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            char s = Convert.ToChar(e.KeyData);
            int i = Convert.ToInt32(s);
            e.Handled = !char.IsNumber(s) || !char.IsControl(s) || (s != '.');
            if ((lbl_TotalAmounnt.Text != "" || lbl_TotalAmounnt.Text != "0") && (e.KeyCode != Keys.Decimal))
            {

                // e.Handled = !char.IsNumber(s) && !char.IsControl(s);
                float iFinalBill = 0.00F;
                lblFinalBillAmount.Text = lbl_TotalAmounnt.Text;
                if (e.KeyCode == Keys.Back)
                {
                    if (tbDiscount.Text == "" || tbDiscount.Text == "0")
                    {
                        lblFinalBillAmount.Text = lbl_TotalAmounnt.Text;
                    }
                    else
                    {
                        int total = Int32.Parse(lblFinalBillAmount.Text);
                        float iDiscount = Int32.Parse(tbDiscount.Text);
                        iDiscount = (iDiscount / 100);
                        iFinalBill = (float)total - (total * (iDiscount));
                        lblFinalBillAmount.Text = iFinalBill.ToString();
                    }
                }
                else if (e.Handled == true)
                {

                    if ((e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
                    {
                        int total = Int32.Parse(lblFinalBillAmount.Text);
                        float iDiscount = Int32.Parse(tbDiscount.Text);
                        iDiscount = (iDiscount / 100);
                        iFinalBill = (float)total - (total * (iDiscount));
                        lblFinalBillAmount.Text = iFinalBill.ToString();
                    }
                    else
                    {
                        MessageBox.Show(":: Error Occured :: \n" + "Enter Number", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbDiscount.Text = "";
                    }
                }
                /*    else
                    {


                        if (tbDiscount.Text!=("") || tbDiscount.Text!=("0"))
                        {
                            int total = Int32.Parse(lblFinalBillAmount.Text);
                            float iDiscount = Int32.Parse(tbDiscount.Text);
                            iDiscount = (iDiscount / 100);
                            iFinalBill = (float)total - (total * (iDiscount));
                            lblFinalBillAmount.Text = iFinalBill.ToString();
                        }
                    }*/

            }
            else
            {
                MessageBox.Show(":: Error Occured :: \n" + "No Amount is present for show discount", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDiscount.Text = "";
            }
        }


        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sItem = DGV1.CurrentRow.Cells[1].Value.ToString();
            DialogResult DR = MessageBox.Show("Are you sure to Update " + sItem + "?", ":: POS::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                tbID.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
                tbName.Text = DGV1.CurrentRow.Cells[1].Value.ToString();
                tbPrice.Text = DGV1.CurrentRow.Cells[2].Value.ToString();
                tbQty.Text = DGV1.CurrentRow.Cells[3].Value.ToString();
                tbAmount.Text = DGV1.CurrentRow.Cells[4].Value.ToString();
                btnAddItemInOrder.Visible = false;
            }
            else
            {
                btnAddItemInOrder.Visible = true;
            }


        }

        private void DGV2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = DGV2.CurrentRow.Cells[0].Value.ToString();
            tbName.Text = DGV2.CurrentRow.Cells[1].Value.ToString();
            tbPrice.Text = DGV2.CurrentRow.Cells[2].Value.ToString();
            tbQty.Text = "1";
            tbAmount.Text = tbPrice.Text;
        }



        private void cbWaiter_SelectedValueChanged(object sender, EventArgs e)
        {
            cbWaiter.Enabled = false;
        }




        private void cbWaiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbWaiter.Enabled = false;
            cbWaiter.Text = "";
        }



        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbSearch.Text != "")
            {
                try
                {
                    xConnection.Open();
                    xDataSet = new DataSet();
                    xDataAdapter = new OleDbDataAdapter("Select * from Tbl_FoodItems where Name_FoodItems like'%" + tbSearch.Text + "%'", xConnection);
                    xDataAdapter.Fill(xDataSet);
                    DGV2.DataSource = xDataSet.Tables[0];
                    xConnection.Close();
                    DGV2.Columns[0].Width = 40;
                    DGV2.Columns[1].Width = 150;
                    DGV2.Columns[2].Width = 70;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(":: Following Error Occured :: \n" + ex.Message.ToString(), ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                RefreshGridFoodItems();
            }

        }


        private void rbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDelivery.Checked == true)
            {
                //  tbName.SelectNextControl();
                cbTable.Visible = false;
                lblWaiter.Visible = false;
                cbWaiter.Visible = false;
                // cbTable.Enabled = false;
                //  cbWaiter.Enabled = false;
                lblCharges.Visible = true;
                tbCharges.Visible = true;
                tbCharges.Text = "";
                lblName.Visible = true;
                tbCustomerName.Visible = true;
                tbCustomerName.Text = "";
                lblPhoneNo.Visible = true;
                tbPhoneNo.Visible = true;
                tbPhoneNo.Text = "";
                lblAddress.Visible = true;
                tbAddress.Visible = true;
                tbAddress.Text = "";
                tbAddress2.Visible = true;
                tbAddress2.Text = "";
                //tbCharges.Enabled = true;
                this.Text = rbDelivery.Text;
            }

        }



        private void tbCash_KeyUp(object sender, KeyEventArgs e)
        {
            char s = Convert.ToChar(e.KeyData);
            int i = Convert.ToInt32(s);
            e.Handled = !char.IsNumber(s) || !char.IsControl(s) || (s != '.');

            if ((lblFinalBillAmount.Text != "" || lblFinalBillAmount.Text != "0") && (e.KeyCode != Keys.Decimal))
            {

                // e.Handled = !char.IsNumber(s) && !char.IsControl(s);
                double iReturnAmount = 0.00F;
                lblReturnAmount.Text = "0";
                if (e.KeyCode == Keys.Back)
                {
                    if (tbCash.Text == "" || tbCash.Text == "0")
                    {
                        lblReturnAmount.Text = "0";
                    }
                    else
                    {
                        double total = Convert.ToDouble(lblFinalBillAmount.Text);
                        double iCash = Convert.ToDouble(tbCash.Text);
                        iReturnAmount = (iCash - total);
                        //iReturnAmount = (float)total - (total * (iDiscount));
                        lblReturnAmount.Text = iReturnAmount.ToString();
                    }
                }
                else if (e.Handled == true)
                {

                    if ((e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
                    {
                        double total = Convert.ToDouble(lblFinalBillAmount.Text);
                        double iCash = Convert.ToDouble(tbCash.Text);
                        iReturnAmount = (iCash - total);
                        //iReturnAmount = (float)total - (total * (iDiscount));
                        lblReturnAmount.Text = iReturnAmount.ToString();
                    }
                    else
                    {
                        MessageBox.Show(":: Error Occured :: \n" + "Enter Number", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbCash.Text = "";
                    }
                }
                /*    else
                    {


                        if (tbDiscount.Text!=("") || tbDiscount.Text!=("0"))
                        {
                            int total = Int32.Parse(lblFinalBillAmount.Text);
                            float iDiscount = Int32.Parse(tbDiscount.Text);
                            iDiscount = (iDiscount / 100);
                            iFinalBill = (float)total - (total * (iDiscount));
                            lblFinalBillAmount.Text = iFinalBill.ToString();
                        }
                    }*/

            }
            else
            {
                MessageBox.Show(":: Error Occured :: \n" + "No Amount is present for show discount", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCash.Text = "";
            }
        }

        private void btnBillPayed_Click(object sender, EventArgs e)
        {
            double iLblAmount = Convert.ToDouble(lbl_TotalAmounnt.Text.ToString());
            double iFinalBill = Convert.ToDouble(lblFinalBillAmount.Text.ToString());
            int iDisc;
            if (tbDiscount.Text.ToString().Equals("")) { iDisc = 0; } else { iDisc = Int32.Parse(tbDiscount.Text.ToString()); }
            //string status = "Payed";
            int id = BillRow;
            xCommand = new OleDbCommand("Update Tbl_Bill set [Bill_Amount]=" + iLblAmount + ", [Bill_Discount]=" + iDisc + " ,[Final_Bill]=" + iFinalBill + ",[Bill_Status]='payed', [Bill_Date]='" + DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt") + "' WHERE Bill_ID=" + id + "", xConnection);
            xConnection.Open();
            xCommand.ExecuteNonQuery();
            xConnection.Close();

            DialogResult DR = MessageBox.Show("Bill Save Successfully", ":: POS ::", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Dispose();
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = cbTable.Text;
        }

        private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {
            this.Text = tbCustomerName.Text;
        }



        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void btnPrintToken_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog pre = new PrintPreviewDialog();
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            PaperSize psize = new PaperSize("Custom", 75, 200);
            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;
            pdoc.DefaultPageSettings.PaperSize.Width = 300;
            pdoc.PrintPage += new PrintPageEventHandler(pdoc_Token1);
            pre.Document = pdoc;
            pre.ShowDialog();

        }
        void pdoc_Token1(object sender, PrintPageEventArgs e)
        {
            if (DGV1.SelectedRows.Count > 0)
            {

                Graphics g = e.Graphics;

                FontFamily fontFamily = new FontFamily("Courier New");
                Font font = new Font(
                   fontFamily,
                   10,
                   FontStyle.Bold,
                   GraphicsUnit.Pixel);

                FontFamily fontFamily2 = new FontFamily("Arial");
                Font fontHeads = new Font(
                   fontFamily2,
                   10.50F,
                   FontStyle.Bold,
                   GraphicsUnit.Pixel);
                //Font fontHeads = new Font("Arial Black", 10);


                int fontHeight = Convert.ToInt32(font.GetHeight());
                int fontHeadHeight = Convert.ToInt32(fontHeads.GetHeight());

                int startX = 0;
                int startY = 10;
                int offSet = 30;

                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;



                g.DrawString("Token", new Font("Courier New", 22, FontStyle.Bold), new SolidBrush(Color.Black), e.PageBounds.Width / 2, startY + offSet, sf);
                offSet = offSet + fontHeadHeight + 7;

                string date = "Date Time:  " + DateTime.Now.ToString() + "";
                g.DrawString(date, new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                offSet = offSet + fontHeadHeight + 5;

                g.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", fontHeads, new SolidBrush(Color.Black), 0, startY + offSet);
                offSet += (fontHeadHeight + 7);

                int i = DGV1.SelectedRows.Count;

                int j = orderTable.Rows.Count - 1;

                if (DGV1.SelectedRows.Count == DGV1.RowCount)
                {
                    for (i = 1; i < (DGV1.SelectedRows.Count); i++)
                    {
                        string n = DGV1.SelectedRows[i].Cells[1].Value.ToString();//product name
                        g.DrawString("Name:  " + n, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                        offSet = offSet + fontHeadHeight + 7;
                        n = DGV1.SelectedRows[i].Cells[3].Value.ToString();
                        g.DrawString("Quantity:  " + n, new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                        offSet = offSet + fontHeadHeight + 7;
                    }
                }
                else
                {
                    for (i = 0; i < DGV1.SelectedRows.Count; i++)
                    {
                        string n = DGV1.SelectedRows[i].Cells[1].Value.ToString();//product name
                        g.DrawString("Name:  " + n, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                        offSet = offSet + fontHeadHeight + 7;
                        n = DGV1.SelectedRows[i].Cells[3].Value.ToString();
                        g.DrawString("Quantity:  " + n, new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offSet);
                        offSet = offSet + fontHeadHeight + 7;
                    }
                }


                g.DrawString("___________________________________________________________________________", fontHeads, new SolidBrush(Color.Black), 0, startY + offSet);
                offSet = offSet + fontHeadHeight + 5;


            }
            //else { 

            //}
        }

        private void cbMenuSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                xConnection.Open();
                xDataSet = new DataSet();
                if (cbMenuSelection.Text == "All")
                {
                    xDataAdapter = new OleDbDataAdapter("Select * from Tbl_FoodItems ", xConnection);
                }
                else
                {
                    xDataAdapter = new OleDbDataAdapter("Select * from Tbl_FoodItems where Category_FoodItems like'%" + cbMenuSelection.Text + "%'", xConnection);
                }
                xDataAdapter.Fill(xDataSet);
                DGV2.DataSource = xDataSet.Tables[0];
                xConnection.Close();
                DGV2.Columns[0].Width = 40;
                DGV2.Columns[1].Width = 150;
                DGV2.Columns[2].Width = 70;
            }
            catch (Exception ex)
            {
                MessageBox.Show(":: Following Error Occured :: \n" + ex.Message.ToString(), ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {

        }

         private void btnSetDiscMulitiple_Click(object sender, EventArgs e)
        {
            if (DGV1.SelectedRows.Count > 0 && tbDiscMultiple.Text != "")
            {
                if (DGV1.SelectedRows.Count == DGV1.RowCount)
                {
                    for (int i = 1; i < DGV1.SelectedRows.Count; i++)
                    {
                        double n = Convert.ToDouble(DGV1.SelectedRows[i].Cells[2].Value) * Convert.ToDouble(DGV1.SelectedRows[i].Cells[3].Value);//price*qty
                        double d = Int32.Parse(tbDiscMultiple.Text);
                        d = d / 100;
                        n = n - (n * d);
                        string a = n.ToString();
                        DGV1.SelectedRows[i].Cells[4].Value = a;
                        d *= 100;
                        a = d.ToString();
                        DGV1.SelectedRows[i].Cells[5].Value = d;
                    }
                }
                else
                {
                    for (int i = 0; i < DGV1.SelectedRows.Count; i++)
                    {
                        double n = Convert.ToDouble(DGV1.SelectedRows[i].Cells[2].Value) * Convert.ToDouble(DGV1.SelectedRows[i].Cells[3].Value);//price*qty
                        double d = Int32.Parse(tbDiscMultiple.Text);
                        d = d / 100;
                        n = n - (n * d);
                        string a = n.ToString();
                        DGV1.SelectedRows[i].Cells[4].Value = a;
                        d *= 100;
                        a = d.ToString();
                        DGV1.SelectedRows[i].Cells[5].Value = d;
                    }
                }

            }
            double total = 0;
            int iFinalBill = 0;
            tbDiscMultiple.Text = "".ToString();
            for (int i = 0; i < orderTable.Rows.Count; i++)
            {

                double iAmount = Convert.ToDouble(orderTable.Rows[i][4].ToString());
                total += iAmount;
            }


            if (!(tbDiscount.Text.Equals("") || tbDiscount.Text.Equals("")))
            {
                int iDiscount = Int32.Parse(tbDiscount.Text);
                iDiscount /= 100;
                iFinalBill = (int)total * iDiscount;
            }
            else
            {
                iFinalBill = (int)total;
            }
            lblFinalBillAmount.Text = iFinalBill.ToString();
            lbl_TotalAmounnt.Text = total.ToString();
        }

        private void tbDiscMultiple_KeyUp(object sender, KeyEventArgs e)
        {
            if (DGV1.SelectedRows.Count > 0)
            {
                if (!((e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode == Keys.Back)))
                {
                    MessageBox.Show(":: Error Occured :: \n" + "Enter Number", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


            else
            {
                MessageBox.Show(":: Error Occured :: \n" + "Select Row First", ":: Error ::", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tbPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        












    } 
    }

/*private void FoodItems_Load(object sender, EventArgs e) {
            xConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\ChapShoroDB.mdb;Persist Security Info=False");
            RefreshGridFoodItems();
        }*/





/*              
 *              
 *             


*/