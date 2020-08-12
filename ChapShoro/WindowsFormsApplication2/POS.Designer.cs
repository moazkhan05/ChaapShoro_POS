namespace WindowsFormsApplication2
{
    partial class POS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFinalBillAmount = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.lbl_TotalAmounnt = new System.Windows.Forms.Label();
            this.lblFinalBill = new System.Windows.Forms.Label();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblIDitem = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddItemInOrder = new System.Windows.Forms.Button();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.rbTakeAway = new System.Windows.Forms.RadioButton();
            this.rbDineIn = new System.Windows.Forms.RadioButton();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.cbWaiter = new System.Windows.Forms.TextBox();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.tbCharges = new System.Windows.Forms.TextBox();
            this.lblCharges = new System.Windows.Forms.Label();
            this.tbCash = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblReturnAmount = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.tbPhoneNo = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.btnBillPayed = new System.Windows.Forms.Button();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.btnPrintToken = new System.Windows.Forms.Button();
            this.cbMenuSelection = new System.Windows.Forms.ComboBox();
            this.pOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSetDiscMulitiple = new System.Windows.Forms.Button();
            this.tbDiscMultiple = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV2
            // 
            this.DGV2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Location = new System.Drawing.Point(12, 142);
            this.DGV2.Name = "DGV2";
            this.DGV2.ReadOnly = true;
            this.DGV2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV2.Size = new System.Drawing.Size(320, 266);
            this.DGV2.TabIndex = 18;
            this.DGV2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV2_CellDoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(777, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 71);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Close\r\nThis POS";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblFinalBillAmount
            // 
            this.lblFinalBillAmount.AutoSize = true;
            this.lblFinalBillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalBillAmount.Location = new System.Drawing.Point(802, 64);
            this.lblFinalBillAmount.Name = "lblFinalBillAmount";
            this.lblFinalBillAmount.Size = new System.Drawing.Size(18, 20);
            this.lblFinalBillAmount.TabIndex = 16;
            this.lblFinalBillAmount.Text = "0";
            this.lblFinalBillAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscount.Location = new System.Drawing.Point(802, 37);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(82, 22);
            this.tbDiscount.TabIndex = 9;
            this.tbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbDiscount_KeyUp);
            // 
            // lbl_TotalAmounnt
            // 
            this.lbl_TotalAmounnt.AutoSize = true;
            this.lbl_TotalAmounnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAmounnt.Location = new System.Drawing.Point(802, 10);
            this.lbl_TotalAmounnt.Name = "lbl_TotalAmounnt";
            this.lbl_TotalAmounnt.Size = new System.Drawing.Size(18, 20);
            this.lbl_TotalAmounnt.TabIndex = 15;
            this.lbl_TotalAmounnt.Text = "0";
            this.lbl_TotalAmounnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinalBill
            // 
            this.lblFinalBill.AutoSize = true;
            this.lblFinalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalBill.Location = new System.Drawing.Point(713, 64);
            this.lblFinalBill.Name = "lblFinalBill";
            this.lblFinalBill.Size = new System.Drawing.Size(67, 20);
            this.lblFinalBill.TabIndex = 14;
            this.lblFinalBill.Text = "Final Bill";
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGenerateBill.FlatAppearance.BorderSize = 0;
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateBill.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBill.Location = new System.Drawing.Point(777, 157);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(116, 71);
            this.btnGenerateBill.TabIndex = 24;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click_1);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(713, 38);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(72, 20);
            this.lblDiscount.TabIndex = 13;
            this.lblDiscount.Text = "Discount";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(713, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total ";
            // 
            // DGV1
            // 
            this.DGV1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(346, 139);
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.Size = new System.Drawing.Size(425, 237);
            this.DGV1.TabIndex = 23;
            this.DGV1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblIDitem);
            this.groupBox1.Controls.Add(this.btnDeleteItem);
            this.groupBox1.Controls.Add(this.tbAmount);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblItems);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tbQty);
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.btnAddItemInOrder);
            this.groupBox1.Location = new System.Drawing.Point(346, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 129);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(200, 42);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(48, 22);
            this.tbID.TabIndex = 34;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(65, 13);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(193, 22);
            this.tbName.TabIndex = 13;
            // 
            // lblIDitem
            // 
            this.lblIDitem.AutoSize = true;
            this.lblIDitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDitem.Location = new System.Drawing.Point(164, 44);
            this.lblIDitem.Name = "lblIDitem";
            this.lblIDitem.Size = new System.Drawing.Size(21, 16);
            this.lblIDitem.TabIndex = 33;
            this.lblIDitem.Text = "ID";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Red;
            this.btnDeleteItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteItem.Location = new System.Drawing.Point(291, 77);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(61, 41);
            this.btnDeleteItem.TabIndex = 31;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Enabled = false;
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(65, 96);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(74, 22);
            this.tbAmount.TabIndex = 11;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(6, 102);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 16);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(6, 16);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(40, 16);
            this.lblItems.TabIndex = 7;
            this.lblItems.Text = "Items";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(224, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(61, 41);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update Item";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQty.Location = new System.Drawing.Point(65, 69);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(74, 22);
            this.tbQty.TabIndex = 8;
            this.tbQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbQty_KeyUp);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(6, 72);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(56, 16);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Quantity";
            // 
            // tbPrice
            // 
            this.tbPrice.Enabled = false;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(65, 41);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(74, 22);
            this.tbPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(7, 44);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // btnAddItemInOrder
            // 
            this.btnAddItemInOrder.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddItemInOrder.FlatAppearance.BorderSize = 0;
            this.btnAddItemInOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItemInOrder.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemInOrder.Location = new System.Drawing.Point(157, 77);
            this.btnAddItemInOrder.Name = "btnAddItemInOrder";
            this.btnAddItemInOrder.Size = new System.Drawing.Size(61, 41);
            this.btnAddItemInOrder.TabIndex = 9;
            this.btnAddItemInOrder.Text = "Add Item";
            this.btnAddItemInOrder.UseVisualStyleBackColor = false;
            this.btnAddItemInOrder.Click += new System.EventHandler(this.btnAddItemInOrder_Click_1);
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "Custom"});
            this.cbTable.Location = new System.Drawing.Point(12, 27);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(88, 21);
            this.cbTable.TabIndex = 6;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // rbTakeAway
            // 
            this.rbTakeAway.AutoSize = true;
            this.rbTakeAway.Location = new System.Drawing.Point(146, 2);
            this.rbTakeAway.Name = "rbTakeAway";
            this.rbTakeAway.Size = new System.Drawing.Size(79, 17);
            this.rbTakeAway.TabIndex = 29;
            this.rbTakeAway.TabStop = true;
            this.rbTakeAway.Text = "Take Away";
            this.rbTakeAway.UseVisualStyleBackColor = true;
            this.rbTakeAway.CheckedChanged += new System.EventHandler(this.rbTakeAway_CheckedChanged);
            // 
            // rbDineIn
            // 
            this.rbDineIn.AutoSize = true;
            this.rbDineIn.Location = new System.Drawing.Point(12, 2);
            this.rbDineIn.Name = "rbDineIn";
            this.rbDineIn.Size = new System.Drawing.Size(59, 17);
            this.rbDineIn.TabIndex = 30;
            this.rbDineIn.TabStop = true;
            this.rbDineIn.Text = "Dine In";
            this.rbDineIn.UseVisualStyleBackColor = true;
            this.rbDineIn.CheckedChanged += new System.EventHandler(this.rbDineIn_CheckedChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 124);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(51, 16);
            this.lblSearch.TabIndex = 31;
            this.lblSearch.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(74, 117);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(151, 22);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Location = new System.Drawing.Point(117, 33);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(38, 13);
            this.lblWaiter.TabIndex = 33;
            this.lblWaiter.Text = "Waiter";
            // 
            // cbWaiter
            // 
            this.cbWaiter.Location = new System.Drawing.Point(161, 28);
            this.cbWaiter.Name = "cbWaiter";
            this.cbWaiter.Size = new System.Drawing.Size(83, 20);
            this.cbWaiter.TabIndex = 7;
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Location = new System.Drawing.Point(77, 2);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(63, 17);
            this.rbDelivery.TabIndex = 35;
            this.rbDelivery.TabStop = true;
            this.rbDelivery.Text = "Delivery";
            this.rbDelivery.UseVisualStyleBackColor = true;
            this.rbDelivery.CheckedChanged += new System.EventHandler(this.rbDelivery_CheckedChanged);
            // 
            // tbCharges
            // 
            this.tbCharges.Location = new System.Drawing.Point(74, 95);
            this.tbCharges.Name = "tbCharges";
            this.tbCharges.Size = new System.Drawing.Size(101, 20);
            this.tbCharges.TabIndex = 5;
            // 
            // lblCharges
            // 
            this.lblCharges.AutoSize = true;
            this.lblCharges.Location = new System.Drawing.Point(14, 98);
            this.lblCharges.Name = "lblCharges";
            this.lblCharges.Size = new System.Drawing.Size(46, 13);
            this.lblCharges.TabIndex = 37;
            this.lblCharges.Text = "Charges";
            // 
            // tbCash
            // 
            this.tbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCash.Location = new System.Drawing.Point(803, 89);
            this.tbCash.Name = "tbCash";
            this.tbCash.Size = new System.Drawing.Size(81, 22);
            this.tbCash.TabIndex = 10;
            this.tbCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCash.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCash_KeyUp);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(713, 89);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(46, 20);
            this.lblCash.TabIndex = 38;
            this.lblCash.Text = "Cash";
            // 
            // lblReturnAmount
            // 
            this.lblReturnAmount.AutoSize = true;
            this.lblReturnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnAmount.Location = new System.Drawing.Point(802, 118);
            this.lblReturnAmount.Name = "lblReturnAmount";
            this.lblReturnAmount.Size = new System.Drawing.Size(18, 20);
            this.lblReturnAmount.TabIndex = 41;
            this.lblReturnAmount.Text = "0";
            this.lblReturnAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(713, 118);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(58, 20);
            this.lblReturn.TabIndex = 40;
            this.lblReturn.Text = "Return";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 54);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 43;
            this.lblAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(74, 51);
            this.tbAddress.MaxLength = 32;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(258, 20);
            this.tbAddress.TabIndex = 3;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(181, 30);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(55, 13);
            this.lblPhoneNo.TabIndex = 45;
            this.lblPhoneNo.Text = "Phone No";
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.Location = new System.Drawing.Point(240, 27);
            this.tbPhoneNo.MaxLength = 11;
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(92, 20);
            this.tbPhoneNo.TabIndex = 2;
            this.tbPhoneNo.TextChanged += new System.EventHandler(this.tbPhoneNo_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "Name";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(74, 27);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(101, 20);
            this.tbCustomerName.TabIndex = 1;
            this.tbCustomerName.TextChanged += new System.EventHandler(this.tbCustomerName_TextChanged);
            // 
            // btnBillPayed
            // 
            this.btnBillPayed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBillPayed.FlatAppearance.BorderSize = 0;
            this.btnBillPayed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBillPayed.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillPayed.Location = new System.Drawing.Point(777, 247);
            this.btnBillPayed.Name = "btnBillPayed";
            this.btnBillPayed.Size = new System.Drawing.Size(116, 71);
            this.btnBillPayed.TabIndex = 48;
            this.btnBillPayed.Text = "Bill Payed";
            this.btnBillPayed.UseVisualStyleBackColor = false;
            this.btnBillPayed.Click += new System.EventHandler(this.btnBillPayed_Click);
            // 
            // tbAddress2
            // 
            this.tbAddress2.Location = new System.Drawing.Point(74, 73);
            this.tbAddress2.MaxLength = 32;
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(258, 20);
            this.tbAddress2.TabIndex = 4;
            // 
            // btnPrintToken
            // 
            this.btnPrintToken.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrintToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintToken.Location = new System.Drawing.Point(356, 382);
            this.btnPrintToken.Name = "btnPrintToken";
            this.btnPrintToken.Size = new System.Drawing.Size(67, 33);
            this.btnPrintToken.TabIndex = 49;
            this.btnPrintToken.Text = "Print Token";
            this.btnPrintToken.UseVisualStyleBackColor = true;
            this.btnPrintToken.Click += new System.EventHandler(this.btnPrintToken_Click);
            // 
            // cbMenuSelection
            // 
            this.cbMenuSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenuSelection.DropDownWidth = 90;
            this.cbMenuSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMenuSelection.FormattingEnabled = true;
            this.cbMenuSelection.Items.AddRange(new object[] {
            "All",
            "BBQ",
            "Chai",
            "Extras",
            "Karahi",
            "Special Items"});
            this.cbMenuSelection.Location = new System.Drawing.Point(231, 117);
            this.cbMenuSelection.Name = "cbMenuSelection";
            this.cbMenuSelection.Size = new System.Drawing.Size(101, 21);
            this.cbMenuSelection.Sorted = true;
            this.cbMenuSelection.TabIndex = 50;
            this.cbMenuSelection.SelectedIndexChanged += new System.EventHandler(this.cbMenuSelection_SelectedIndexChanged);
            // 
            // pOSBindingSource
            // 
            this.pOSBindingSource.DataSource = typeof(WindowsFormsApplication2.POS);
            // 
            // btnSetDiscMulitiple
            // 
            this.btnSetDiscMulitiple.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSetDiscMulitiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDiscMulitiple.Location = new System.Drawing.Point(695, 382);
            this.btnSetDiscMulitiple.Name = "btnSetDiscMulitiple";
            this.btnSetDiscMulitiple.Size = new System.Drawing.Size(56, 33);
            this.btnSetDiscMulitiple.TabIndex = 51;
            this.btnSetDiscMulitiple.Text = "Set Disc";
            this.btnSetDiscMulitiple.UseVisualStyleBackColor = true;
            this.btnSetDiscMulitiple.Click += new System.EventHandler(this.btnSetDiscMulitiple_Click);
            // 
            // tbDiscMultiple
            // 
            this.tbDiscMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscMultiple.Location = new System.Drawing.Point(626, 387);
            this.tbDiscMultiple.Name = "tbDiscMultiple";
            this.tbDiscMultiple.Size = new System.Drawing.Size(61, 22);
            this.tbDiscMultiple.TabIndex = 52;
            this.tbDiscMultiple.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbDiscMultiple_KeyUp);
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 416);
            this.Controls.Add(this.tbDiscMultiple);
            this.Controls.Add(this.btnSetDiscMulitiple);
            this.Controls.Add(this.cbMenuSelection);
            this.Controls.Add(this.btnPrintToken);
            this.Controls.Add(this.tbAddress2);
            this.Controls.Add(this.btnBillPayed);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.tbPhoneNo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lblReturnAmount);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.tbCash);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblCharges);
            this.Controls.Add(this.tbCharges);
            this.Controls.Add(this.rbDelivery);
            this.Controls.Add(this.cbWaiter);
            this.Controls.Add(this.lblWaiter);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.lblFinalBillAmount);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.rbDineIn);
            this.Controls.Add(this.lbl_TotalAmounnt);
            this.Controls.Add(this.rbTakeAway);
            this.Controls.Add(this.lblFinalBill);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV2);
            this.MaximizeBox = false;
            this.Name = "POS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "POS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.POS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFinalBillAmount;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label lbl_TotalAmounnt;
        private System.Windows.Forms.Label lblFinalBill;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Button btnAddItemInOrder;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.RadioButton rbTakeAway;
        private System.Windows.Forms.RadioButton rbDineIn;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.BindingSource pOSBindingSource;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblIDitem;
        private System.Windows.Forms.TextBox cbWaiter;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.TextBox tbCharges;
        private System.Windows.Forms.Label lblCharges;
        private System.Windows.Forms.TextBox tbCash;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblReturnAmount;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox tbPhoneNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Button btnBillPayed;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.Button btnPrintToken;
        private System.Windows.Forms.ComboBox cbMenuSelection;
        private System.Windows.Forms.Button btnSetDiscMulitiple;
        private System.Windows.Forms.TextBox tbDiscMultiple;
    }
}

