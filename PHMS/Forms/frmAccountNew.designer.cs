namespace PHMS
{
    partial class frmAccountNew
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.bSave = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.xDelete = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dpInvoice = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cmbAcType = new System.Windows.Forms.ComboBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.txtAcTitle = new System.Windows.Forms.TextBox();
            this.txtAcSerial = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GetData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.cc.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(368, 3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(199, 32);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Chart Of Account";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.bSave);
            this.Panel3.Controls.Add(this.bClear);
            this.Panel3.Controls.Add(this.bEdit);
            this.Panel3.Controls.Add(this.btnDelete);
            this.Panel3.Controls.Add(this.xDelete);
            this.Panel3.Location = new System.Drawing.Point(11, 449);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(864, 59);
            this.Panel3.TabIndex = 14;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.ForeColor = System.Drawing.Color.White;
            this.bSave.Image = global::PHMS.Properties.Resources.Save_26;
            this.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSave.Location = new System.Drawing.Point(183, 12);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(104, 36);
            this.bSave.TabIndex = 5;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.ForeColor = System.Drawing.Color.White;
            this.bClear.Location = new System.Drawing.Point(623, 12);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(104, 36);
            this.bClear.TabIndex = 6;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.ForeColor = System.Drawing.Color.White;
            this.bEdit.Image = global::PHMS.Properties.Resources.Edit_26;
            this.bEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEdit.Location = new System.Drawing.Point(293, 12);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(104, 36);
            this.bEdit.TabIndex = 7;
            this.bEdit.Text = "Update";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::PHMS.Properties.Resources.del;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(513, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // xDelete
            // 
            this.xDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.xDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xDelete.ForeColor = System.Drawing.Color.White;
            this.xDelete.Location = new System.Drawing.Point(403, 12);
            this.xDelete.Name = "xDelete";
            this.xDelete.Size = new System.Drawing.Size(104, 36);
            this.xDelete.TabIndex = 8;
            this.xDelete.Text = "Disable";
            this.xDelete.UseVisualStyleBackColor = false;
            this.xDelete.Click += new System.EventHandler(this.xDelete_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Panel1.Controls.Add(this.button1);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Location = new System.Drawing.Point(11, 8);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(935, 41);
            this.Panel1.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::PHMS.Properties.Resources.shutdown;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(918, 475);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 41);
            this.btnClose.TabIndex = 142;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.White;
            this.TabPage1.Controls.Add(this.label5);
            this.TabPage1.Controls.Add(this.label12);
            this.TabPage1.Controls.Add(this.label13);
            this.TabPage1.Controls.Add(this.label14);
            this.TabPage1.Controls.Add(this.txtEmail);
            this.TabPage1.Controls.Add(this.txtCity);
            this.TabPage1.Controls.Add(this.txtPhoneNo);
            this.TabPage1.Controls.Add(this.txtAddress);
            this.TabPage1.Controls.Add(this.dpInvoice);
            this.TabPage1.Controls.Add(this.label1);
            this.TabPage1.Controls.Add(this.label11);
            this.TabPage1.Controls.Add(this.label8);
            this.TabPage1.Controls.Add(this.label10);
            this.TabPage1.Controls.Add(this.label18);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.cmbAcType);
            this.TabPage1.Controls.Add(this.txtCredit);
            this.TabPage1.Controls.Add(this.txtDebit);
            this.TabPage1.Controls.Add(this.txtAcTitle);
            this.TabPage1.Controls.Add(this.txtAcSerial);
            this.TabPage1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(935, 362);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Account Details";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(76, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 169;
            this.label5.Text = "Email Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(76, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 20);
            this.label12.TabIndex = 169;
            this.label12.Text = "City";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(76, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 170;
            this.label13.Text = "Phone No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(76, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 168;
            this.label14.Text = "Address";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(216, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(507, 25);
            this.txtEmail.TabIndex = 165;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(216, 199);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(507, 25);
            this.txtCity.TabIndex = 165;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BackColor = System.Drawing.Color.White;
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(216, 168);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(507, 25);
            this.txtPhoneNo.TabIndex = 166;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(216, 260);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(507, 63);
            this.txtAddress.TabIndex = 167;
            // 
            // dpInvoice
            // 
            this.dpInvoice.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInvoice.CustomFormat = "dd/MM/yyyy";
            this.dpInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpInvoice.Location = new System.Drawing.Point(219, 11);
            this.dpInvoice.Name = "dpInvoice";
            this.dpInvoice.Size = new System.Drawing.Size(504, 25);
            this.dpInvoice.TabIndex = 164;
            this.dpInvoice.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(75, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "A/C Type :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(446, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 93;
            this.label11.Text = "Credit :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(75, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 93;
            this.label8.Text = "Debit :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(75, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 93;
            this.label10.Text = "Account Title:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label18.Location = new System.Drawing.Point(75, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 20);
            this.label18.TabIndex = 93;
            this.label18.Text = "Opening Date:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Label2.Location = new System.Drawing.Point(75, 51);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 20);
            this.Label2.TabIndex = 93;
            this.Label2.Text = "Account Serial:";
            // 
            // cmbAcType
            // 
            this.cmbAcType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAcType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAcType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.cmbAcType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAcType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcType.FormattingEnabled = true;
            this.cmbAcType.Location = new System.Drawing.Point(216, 91);
            this.cmbAcType.Name = "cmbAcType";
            this.cmbAcType.Size = new System.Drawing.Size(507, 29);
            this.cmbAcType.TabIndex = 0;
            this.cmbAcType.SelectedIndexChanged += new System.EventHandler(this.cmbAcType_SelectedIndexChanged);
            // 
            // txtCredit
            // 
            this.txtCredit.BackColor = System.Drawing.Color.White;
            this.txtCredit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredit.Location = new System.Drawing.Point(518, 329);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(205, 25);
            this.txtCredit.TabIndex = 4;
            this.txtCredit.Text = "0";
            this.txtCredit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCredit_KeyDown);
            // 
            // txtDebit
            // 
            this.txtDebit.BackColor = System.Drawing.Color.White;
            this.txtDebit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebit.Location = new System.Drawing.Point(216, 329);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(213, 25);
            this.txtDebit.TabIndex = 3;
            this.txtDebit.Text = "0";
            this.txtDebit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDebit_KeyDown);
            // 
            // txtAcTitle
            // 
            this.txtAcTitle.BackColor = System.Drawing.Color.White;
            this.txtAcTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcTitle.Location = new System.Drawing.Point(216, 135);
            this.txtAcTitle.Name = "txtAcTitle";
            this.txtAcTitle.Size = new System.Drawing.Size(507, 25);
            this.txtAcTitle.TabIndex = 1;
            this.txtAcTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcTitle_KeyDown);
            // 
            // txtAcSerial
            // 
            this.txtAcSerial.BackColor = System.Drawing.Color.White;
            this.txtAcSerial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcSerial.Location = new System.Drawing.Point(216, 51);
            this.txtAcSerial.Name = "txtAcSerial";
            this.txtAcSerial.Size = new System.Drawing.Size(507, 25);
            this.txtAcSerial.TabIndex = 38;
            // 
            // cc
            // 
            this.cc.AccessibleDescription = "";
            this.cc.AccessibleName = "";
            this.cc.Controls.Add(this.TabPage1);
            this.cc.Controls.Add(this.tabPage2);
            this.cc.Location = new System.Drawing.Point(11, 55);
            this.cc.Name = "cc";
            this.cc.SelectedIndex = 0;
            this.cc.Size = new System.Drawing.Size(943, 388);
            this.cc.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GetData);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtSerch);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(935, 362);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "View Account Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GetData
            // 
            this.GetData.BackColor = System.Drawing.Color.LightSkyBlue;
            this.GetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetData.ForeColor = System.Drawing.Color.White;
            this.GetData.Location = new System.Drawing.Point(191, 32);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(80, 25);
            this.GetData.TabIndex = 105;
            this.GetData.Text = "Get All Data";
            this.GetData.UseVisualStyleBackColor = false;
            this.GetData.Click += new System.EventHandler(this.GetData_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 104;
            this.label4.Text = "Enter Account Title:";
            // 
            // txtSerch
            // 
            this.txtSerch.BackColor = System.Drawing.Color.White;
            this.txtSerch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerch.Location = new System.Drawing.Point(4, 32);
            this.txtSerch.Name = "txtSerch";
            this.txtSerch.Size = new System.Drawing.Size(181, 25);
            this.txtSerch.TabIndex = 103;
            this.txtSerch.TextChanged += new System.EventHandler(this.txtSerch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column5,
            this.Column4,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(4, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(927, 268);
            this.dataGridView1.TabIndex = 102;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Account Code";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Account Type";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Account Title";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Phone No";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "City";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Address";
            this.Column8.Name = "Column8";
            this.Column8.Width = 180;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Edit";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Name";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 517);
            this.panel2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::PHMS.Properties.Resources.close_2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(896, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 41);
            this.button1.TabIndex = 174;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAccountNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 517);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccountNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccountNew";
            this.Load += new System.EventHandler(this.frmAccountNew_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.cc.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button bSave;
        internal System.Windows.Forms.Button bClear;
        internal System.Windows.Forms.Button bEdit;
        internal System.Windows.Forms.Button xDelete;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TabControl cc;
        internal System.Windows.Forms.TextBox txtAcSerial;
        private System.Windows.Forms.ComboBox cmbAcType;
        internal System.Windows.Forms.TextBox txtAcTitle;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtCredit;
        internal System.Windows.Forms.TextBox txtDebit;
        internal System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dpInvoice;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button GetData;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtSerch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.TextBox txtPhoneNo;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button1;
    }
}