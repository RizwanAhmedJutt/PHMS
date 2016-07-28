namespace PHMS
{
    partial class frmCashPayment
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
            this.btnMax = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.xTotal = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.txtVocNo2 = new System.Windows.Forms.TextBox();
            this.txtCashAcCode = new System.Windows.Forms.TextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dpVocDate = new System.Windows.Forms.DateTimePicker();
            this.txtVocNo = new System.Windows.Forms.TextBox();
            this.xPriHead = new System.Windows.Forms.TextBox();
            this.xSecHead = new System.Windows.Forms.TextBox();
            this.Flex = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.txtAcCode = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.comboAcTitle = new System.Windows.Forms.ComboBox();
            this.comboCashAc = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flex)).BeginInit();
            this.panel4.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(222, 7);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(34, 25);
            this.btnMax.TabIndex = 0;
            this.btnMax.Text = ">>";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(34, 7);
            this.btnPre.Margin = new System.Windows.Forms.Padding(0);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(28, 25);
            this.btnPre.TabIndex = 0;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Location = new System.Drawing.Point(2, 7);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(34, 25);
            this.BtnMin.TabIndex = 0;
            this.BtnMin.Text = "<<";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PHMS.Properties.Resources.Save_26;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(131, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(580, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::PHMS.Properties.Resources.del;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(430, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(196, 7);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 25);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // xTotal
            // 
            this.xTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xTotal.Location = new System.Drawing.Point(832, 19);
            this.xTotal.Name = "xTotal";
            this.xTotal.Size = new System.Drawing.Size(103, 24);
            this.xTotal.TabIndex = 19;
            this.xTotal.Text = "0";
            this.xTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.txtVocNo2);
            this.Panel2.Controls.Add(this.btnMax);
            this.Panel2.Controls.Add(this.btnPre);
            this.Panel2.Controls.Add(this.btnNext);
            this.Panel2.Controls.Add(this.BtnMin);
            this.Panel2.Location = new System.Drawing.Point(223, 69);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(256, 32);
            this.Panel2.TabIndex = 64;
            // 
            // txtVocNo2
            // 
            this.txtVocNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVocNo2.Location = new System.Drawing.Point(62, 8);
            this.txtVocNo2.MaxLength = 255;
            this.txtVocNo2.Name = "txtVocNo2";
            this.txtVocNo2.Size = new System.Drawing.Size(134, 24);
            this.txtVocNo2.TabIndex = 71;
            this.txtVocNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVocNo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtVocNo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVocNo2_KeyPress);
            // 
            // txtCashAcCode
            // 
            this.txtCashAcCode.AutoCompleteCustomSource.AddRange(new string[] {
            "Muhammad"});
            this.txtCashAcCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCashAcCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtCashAcCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCashAcCode.Location = new System.Drawing.Point(830, 101);
            this.txtCashAcCode.MaxLength = 250;
            this.txtCashAcCode.Name = "txtCashAcCode";
            this.txtCashAcCode.ReadOnly = true;
            this.txtCashAcCode.Size = new System.Drawing.Size(232, 25);
            this.txtCashAcCode.TabIndex = 61;
            this.txtCashAcCode.TabStop = false;
            this.txtCashAcCode.Text = "1";
            this.txtCashAcCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.btnUpdate);
            this.Panel3.Controls.Add(this.btnSave);
            this.Panel3.Controls.Add(this.btnClear);
            this.Panel3.Controls.Add(this.btnDelete);
            this.Panel3.Controls.Add(this.xTotal);
            this.Panel3.Location = new System.Drawing.Point(93, 536);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1019, 66);
            this.Panel3.TabIndex = 59;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::PHMS.Properties.Resources.Edit_26;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(280, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 36);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // dpVocDate
            // 
            this.dpVocDate.CustomFormat = "dd/MM/yyyy dddd hh:mm:ss tt";
            this.dpVocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpVocDate.Location = new System.Drawing.Point(230, 129);
            this.dpVocDate.Name = "dpVocDate";
            this.dpVocDate.Size = new System.Drawing.Size(248, 25);
            this.dpVocDate.TabIndex = 40;
            // 
            // txtVocNo
            // 
            this.txtVocNo.AutoCompleteCustomSource.AddRange(new string[] {
            "Muhammad"});
            this.txtVocNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVocNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtVocNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVocNo.Location = new System.Drawing.Point(231, 102);
            this.txtVocNo.MaxLength = 250;
            this.txtVocNo.Name = "txtVocNo";
            this.txtVocNo.ReadOnly = true;
            this.txtVocNo.Size = new System.Drawing.Size(248, 25);
            this.txtVocNo.TabIndex = 60;
            this.txtVocNo.TabStop = false;
            this.txtVocNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xPriHead
            // 
            this.xPriHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPriHead.Location = new System.Drawing.Point(93, 179);
            this.xPriHead.Name = "xPriHead";
            this.xPriHead.Size = new System.Drawing.Size(47, 24);
            this.xPriHead.TabIndex = 41;
            this.xPriHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xSecHead
            // 
            this.xSecHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xSecHead.Location = new System.Drawing.Point(139, 179);
            this.xSecHead.Name = "xSecHead";
            this.xSecHead.Size = new System.Drawing.Size(47, 24);
            this.xSecHead.TabIndex = 42;
            this.xSecHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Flex
            // 
            this.Flex.AllowUserToAddRows = false;
            this.Flex.AllowUserToDeleteRows = false;
            this.Flex.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Flex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Flex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Flex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Flex.DefaultCellStyle = dataGridViewCellStyle2;
            this.Flex.GridColor = System.Drawing.Color.LightGray;
            this.Flex.Location = new System.Drawing.Point(92, 207);
            this.Flex.Name = "Flex";
            this.Flex.Size = new System.Drawing.Size(1019, 315);
            this.Flex.TabIndex = 58;
            this.Flex.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Flex_CellContentClick);
            this.Flex.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Flex_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "A/C Code";
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "A/C Title";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 260;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Narration";
            this.Column3.Name = "Column3";
            this.Column3.Width = 400;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Amount";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Delete";
            this.Column5.Name = "Column5";
            this.Column5.Width = 75;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(906, 178);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(103, 24);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtNarration
            // 
            this.txtNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNarration.Location = new System.Drawing.Point(550, 179);
            this.txtNarration.MaxLength = 255;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(358, 24);
            this.txtNarration.TabIndex = 1;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNarration_KeyDown);
            // 
            // txtAcCode
            // 
            this.txtAcCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcCode.Location = new System.Drawing.Point(185, 179);
            this.txtAcCode.Name = "txtAcCode";
            this.txtAcCode.Size = new System.Drawing.Size(74, 24);
            this.txtAcCode.TabIndex = 43;
            this.txtAcCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(903, 156);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(65, 18);
            this.Label7.TabIndex = 54;
            this.Label7.Text = "Amount";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(561, 157);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 18);
            this.Label6.TabIndex = 52;
            this.Label6.Text = "Narration";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(264, 156);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(153, 18);
            this.Label5.TabIndex = 51;
            this.Label5.Text = "Account Reciveable";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(111, 157);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 18);
            this.Label2.TabIndex = 50;
            this.Label2.Text = "Account Code";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(111, 131);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(113, 18);
            this.Label3.TabIndex = 49;
            this.Label3.Text = "Voucher Date:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(660, 100);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(85, 18);
            this.Label8.TabIndex = 56;
            this.Label8.Text = "Cash A/C:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(111, 103);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 18);
            this.Label4.TabIndex = 55;
            this.Label4.Text = "Voucher #:";
            // 
            // comboAcTitle
            // 
            this.comboAcTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAcTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAcTitle.FormattingEnabled = true;
            this.comboAcTitle.Location = new System.Drawing.Point(258, 178);
            this.comboAcTitle.Name = "comboAcTitle";
            this.comboAcTitle.Size = new System.Drawing.Size(292, 25);
            this.comboAcTitle.TabIndex = 0;
            this.comboAcTitle.SelectedIndexChanged += new System.EventHandler(this.comboAcTitle_SelectedIndexChanged);
            this.comboAcTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboAcTitle_KeyDown);
            // 
            // comboCashAc
            // 
            this.comboCashAc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboCashAc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCashAc.FormattingEnabled = true;
            this.comboCashAc.Location = new System.Drawing.Point(830, 129);
            this.comboCashAc.Name = "comboCashAc";
            this.comboCashAc.Size = new System.Drawing.Size(233, 25);
            this.comboCashAc.TabIndex = 66;
            this.comboCashAc.SelectedIndexChanged += new System.EventHandler(this.comboCashAc_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.Panel1);
            this.panel4.Controls.Add(this.dpVocDate);
            this.panel4.Controls.Add(this.Label3);
            this.panel4.Controls.Add(this.Label2);
            this.panel4.Controls.Add(this.Flex);
            this.panel4.Controls.Add(this.Label4);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.Label5);
            this.panel4.Controls.Add(this.Label8);
            this.panel4.Controls.Add(this.Label6);
            this.panel4.Controls.Add(this.txtAmount);
            this.panel4.Controls.Add(this.Label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1182, 628);
            this.panel4.TabIndex = 67;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::PHMS.Properties.Resources.Plus_26;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(1016, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 25);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Panel1.Controls.Add(this.btnClose);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(11, 8);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1158, 41);
            this.Panel1.TabIndex = 68;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(371, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(310, 39);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Cash Payment Voucher";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(660, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 18);
            this.label9.TabIndex = 51;
            this.label9.Text = "Account Payable";
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
            this.btnClose.Location = new System.Drawing.Point(1119, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 41);
            this.btnClose.TabIndex = 174;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.comboCashAc);
            this.Controls.Add(this.comboAcTitle);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.txtCashAcCode);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.txtVocNo);
            this.Controls.Add(this.xPriHead);
            this.Controls.Add(this.xSecHead);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.txtAcCode);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCashPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRateChange";
            this.Load += new System.EventHandler(this.frmCashPayment_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flex)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnMax;
        internal System.Windows.Forms.Button btnPre;
        internal System.Windows.Forms.Button BtnMin;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.TextBox xTotal;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox txtCashAcCode;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.DateTimePicker dpVocDate;
        internal System.Windows.Forms.TextBox txtVocNo;
        internal System.Windows.Forms.TextBox xPriHead;
        internal System.Windows.Forms.TextBox xSecHead;
        internal System.Windows.Forms.DataGridView Flex;
        internal System.Windows.Forms.TextBox txtAmount;
        internal System.Windows.Forms.TextBox txtNarration;
        internal System.Windows.Forms.TextBox txtAcCode;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.ComboBox comboAcTitle;
        private System.Windows.Forms.ComboBox comboCashAc;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.TextBox txtVocNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}