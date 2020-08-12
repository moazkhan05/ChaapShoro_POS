namespace WindowsFormsApplication2
{
    partial class UpdateItemDetails
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
            this.tbItemPrice_UID = new System.Windows.Forms.TextBox();
            this.lblItemPrice_UID = new System.Windows.Forms.Label();
            this.tbItemName_UID = new System.Windows.Forms.TextBox();
            this.lblItemName_UID = new System.Windows.Forms.Label();
            this.btnUpdate_UID = new System.Windows.Forms.Button();
            this.btnRemove_UID = new System.Windows.Forms.Button();
            this.btnExit_UID = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGVC0_ItemidUpdtae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVC1_nameItemUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVC3_priceItemUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbItemPrice_UID
            // 
            this.tbItemPrice_UID.Location = new System.Drawing.Point(124, 70);
            this.tbItemPrice_UID.Name = "tbItemPrice_UID";
            this.tbItemPrice_UID.Size = new System.Drawing.Size(172, 20);
            this.tbItemPrice_UID.TabIndex = 11;
            this.tbItemPrice_UID.TextChanged += new System.EventHandler(this.tbItemPrice_UID_TextChanged);
            // 
            // lblItemPrice_UID
            // 
            this.lblItemPrice_UID.AutoSize = true;
            this.lblItemPrice_UID.Location = new System.Drawing.Point(20, 73);
            this.lblItemPrice_UID.Name = "lblItemPrice_UID";
            this.lblItemPrice_UID.Size = new System.Drawing.Size(34, 13);
            this.lblItemPrice_UID.TabIndex = 10;
            this.lblItemPrice_UID.Text = "Price:";
            this.lblItemPrice_UID.Click += new System.EventHandler(this.lblItemPrice_UID_Click);
            // 
            // tbItemName_UID
            // 
            this.tbItemName_UID.Location = new System.Drawing.Point(124, 30);
            this.tbItemName_UID.Name = "tbItemName_UID";
            this.tbItemName_UID.Size = new System.Drawing.Size(172, 20);
            this.tbItemName_UID.TabIndex = 9;
            this.tbItemName_UID.TextChanged += new System.EventHandler(this.tbItemName_UID_TextChanged);
            // 
            // lblItemName_UID
            // 
            this.lblItemName_UID.AutoSize = true;
            this.lblItemName_UID.Location = new System.Drawing.Point(20, 33);
            this.lblItemName_UID.Name = "lblItemName_UID";
            this.lblItemName_UID.Size = new System.Drawing.Size(61, 13);
            this.lblItemName_UID.TabIndex = 8;
            this.lblItemName_UID.Text = "Item Name:";
            this.lblItemName_UID.Click += new System.EventHandler(this.lblItemName_UID_Click);
            // 
            // btnUpdate_UID
            // 
            this.btnUpdate_UID.Location = new System.Drawing.Point(23, 115);
            this.btnUpdate_UID.Name = "btnUpdate_UID";
            this.btnUpdate_UID.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate_UID.TabIndex = 12;
            this.btnUpdate_UID.Text = "Update";
            this.btnUpdate_UID.UseVisualStyleBackColor = true;
            this.btnUpdate_UID.Click += new System.EventHandler(this.btnUpdate_UID_Click);
            // 
            // btnRemove_UID
            // 
            this.btnRemove_UID.Location = new System.Drawing.Point(124, 115);
            this.btnRemove_UID.Name = "btnRemove_UID";
            this.btnRemove_UID.Size = new System.Drawing.Size(75, 23);
            this.btnRemove_UID.TabIndex = 13;
            this.btnRemove_UID.Text = "Remove";
            this.btnRemove_UID.UseVisualStyleBackColor = true;
            this.btnRemove_UID.Click += new System.EventHandler(this.btnRemove_UID_Click);
            // 
            // btnExit_UID
            // 
            this.btnExit_UID.Location = new System.Drawing.Point(221, 115);
            this.btnExit_UID.Name = "btnExit_UID";
            this.btnExit_UID.Size = new System.Drawing.Size(75, 23);
            this.btnExit_UID.TabIndex = 14;
            this.btnExit_UID.Text = "Exit";
            this.btnExit_UID.UseVisualStyleBackColor = true;
            this.btnExit_UID.Click += new System.EventHandler(this.btnExit_UID_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVC0_ItemidUpdtae,
            this.DGVC1_nameItemUpdate,
            this.DGVC3_priceItemUpdate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 150);
            this.dataGridView1.TabIndex = 15;
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
            // UpdateItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 421);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit_UID);
            this.Controls.Add(this.btnRemove_UID);
            this.Controls.Add(this.btnUpdate_UID);
            this.Controls.Add(this.tbItemPrice_UID);
            this.Controls.Add(this.lblItemPrice_UID);
            this.Controls.Add(this.tbItemName_UID);
            this.Controls.Add(this.lblItemName_UID);
            this.Name = "UpdateItemDetails";
            this.Text = "UpdateItemDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbItemPrice_UID;
        private System.Windows.Forms.Label lblItemPrice_UID;
        private System.Windows.Forms.TextBox tbItemName_UID;
        private System.Windows.Forms.Label lblItemName_UID;
        private System.Windows.Forms.Button btnUpdate_UID;
        private System.Windows.Forms.Button btnRemove_UID;
        private System.Windows.Forms.Button btnExit_UID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVC0_ItemidUpdtae;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVC1_nameItemUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVC3_priceItemUpdate;
    }
}