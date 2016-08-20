namespace PHMS
{
    partial class frmMasterEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RightOptions = new System.Windows.Forms.Timer(this.components);
            this.Options = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.masterTb = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.btnItemGetData = new System.Windows.Forms.Button();
            this.btnItemUpdate = new System.Windows.Forms.Button();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.btnItemSave = new System.Windows.Forms.Button();
            this.dataGridViewItemType = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinQty = new System.Windows.Forms.TextBox();
            this.txtPurPrice = new System.Windows.Forms.TextBox();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.masterTb.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemType)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(103, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(434, 259);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // masterTb
            // 
            this.masterTb.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.masterTb.Controls.Add(this.tabPage5);
            this.masterTb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.masterTb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterTb.Location = new System.Drawing.Point(7, 54);
            this.masterTb.Name = "masterTb";
            this.masterTb.SelectedIndex = 0;
            this.masterTb.Size = new System.Drawing.Size(1164, 531);
            this.masterTb.TabIndex = 168;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.btnNew);
            this.tabPage5.Controls.Add(this.txtItemID);
            this.tabPage5.Controls.Add(this.btnItemGetData);
            this.tabPage5.Controls.Add(this.btnItemUpdate);
            this.tabPage5.Controls.Add(this.btnItemDelete);
            this.tabPage5.Controls.Add(this.btnItemSave);
            this.tabPage5.Controls.Add(this.dataGridViewItemType);
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.ForeColor = System.Drawing.Color.Black;
            this.tabPage5.Location = new System.Drawing.Point(4, 37);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1156, 490);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Add Medicine";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(0, 438);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 34);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtItemID
            // 
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtItemID.Location = new System.Drawing.Point(284, 27);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(100, 18);
            this.txtItemID.TabIndex = 41;
            this.txtItemID.TabStop = false;
            // 
            // btnItemGetData
            // 
            this.btnItemGetData.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnItemGetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemGetData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemGetData.ForeColor = System.Drawing.Color.White;
            this.btnItemGetData.Location = new System.Drawing.Point(402, 438);
            this.btnItemGetData.Name = "btnItemGetData";
            this.btnItemGetData.Size = new System.Drawing.Size(101, 34);
            this.btnItemGetData.TabIndex = 3;
            this.btnItemGetData.Text = "Get Data";
            this.btnItemGetData.UseVisualStyleBackColor = false;
            this.btnItemGetData.Click += new System.EventHandler(this.btnItemGetData_Click);
            // 
            // btnItemUpdate
            // 
            this.btnItemUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnItemUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemUpdate.ForeColor = System.Drawing.Color.White;
            this.btnItemUpdate.Location = new System.Drawing.Point(295, 438);
            this.btnItemUpdate.Name = "btnItemUpdate";
            this.btnItemUpdate.Size = new System.Drawing.Size(101, 34);
            this.btnItemUpdate.TabIndex = 2;
            this.btnItemUpdate.Text = "Update";
            this.btnItemUpdate.UseVisualStyleBackColor = false;
            this.btnItemUpdate.Click += new System.EventHandler(this.btnItemUpdate_Click);
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnItemDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemDelete.ForeColor = System.Drawing.Color.White;
            this.btnItemDelete.Location = new System.Drawing.Point(188, 438);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(101, 34);
            this.btnItemDelete.TabIndex = 1;
            this.btnItemDelete.Text = "Delete";
            this.btnItemDelete.UseVisualStyleBackColor = false;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // btnItemSave
            // 
            this.btnItemSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnItemSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemSave.ForeColor = System.Drawing.Color.White;
            this.btnItemSave.Location = new System.Drawing.Point(81, 438);
            this.btnItemSave.Name = "btnItemSave";
            this.btnItemSave.Size = new System.Drawing.Size(101, 34);
            this.btnItemSave.TabIndex = 0;
            this.btnItemSave.Text = "Save";
            this.btnItemSave.UseVisualStyleBackColor = false;
            this.btnItemSave.Click += new System.EventHandler(this.btnItemSave_Click);
            // 
            // dataGridViewItemType
            // 
            this.dataGridViewItemType.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItemType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItemType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItemType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column3});
            this.dataGridViewItemType.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewItemType.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewItemType.Location = new System.Drawing.Point(509, 0);
            this.dataGridViewItemType.Name = "dataGridViewItemType";
            this.dataGridViewItemType.Size = new System.Drawing.Size(643, 487);
            this.dataGridViewItemType.TabIndex = 36;
            this.dataGridViewItemType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemType_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sale Price";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pur Price";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Min Qty";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Company Name";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Expiry Date";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edit";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtExpiryDate);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.txtMinQty);
            this.groupBox6.Controls.Add(this.txtPurPrice);
            this.groupBox6.Controls.Add(this.txtCompName);
            this.groupBox6.Controls.Add(this.txtSalePrice);
            this.groupBox6.Controls.Add(this.txtItemName);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox6.Location = new System.Drawing.Point(5, 51);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(507, 345);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Item Name Information";
            // 
            // dtExpiryDate
            // 
            this.dtExpiryDate.Location = new System.Drawing.Point(175, 292);
            this.dtExpiryDate.Name = "dtExpiryDate";
            this.dtExpiryDate.Size = new System.Drawing.Size(314, 29);
            this.dtExpiryDate.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chose Expiry Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter Minimum Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Purchase Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Sale Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Medicine Name";
            // 
            // txtMinQty
            // 
            this.txtMinQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinQty.Location = new System.Drawing.Point(175, 244);
            this.txtMinQty.Name = "txtMinQty";
            this.txtMinQty.Size = new System.Drawing.Size(314, 25);
            this.txtMinQty.TabIndex = 3;
            this.txtMinQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinQty_KeyPress);
            // 
            // txtPurPrice
            // 
            this.txtPurPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurPrice.Location = new System.Drawing.Point(175, 188);
            this.txtPurPrice.Name = "txtPurPrice";
            this.txtPurPrice.Size = new System.Drawing.Size(314, 25);
            this.txtPurPrice.TabIndex = 2;
            this.txtPurPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurPrice_KeyPress);
            // 
            // txtCompName
            // 
            this.txtCompName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompName.Location = new System.Drawing.Point(175, 90);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(314, 25);
            this.txtCompName.TabIndex = 1;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(175, 136);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(314, 25);
            this.txtSalePrice.TabIndex = 1;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(175, 43);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(314, 25);
            this.txtItemName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 601);
            this.panel1.TabIndex = 169;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 41);
            this.panel2.TabIndex = 187;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::PHMS.Properties.Resources.close_2;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(1127, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 41);
            this.btnClose.TabIndex = 141;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(371, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(310, 39);
            this.label18.TabIndex = 3;
            this.label18.Text = "Master Entry Form";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMasterEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 601);
            this.Controls.Add(this.masterTb);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmMasterEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.masterTb.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemType)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer RightOptions;
        private System.Windows.Forms.Timer Options;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox txtItemName;
        public System.Windows.Forms.TextBox txtSalePrice;
        public System.Windows.Forms.TextBox txtPurPrice;
        public System.Windows.Forms.TextBox txtMinQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridViewItemType;
        private System.Windows.Forms.Button btnItemSave;
        private System.Windows.Forms.Button btnItemDelete;
        private System.Windows.Forms.Button btnItemUpdate;
        private System.Windows.Forms.Button btnItemGetData;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl masterTb;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtExpiryDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}