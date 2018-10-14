namespace AutoCRBP_X
{
    partial class Staff_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDesg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegno = new System.Windows.Forms.TextBox();
            this.cbStaffName = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autocrbDataSet = new AutoCRBP_X.autocrbDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radoFN = new System.Windows.Forms.RadioButton();
            this.radoAN = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpExamDate = new System.Windows.Forms.DateTimePicker();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtTotalSession = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.staff_reportTableAdapter = new AutoCRBP_X.autocrbDataSetTableAdapters.staff_reportTableAdapter();
            this.staffTableAdapter = new AutoCRBP_X.autocrbDataSetTableAdapters.staffTableAdapter();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.errorApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.staffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_regnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessiontimingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalsessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratesessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autocrbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffreportBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddStaff);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtDesg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRegno);
            this.groupBox1.Controls.Add(this.cbStaffName);
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(330, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(299, 17);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(27, 22);
            this.btnAddStaff.TabIndex = 9;
            this.btnAddStaff.Text = "...";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 72);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Designation";
            // 
            // txtDesg
            // 
            this.txtDesg.Enabled = false;
            this.txtDesg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesg.Location = new System.Drawing.Point(71, 69);
            this.txtDesg.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesg.Name = "txtDesg";
            this.txtDesg.Size = new System.Drawing.Size(224, 20);
            this.txtDesg.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reg no.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff name";
            // 
            // txtRegno
            // 
            this.txtRegno.Enabled = false;
            this.txtRegno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegno.Location = new System.Drawing.Point(71, 42);
            this.txtRegno.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegno.Name = "txtRegno";
            this.txtRegno.Size = new System.Drawing.Size(224, 20);
            this.txtRegno.TabIndex = 1;
            // 
            // cbStaffName
            // 
            this.cbStaffName.DataSource = this.staffBindingSource;
            this.cbStaffName.DisplayMember = "staff_name";
            this.cbStaffName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaffName.FormattingEnabled = true;
            this.cbStaffName.Location = new System.Drawing.Point(71, 17);
            this.cbStaffName.Margin = new System.Windows.Forms.Padding(2);
            this.cbStaffName.Name = "cbStaffName";
            this.cbStaffName.Size = new System.Drawing.Size(224, 21);
            this.cbStaffName.TabIndex = 0;
            this.cbStaffName.ValueMember = "staff_regno";
            this.cbStaffName.SelectedIndexChanged += new System.EventHandler(this.cbStaffName_SelectedIndexChanged);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.autocrbDataSet;
            // 
            // autocrbDataSet
            // 
            this.autocrbDataSet.DataSetName = "autocrbDataSet";
            this.autocrbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffidDataGridViewTextBoxColumn,
            this.staff_regnoDataGridViewTextBoxColumn,
            this.staffnameDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.sessiondateDataGridViewTextBoxColumn,
            this.sessiontimingDataGridViewTextBoxColumn,
            this.totalsessionDataGridViewTextBoxColumn,
            this.ratesessionDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffreportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 209);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 235);
            this.dataGridView1.TabIndex = 2;
            // 
            // staffreportBindingSource
            // 
            this.staffreportBindingSource.DataMember = "staff_report";
            this.staffreportBindingSource.DataSource = this.autocrbDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radoFN);
            this.groupBox2.Controls.Add(this.radoAN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpExamDate);
            this.groupBox2.Location = new System.Drawing.Point(11, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(333, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // radoFN
            // 
            this.radoFN.AutoSize = true;
            this.radoFN.Checked = true;
            this.radoFN.Location = new System.Drawing.Point(164, 43);
            this.radoFN.Margin = new System.Windows.Forms.Padding(2);
            this.radoFN.Name = "radoFN";
            this.radoFN.Size = new System.Drawing.Size(39, 17);
            this.radoFN.TabIndex = 7;
            this.radoFN.TabStop = true;
            this.radoFN.Text = "FN";
            this.radoFN.UseVisualStyleBackColor = true;
            // 
            // radoAN
            // 
            this.radoAN.AutoSize = true;
            this.radoAN.Location = new System.Drawing.Point(204, 43);
            this.radoAN.Margin = new System.Windows.Forms.Padding(2);
            this.radoAN.Name = "radoAN";
            this.radoAN.Size = new System.Drawing.Size(40, 17);
            this.radoAN.TabIndex = 6;
            this.radoAN.Text = "AN";
            this.radoAN.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sessions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Examination date";
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExamDate.Location = new System.Drawing.Point(9, 43);
            this.dtpExamDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.Size = new System.Drawing.Size(141, 20);
            this.dtpExamDate.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(269, 82);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 22);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(205, 82);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 22);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.txtRate);
            this.groupBox3.Controls.Add(this.txtTotalSession);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(351, 79);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(333, 115);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(11, 84);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(171, 20);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.Text = "0";
            this.txtTotal.Validating += new System.ComponentModel.CancelEventHandler(this.CalculateTotal);
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(154, 39);
            this.txtRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRate.MaxLength = 4;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(156, 20);
            this.txtRate.TabIndex = 11;
            this.txtRate.Text = "100";
            this.txtRate.Validating += new System.ComponentModel.CancelEventHandler(this.CalculateTotal);
            // 
            // txtTotalSession
            // 
            this.txtTotalSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSession.Location = new System.Drawing.Point(11, 39);
            this.txtTotalSession.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalSession.MaxLength = 2;
            this.txtTotalSession.Name = "txtTotalSession";
            this.txtTotalSession.Size = new System.Drawing.Size(124, 20);
            this.txtTotalSession.TabIndex = 4;
            this.txtTotalSession.Text = "0";
            this.txtTotalSession.Validating += new System.ComponentModel.CancelEventHandler(this.CalculateTotal);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total sessions";
            // 
            // staff_reportTableAdapter
            // 
            this.staff_reportTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(351, 55);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(60, 22);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // errorApp
            // 
            this.errorApp.ContainerControl = this;
            // 
            // staffidDataGridViewTextBoxColumn
            // 
            this.staffidDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.staffidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.staffidDataGridViewTextBoxColumn.HeaderText = "Serial no";
            this.staffidDataGridViewTextBoxColumn.Name = "staffidDataGridViewTextBoxColumn";
            this.staffidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staff_regnoDataGridViewTextBoxColumn
            // 
            this.staff_regnoDataGridViewTextBoxColumn.DataPropertyName = "staff_regno";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.staff_regnoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.staff_regnoDataGridViewTextBoxColumn.HeaderText = "Reg. Number";
            this.staff_regnoDataGridViewTextBoxColumn.Name = "staff_regnoDataGridViewTextBoxColumn";
            this.staff_regnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffnameDataGridViewTextBoxColumn
            // 
            this.staffnameDataGridViewTextBoxColumn.DataPropertyName = "staff_name";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.staffnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.staffnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.staffnameDataGridViewTextBoxColumn.Name = "staffnameDataGridViewTextBoxColumn";
            this.staffnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "designation";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.designationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessiondateDataGridViewTextBoxColumn
            // 
            this.sessiondateDataGridViewTextBoxColumn.DataPropertyName = "session_date";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.sessiondateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.sessiondateDataGridViewTextBoxColumn.HeaderText = "Session Date";
            this.sessiondateDataGridViewTextBoxColumn.Name = "sessiondateDataGridViewTextBoxColumn";
            this.sessiondateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessiontimingDataGridViewTextBoxColumn
            // 
            this.sessiontimingDataGridViewTextBoxColumn.DataPropertyName = "session_timing";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.sessiontimingDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.sessiontimingDataGridViewTextBoxColumn.HeaderText = "Session Time";
            this.sessiontimingDataGridViewTextBoxColumn.Name = "sessiontimingDataGridViewTextBoxColumn";
            this.sessiontimingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalsessionDataGridViewTextBoxColumn
            // 
            this.totalsessionDataGridViewTextBoxColumn.DataPropertyName = "total_session";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.totalsessionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.totalsessionDataGridViewTextBoxColumn.HeaderText = "Total Sessions";
            this.totalsessionDataGridViewTextBoxColumn.Name = "totalsessionDataGridViewTextBoxColumn";
            this.totalsessionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratesessionDataGridViewTextBoxColumn
            // 
            this.ratesessionDataGridViewTextBoxColumn.DataPropertyName = "rate_session";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.ratesessionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.ratesessionDataGridViewTextBoxColumn.HeaderText = "Session rate";
            this.ratesessionDataGridViewTextBoxColumn.Name = "ratesessionDataGridViewTextBoxColumn";
            this.ratesessionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Bookman Old Style", 9.75F);
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Staff_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 455);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Staff_Details";
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autocrbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffreportBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegno;
        private System.Windows.Forms.ComboBox cbStaffName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpExamDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtTotalSession;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDesg;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton radoFN;
        private System.Windows.Forms.RadioButton radoAN;
        private autocrbDataSet autocrbDataSet;
        private System.Windows.Forms.BindingSource staffreportBindingSource;
        private autocrbDataSetTableAdapters.staff_reportTableAdapter staff_reportTableAdapter;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private autocrbDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ErrorProvider errorApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_regnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessiontimingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalsessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratesessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}