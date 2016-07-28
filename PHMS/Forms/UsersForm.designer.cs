namespace PHMS
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.RightOption = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbUsersDetails = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUsersDetail = new System.Windows.Forms.Button();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.txtUserContect = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerUser = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.updateUser = new System.Windows.Forms.Button();
            this.gbuserRegister = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newUser = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.userPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.userPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbUsersDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.gbuserRegister.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbUsersDetails
            // 
            this.gbUsersDetails.Controls.Add(this.groupBox1);
            this.gbUsersDetails.Controls.Add(this.dataGridView1);
            this.gbUsersDetails.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsersDetails.Location = new System.Drawing.Point(12, 116);
            this.gbUsersDetails.Name = "gbUsersDetails";
            this.gbUsersDetails.Size = new System.Drawing.Size(1009, 518);
            this.gbUsersDetails.TabIndex = 45;
            this.gbUsersDetails.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserSearch);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Name";
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSearch.Location = new System.Drawing.Point(31, 31);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(269, 26);
            this.txtUserSearch.TabIndex = 13;
            this.txtUserSearch.TextChanged += new System.EventHandler(this.txtUserSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column9,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(15, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(988, 382);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // Column1
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "User ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "User Role";
            this.Column6.Name = "Column6";
            this.Column6.Width = 90;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "First Name";
            this.Column9.Name = "Column9";
            this.Column9.Width = 90;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Last Name";
            this.Column10.Name = "Column10";
            this.Column10.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Full Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "User Password";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "User Contect Number";
            this.Column4.Name = "Column4";
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "User Email";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Edit";
            this.Column7.Name = "Column7";
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Delete";
            this.Column8.Name = "Column8";
            this.Column8.Width = 60;
            // 
            // btnUsersDetail
            // 
            this.btnUsersDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.btnUsersDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsersDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUsersDetail.FlatAppearance.BorderSize = 0;
            this.btnUsersDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.btnUsersDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersDetail.ForeColor = System.Drawing.Color.White;
            this.btnUsersDetail.Location = new System.Drawing.Point(116, 63);
            this.btnUsersDetail.Name = "btnUsersDetail";
            this.btnUsersDetail.Size = new System.Drawing.Size(130, 36);
            this.btnUsersDetail.TabIndex = 0;
            this.btnUsersDetail.Text = "Users Details";
            this.btnUsersDetail.UseVisualStyleBackColor = false;
            this.btnUsersDetail.Click += new System.EventHandler(this.btnUsersDetail_Click);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.btnAddUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddUsers.FlatAppearance.BorderSize = 0;
            this.btnAddUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.btnAddUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsers.ForeColor = System.Drawing.Color.White;
            this.btnAddUsers.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAddUsers.Location = new System.Drawing.Point(12, 63);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(98, 36);
            this.btnAddUsers.TabIndex = 0;
            this.btnAddUsers.Text = "Add User";
            this.btnAddUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddUsers.UseVisualStyleBackColor = false;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Black;
            this.pbExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbExit.Location = new System.Drawing.Point(2, 402);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(73, 76);
            this.pbExit.TabIndex = 5;
            this.pbExit.TabStop = false;
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.Black;
            this.pbHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbHome.Location = new System.Drawing.Point(3, 196);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(74, 76);
            this.pbHome.TabIndex = 4;
            this.pbHome.TabStop = false;
            // 
            // pbLogout
            // 
            this.pbLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbLogout.Location = new System.Drawing.Point(3, 0);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(74, 76);
            this.pbLogout.TabIndex = 3;
            this.pbLogout.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(107, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(107, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "User Password";
            // 
            // comboRole
            // 
            this.comboRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboRole.BackColor = System.Drawing.Color.Gainsboro;
            this.comboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboRole.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Items.AddRange(new object[] {
            "Admin",
            "Employee",
            "Manager"});
            this.comboRole.Location = new System.Drawing.Point(260, 39);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(338, 28);
            this.comboRole.Sorted = true;
            this.comboRole.TabIndex = 0;
            this.comboRole.SelectedIndexChanged += new System.EventHandler(this.comboRole_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(107, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(107, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Contact Number";
            // 
            // txtUserMail
            // 
            this.txtUserMail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUserMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserMail.Location = new System.Drawing.Point(260, 369);
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(338, 29);
            this.txtUserMail.TabIndex = 6;
            this.txtUserMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserMail_KeyDown);
            this.txtUserMail.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserMail_Validating_1);
            // 
            // txtUserContect
            // 
            this.txtUserContect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUserContect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserContect.Location = new System.Drawing.Point(260, 309);
            this.txtUserContect.Name = "txtUserContect";
            this.txtUserContect.Size = new System.Drawing.Size(338, 29);
            this.txtUserContect.TabIndex = 5;
            this.txtUserContect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserContect_KeyDown);
            this.txtUserContect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserContect_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(107, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Email Adddress";
            // 
            // txtUserPass
            // 
            this.txtUserPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUserPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPass.Location = new System.Drawing.Point(260, 192);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.Size = new System.Drawing.Size(338, 29);
            this.txtUserPass.TabIndex = 3;
            this.txtUserPass.UseSystemPasswordChar = true;
            this.txtUserPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserPass_KeyDown);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(260, 250);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(338, 29);
            this.txtConfirmPass.TabIndex = 4;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            this.txtConfirmPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPass_KeyDown);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(260, 91);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(338, 29);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "User Role";
            // 
            // registerUser
            // 
            this.registerUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.registerUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerUser.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.registerUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.registerUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.registerUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.registerUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUser.ForeColor = System.Drawing.Color.Black;
            this.registerUser.Location = new System.Drawing.Point(284, 450);
            this.registerUser.Name = "registerUser";
            this.registerUser.Size = new System.Drawing.Size(119, 31);
            this.registerUser.TabIndex = 7;
            this.registerUser.Text = "Register";
            this.registerUser.UseVisualStyleBackColor = false;
            this.registerUser.Click += new System.EventHandler(this.registerUser_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.deleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.deleteUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.deleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.deleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUser.ForeColor = System.Drawing.Color.Black;
            this.deleteUser.Location = new System.Drawing.Point(409, 450);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(119, 31);
            this.deleteUser.TabIndex = 8;
            this.deleteUser.Text = "Delete";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // updateUser
            // 
            this.updateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.updateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateUser.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.updateUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.updateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.updateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.updateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUser.ForeColor = System.Drawing.Color.Black;
            this.updateUser.Location = new System.Drawing.Point(534, 450);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(119, 31);
            this.updateUser.TabIndex = 9;
            this.updateUser.Text = "Update";
            this.updateUser.UseVisualStyleBackColor = false;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // gbuserRegister
            // 
            this.gbuserRegister.Controls.Add(this.txtLastName);
            this.gbuserRegister.Controls.Add(this.label6);
            this.gbuserRegister.Controls.Add(this.newUser);
            this.gbuserRegister.Controls.Add(this.txtUserID);
            this.gbuserRegister.Controls.Add(this.btnGetData);
            this.gbuserRegister.Controls.Add(this.updateUser);
            this.gbuserRegister.Controls.Add(this.deleteUser);
            this.gbuserRegister.Controls.Add(this.registerUser);
            this.gbuserRegister.Controls.Add(this.label1);
            this.gbuserRegister.Controls.Add(this.txtFirstName);
            this.gbuserRegister.Controls.Add(this.txtConfirmPass);
            this.gbuserRegister.Controls.Add(this.txtUserPass);
            this.gbuserRegister.Controls.Add(this.label7);
            this.gbuserRegister.Controls.Add(this.txtUserContect);
            this.gbuserRegister.Controls.Add(this.txtUserMail);
            this.gbuserRegister.Controls.Add(this.label5);
            this.gbuserRegister.Controls.Add(this.label4);
            this.gbuserRegister.Controls.Add(this.comboRole);
            this.gbuserRegister.Controls.Add(this.label3);
            this.gbuserRegister.Controls.Add(this.label2);
            this.gbuserRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbuserRegister.Location = new System.Drawing.Point(12, 116);
            this.gbuserRegister.Name = "gbuserRegister";
            this.gbuserRegister.Size = new System.Drawing.Size(1009, 518);
            this.gbuserRegister.TabIndex = 35;
            this.gbuserRegister.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(260, 138);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(338, 29);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastName_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(107, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Last Name";
            // 
            // newUser
            // 
            this.newUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.newUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newUser.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.newUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.newUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.newUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.newUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUser.ForeColor = System.Drawing.Color.Black;
            this.newUser.Location = new System.Drawing.Point(159, 450);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(119, 31);
            this.newUser.TabIndex = 37;
            this.newUser.Text = "New";
            this.newUser.UseVisualStyleBackColor = false;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUserID.Location = new System.Drawing.Point(604, 41);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 22);
            this.txtUserID.TabIndex = 47;
            // 
            // btnGetData
            // 
            this.btnGetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetData.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGetData.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnGetData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnGetData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.ForeColor = System.Drawing.Color.Black;
            this.btnGetData.Location = new System.Drawing.Point(659, 450);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(119, 31);
            this.btnGetData.TabIndex = 10;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = false;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // userPrintPreviewDialog
            // 
            this.userPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.userPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.userPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.userPrintPreviewDialog.Enabled = true;
            this.userPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("userPrintPreviewDialog.Icon")));
            this.userPrintPreviewDialog.Name = "userPrintPreviewDialog";
            this.userPrintPreviewDialog.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 642);
            this.panel1.TabIndex = 167;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(11, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 41);
            this.panel3.TabIndex = 189;
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
            this.button1.Location = new System.Drawing.Point(1127, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 41);
            this.button1.TabIndex = 141;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(371, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 39);
            this.label8.TabIndex = 3;
            this.label8.Text = "User Form";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnClose.Location = new System.Drawing.Point(970, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 41);
            this.btnClose.TabIndex = 142;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 642);
            this.Controls.Add(this.btnUsersDetail);
            this.Controls.Add(this.btnAddUsers);
            this.Controls.Add(this.gbuserRegister);
            this.Controls.Add(this.gbUsersDetails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.gbUsersDetails.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            this.gbuserRegister.ResumeLayout(false);
            this.gbuserRegister.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer RightOption;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbUsersDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUsersDetail;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.TextBox txtUserContect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerUser;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.GroupBox gbuserRegister;
        private System.Windows.Forms.PrintPreviewDialog userPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument userPrintDocument;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClose;
    }
}