namespace PHMS
{
    partial class frmPurchaseReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewPurchaseReturn = new System.Windows.Forms.DataGridView();
            this.label40 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.ddCategory = new System.Windows.Forms.ComboBox();
            this.ddCompany = new System.Windows.Forms.ComboBox();
            this.ddItems = new System.Windows.Forms.ComboBox();
            this.ddSupplier = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(470, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 32);
            this.label13.TabIndex = 125;
            this.label13.Text = "Purchase Return";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtVoucherNo);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.label55);
            this.panel1.Controls.Add(this.EndDate);
            this.panel1.Controls.Add(this.StartDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.ddCategory);
            this.panel1.Controls.Add(this.ddCompany);
            this.panel1.Controls.Add(this.ddItems);
            this.panel1.Controls.Add(this.ddSupplier);
            this.panel1.Controls.Add(this.dataGridViewPurchaseReturn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 635);
            this.panel1.TabIndex = 129;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(10, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 44);
            this.panel2.TabIndex = 141;
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
            this.btnClose.Location = new System.Drawing.Point(1193, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 41);
            this.btnClose.TabIndex = 140;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // dataGridViewPurchaseReturn
            // 
            this.dataGridViewPurchaseReturn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPurchaseReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPurchaseReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchaseReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.Column2,
            this.Column1,
            this.dataGridViewTextBoxColumn10,
            this.Column3,
            this.Column4,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewButtonColumn4,
            this.Column10});
            this.dataGridViewPurchaseReturn.Location = new System.Drawing.Point(11, 118);
            this.dataGridViewPurchaseReturn.Name = "dataGridViewPurchaseReturn";
            this.dataGridViewPurchaseReturn.Size = new System.Drawing.Size(1234, 504);
            this.dataGridViewPurchaseReturn.TabIndex = 142;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(170, 56);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(72, 21);
            this.label40.TabIndex = 159;
            this.label40.Text = "End Date";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(11, 56);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(78, 21);
            this.label55.TabIndex = 158;
            this.label55.Text = "Start Date";
            // 
            // EndDate
            // 
            this.EndDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.CustomFormat = "dd/MM/yyyy";
            this.EndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDate.Location = new System.Drawing.Point(145, 82);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(128, 29);
            this.EndDate.TabIndex = 157;
            // 
            // StartDate
            // 
            this.StartDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.CustomFormat = "dd/MM/yyyy";
            this.StartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDate.Location = new System.Drawing.Point(15, 82);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(124, 29);
            this.StartDate.TabIndex = 156;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(824, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 21);
            this.label17.TabIndex = 152;
            this.label17.Text = "Select Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(458, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 153;
            this.label6.Text = "Select Items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(641, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 154;
            this.label1.Text = "Select Company";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(275, 55);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(107, 21);
            this.label33.TabIndex = 155;
            this.label33.Text = "Select Supplier";
            // 
            // ddCategory
            // 
            this.ddCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ddCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.ddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddCategory.FormattingEnabled = true;
            this.ddCategory.Location = new System.Drawing.Point(828, 82);
            this.ddCategory.Name = "ddCategory";
            this.ddCategory.Size = new System.Drawing.Size(177, 29);
            this.ddCategory.TabIndex = 148;
            // 
            // ddCompany
            // 
            this.ddCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ddCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.ddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddCompany.FormattingEnabled = true;
            this.ddCompany.Location = new System.Drawing.Point(645, 82);
            this.ddCompany.Name = "ddCompany";
            this.ddCompany.Size = new System.Drawing.Size(177, 29);
            this.ddCompany.TabIndex = 149;
            // 
            // ddItems
            // 
            this.ddItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ddItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.ddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddItems.FormattingEnabled = true;
            this.ddItems.Location = new System.Drawing.Point(462, 83);
            this.ddItems.Name = "ddItems";
            this.ddItems.Size = new System.Drawing.Size(177, 29);
            this.ddItems.TabIndex = 150;
            // 
            // ddSupplier
            // 
            this.ddSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ddSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.ddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddSupplier.FormattingEnabled = true;
            this.ddSupplier.Location = new System.Drawing.Point(279, 82);
            this.ddSupplier.Name = "ddSupplier";
            this.ddSupplier.Size = new System.Drawing.Size(177, 29);
            this.ddSupplier.TabIndex = 151;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1091, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 29);
            this.btnSearch.TabIndex = 161;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::PHMS.Properties.Resources.print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1167, 82);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(78, 28);
            this.btnPrint.TabIndex = 160;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Voc No";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Supplier Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn10.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Company";
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.HeaderText = "Rate";
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Sub Total Amount";
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherNo.Location = new System.Drawing.Point(1011, 80);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(74, 29);
            this.txtVoucherNo.TabIndex = 162;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1007, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 152;
            this.label2.Text = "Voucher No ";
            // 
            // frmPurchaseReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 635);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewPurchaseReturn;
        private System.Windows.Forms.Button btnGetSalaryData;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Label label40;
        internal System.Windows.Forms.Label label55;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox ddCategory;
        private System.Windows.Forms.ComboBox ddCompany;
        private System.Windows.Forms.ComboBox ddItems;
        private System.Windows.Forms.ComboBox ddSupplier;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewButtonColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txtVoucherNo;
        internal System.Windows.Forms.Label label2;
    }
}