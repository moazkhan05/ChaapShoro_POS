namespace WindowsFormsApplication2
{
    partial class AddItemDetails
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
            this.btnExit_AID = new System.Windows.Forms.Button();
            this.btnAdd_AID = new System.Windows.Forms.Button();
            this.tbItemPrice_AID = new System.Windows.Forms.TextBox();
            this.lblItemPrice_AID = new System.Windows.Forms.Label();
            this.tbItemName_AID = new System.Windows.Forms.TextBox();
            this.lblItemName_AID = new System.Windows.Forms.Label();
            this.tbItemID_AID = new System.Windows.Forms.TextBox();
            this.lblItemId_AID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGVC0_ItemidUpdtae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVC1_nameItemUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVC3_priceItemUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit_AID
            // 
            this.btnExit_AID.Location = new System.Drawing.Point(185, 153);
            this.btnExit_AID.Name = "btnExit_AID";
            this.btnExit_AID.Size = new System.Drawing.Size(75, 23);
            this.btnExit_AID.TabIndex = 23;
            this.btnExit_AID.Text = "Exit";
            this.btnExit_AID.UseVisualStyleBackColor = true;
            // 
            // btnAdd_AID
            // 
            this.btnAdd_AID.Location = new System.Drawing.Point(24, 153);
            this.btnAdd_AID.Name = "btnAdd_AID";
            this.btnAdd_AID.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_AID.TabIndex = 21;
            this.btnAdd_AID.Text = "Add Item";
            this.btnAdd_AID.UseVisualStyleBackColor = true;
            // 
            // tbItemPrice_AID
            // 
            this.tbItemPrice_AID.Location = new System.Drawing.Point(88, 108);
            this.tbItemPrice_AID.Name = "tbItemPrice_AID";
            this.tbItemPrice_AID.Size = new System.Drawing.Size(172, 20);
            this.tbItemPrice_AID.TabIndex = 20;
            // 
            // lblItemPrice_AID
            // 
            this.lblItemPrice_AID.AutoSize = true;
            this.lblItemPrice_AID.Location = new System.Drawing.Point(21, 111);
            this.lblItemPrice_AID.Name = "lblItemPrice_AID";
            this.lblItemPrice_AID.Size = new System.Drawing.Size(34, 13);
            this.lblItemPrice_AID.TabIndex = 19;
            this.lblItemPrice_AID.Text = "Price:";
            // 
            // tbItemName_AID
            // 
            this.tbItemName_AID.Location = new System.Drawing.Point(88, 68);
            this.tbItemName_AID.Name = "tbItemName_AID";
            this.tbItemName_AID.Size = new System.Drawing.Size(172, 20);
            this.tbItemName_AID.TabIndex = 18;
            // 
            // lblItemName_AID
            // 
            this.lblItemName_AID.AutoSize = true;
            this.lblItemName_AID.Location = new System.Drawing.Point(21, 71);
            this.lblItemName_AID.Name = "lblItemName_AID";
            this.lblItemName_AID.Size = new System.Drawing.Size(61, 13);
            this.lblItemName_AID.TabIndex = 17;
            this.lblItemName_AID.Text = "Item Name:";
            // 
            // tbItemID_AID
            // 
            this.tbItemID_AID.Location = new System.Drawing.Point(88, 25);
            this.tbItemID_AID.Name = "tbItemID_AID";
            this.tbItemID_AID.Size = new System.Drawing.Size(126, 20);
            this.tbItemID_AID.TabIndex = 16;
            // 
            // lblItemId_AID
            // 
            this.lblItemId_AID.AutoSize = true;
            this.lblItemId_AID.Location = new System.Drawing.Point(21, 29);
            this.lblItemId_AID.Name = "lblItemId_AID";
            this.lblItemId_AID.Size = new System.Drawing.Size(42, 13);
            this.lblItemId_AID.TabIndex = 15;
            this.lblItemId_AID.Text = "Item Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVC0_ItemidUpdtae,
            this.DGVC1_nameItemUpdate,
            this.DGVC3_priceItemUpdate});
            this.dataGridView1.Location = new System.Drawing.Point(23, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 188);
            this.dataGridView1.TabIndex = 24;
            // 
            // DGVC0_ItemidUpdtae
            // 
            this.DGVC0_ItemidUpdtae.HeaderText = "Item_Id";
            this.DGVC0_ItemidUpdtae.Name = "DGVC0_ItemidUpdtae";
            // 
            // DGVC1_nameItemUpdate
            // 
            this.DGVC1_nameItemUpdate.HeaderText = "Item_Name";
            this.DGVC1_nameItemUpdate.Name = "DGVC1_nameItemUpdate";
            // 
            // DGVC3_priceItemUpdate
            // 
            this.DGVC3_priceItemUpdate.HeaderText = "Item_Price";
            this.DGVC3_priceItemUpdate.Name = "DGVC3_priceItemUpdate";
            // 
            // AddItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 439);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit_AID);
            this.Controls.Add(this.btnAdd_AID);
            this.Controls.Add(this.tbItemPrice_AID);
            this.Controls.Add(this.lblItemPrice_AID);
            this.Controls.Add(this.tbItemName_AID);
            this.Controls.Add(this.lblItemName_AID);
            this.Controls.Add(this.tbItemID_AID);
            this.Controls.Add(this.lblItemId_AID);
            this.Name = "AddItemDetails";
            this.Text = "AddItemDetails";
            this.Load += new System.EventHandler(this.AddItemDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit_AID;
        private System.Windows.Forms.Button btnAdd_AID;
        private System.Windows.Forms.TextBox tbItemPrice_AID;
        private System.Windows.Forms.Label lblItemPrice_AID;
        private System.Windows.Forms.TextBox tbItemName_AID;
        private System.Windows.Forms.Label lblItemName_AID;
        private System.Windows.Forms.TextBox tbItemID_AID;
        private System.Windows.Forms.Label lblItemId_AID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVC0_ItemidUpdtae;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVC1_nameItemUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVC3_priceItemUpdate;
    }
}