namespace PHMS
{
    partial class frmExpance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.comboExpenceAccount = new System.Windows.Forms.ComboBox();
            this.txtCashAcCode = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtVocNo = new System.Windows.Forms.TextBox();
            this.comboExpenceType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dpExpence = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtExpenceDis = new System.Windows.Forms.TextBox();
            this.txtExpenceAmount = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbExpence = new System.Windows.Forms.Label();
            this.txtTotalExpenceAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboExpenceSerch = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(14, 94);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 399);
            this.tabControl1.TabIndex = 65;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.comboExpenceAccount);
            this.tabPage1.Controls.Add(this.txtCashAcCode);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnNew);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtVocNo);
            this.tabPage1.Controls.Add(this.comboExpenceType);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dpExpence);
            this.tabPage1.Controls.Add(this.Label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtNotes);
            this.tabPage1.Controls.Add(this.txtExpenceDis);
            this.tabPage1.Controls.Add(this.txtExpenceAmount);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(922, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Expence";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(442, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 119;
            this.label7.Text = "Amount";
            // 
            // comboExpenceAccount
            // 
            this.comboExpenceAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboExpenceAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboExpenceAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboExpenceAccount.FormattingEnabled = true;
            this.comboExpenceAccount.Location = new System.Drawing.Point(536, 175);
            this.comboExpenceAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboExpenceAccount.Name = "comboExpenceAccount";
            this.comboExpenceAccount.Size = new System.Drawing.Size(236, 25);
            this.comboExpenceAccount.TabIndex = 117;
            this.comboExpenceAccount.SelectedIndexChanged += new System.EventHandler(this.comboExpenceAccount_SelectedIndexChanged);
            // 
            // txtCashAcCode
            // 
            this.txtCashAcCode.AutoCompleteCustomSource.AddRange(new string[] {
            "Muhammad"});
            this.txtCashAcCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCashAcCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtCashAcCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCashAcCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashAcCode.Location = new System.Drawing.Point(780, 172);
            this.txtCashAcCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCashAcCode.MaxLength = 250;
            this.txtCashAcCode.Name = "txtCashAcCode";
            this.txtCashAcCode.ReadOnly = true;
            this.txtCashAcCode.Size = new System.Drawing.Size(49, 25);
            this.txtCashAcCode.TabIndex = 116;
            this.txtCashAcCode.TabStop = false;
            this.txtCashAcCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::PHMS.Properties.Resources.Edit_26;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(536, 302);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 42);
            this.btnUpdate.TabIndex = 112;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::PHMS.Properties.Resources.Plus_26;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(245, 302);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(139, 42);
            this.btnNew.TabIndex = 106;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PHMS.Properties.Resources.Save_26;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(390, 302);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 42);
            this.btnSave.TabIndex = 105;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtVocNo
            // 
            this.txtVocNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVocNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVocNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVocNo.Location = new System.Drawing.Point(273, 31);
            this.txtVocNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVocNo.Name = "txtVocNo";
            this.txtVocNo.ReadOnly = true;
            this.txtVocNo.Size = new System.Drawing.Size(165, 25);
            this.txtVocNo.TabIndex = 115;
            this.txtVocNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboExpenceType
            // 
            this.comboExpenceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboExpenceType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboExpenceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.comboExpenceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboExpenceType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboExpenceType.FormattingEnabled = true;
            this.comboExpenceType.Location = new System.Drawing.Point(273, 75);
            this.comboExpenceType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboExpenceType.Name = "comboExpenceType";
            this.comboExpenceType.Size = new System.Drawing.Size(502, 29);
            this.comboExpenceType.TabIndex = 100;
            this.comboExpenceType.SelectedIndexChanged += new System.EventHandler(this.comboExpenceType_SelectedIndexChanged);
            this.comboExpenceType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboExpenceType_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(91, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 114;
            this.label8.Text = "Expence ID";
            // 
            // dpExpence
            // 
            this.dpExpence.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpExpence.CustomFormat = "dd/MM/yyyy";
            this.dpExpence.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpExpence.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpExpence.Location = new System.Drawing.Point(567, 29);
            this.dpExpence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpExpence.Name = "dpExpence";
            this.dpExpence.Size = new System.Drawing.Size(207, 25);
            this.dpExpence.TabIndex = 113;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(446, 32);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(97, 21);
            this.Label4.TabIndex = 108;
            this.Label4.Text = "Choose Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(91, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 109;
            this.label5.Text = "Expence Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(88, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 110;
            this.label2.Text = "Expance Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(91, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 110;
            this.label3.Text = "Expance Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(88, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 110;
            this.label6.Text = "Expance Amount";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(270, 220);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(502, 58);
            this.txtNotes.TabIndex = 104;
            this.txtNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyDown);
            // 
            // txtExpenceDis
            // 
            this.txtExpenceDis.BackColor = System.Drawing.Color.White;
            this.txtExpenceDis.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpenceDis.Location = new System.Drawing.Point(270, 125);
            this.txtExpenceDis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExpenceDis.Name = "txtExpenceDis";
            this.txtExpenceDis.Size = new System.Drawing.Size(504, 25);
            this.txtExpenceDis.TabIndex = 101;
            this.txtExpenceDis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpenceDis_KeyDown);
            // 
            // txtExpenceAmount
            // 
            this.txtExpenceAmount.BackColor = System.Drawing.Color.White;
            this.txtExpenceAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpenceAmount.Location = new System.Drawing.Point(270, 171);
            this.txtExpenceAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExpenceAmount.Name = "txtExpenceAmount";
            this.txtExpenceAmount.Size = new System.Drawing.Size(165, 25);
            this.txtExpenceAmount.TabIndex = 101;
            this.txtExpenceAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpenceAmount_KeyDown);
            this.txtExpenceAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpenceAmount_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbExpence);
            this.tabPage2.Controls.Add(this.txtTotalExpenceAmount);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.comboExpenceSerch);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(922, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Expence";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lbExpence
            // 
            this.lbExpence.AutoSize = true;
            this.lbExpence.Location = new System.Drawing.Point(437, 29);
            this.lbExpence.Name = "lbExpence";
            this.lbExpence.Size = new System.Drawing.Size(108, 21);
            this.lbExpence.TabIndex = 109;
            this.lbExpence.Text = "Total Amount ";
            // 
            // txtTotalExpenceAmount
            // 
            this.txtTotalExpenceAmount.Location = new System.Drawing.Point(676, 26);
            this.txtTotalExpenceAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalExpenceAmount.Name = "txtTotalExpenceAmount";
            this.txtTotalExpenceAmount.Size = new System.Drawing.Size(230, 29);
            this.txtTotalExpenceAmount.TabIndex = 108;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(285, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 107;
            this.button1.Text = "Get All Expence";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboExpenceSerch
            // 
            this.comboExpenceSerch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboExpenceSerch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboExpenceSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.comboExpenceSerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboExpenceSerch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboExpenceSerch.FormattingEnabled = true;
            this.comboExpenceSerch.Location = new System.Drawing.Point(7, 26);
            this.comboExpenceSerch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboExpenceSerch.Name = "comboExpenceSerch";
            this.comboExpenceSerch.Size = new System.Drawing.Size(251, 29);
            this.comboExpenceSerch.TabIndex = 101;
            this.comboExpenceSerch.SelectedIndexChanged += new System.EventHandler(this.comboExpenceSerch_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ExpenceDate,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(3, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(903, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Expence ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // ExpenceDate
            // 
            this.ExpenceDate.HeaderText = "ExpenceDate";
            this.ExpenceDate.Name = "ExpenceDate";
            this.ExpenceDate.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Expence Type";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Expence Amount";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Expence Discription";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Edit";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Delete";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Notes";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 503);
            this.panel1.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 41);
            this.panel2.TabIndex = 14;
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
            this.btnClose.Location = new System.Drawing.Point(919, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 41);
            this.btnClose.TabIndex = 142;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(397, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Expance Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmExpance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 503);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmExpance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expence Form";
            this.Load += new System.EventHandler(this.frmExpance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.TextBox txtVocNo;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox comboExpenceType;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpExpence;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtNotes;
        internal System.Windows.Forms.TextBox txtExpenceAmount;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtExpenceDis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboExpenceSerch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox comboExpenceAccount;
        internal System.Windows.Forms.TextBox txtCashAcCode;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbExpence;
        private System.Windows.Forms.TextBox txtTotalExpenceAmount;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Label label1;
    }
}