namespace QLSinhVienHunre
{
    partial class SinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxHo = new System.Windows.Forms.TextBox();
            this.nam = new System.Windows.Forms.RadioButton();
            this.nu = new System.Windows.Forms.RadioButton();
            this.textBoxNamNhapHoc = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlsinhvienhunreDataSet = new QLSinhVienHunre.qlsinhvienhunreDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxNganhHoc = new System.Windows.Forms.ComboBox();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlsinhvienhunreDataSet2 = new QLSinhVienHunre.qlsinhvienhunreDataSet2();
            this.panelGioiTinh = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.nganhHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlsinhvienhunreDataSet1 = new QLSinhVienHunre.qlsinhvienhunreDataSet1();
            this.sinhVienTableAdapter = new QLSinhVienHunre.qlsinhvienhunreDataSetTableAdapters.SinhVienTableAdapter();
            this.qlsinhvienhunreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nganhHocTableAdapter = new QLSinhVienHunre.qlsinhvienhunreDataSet1TableAdapters.NganhHocTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lopTableAdapter = new QLSinhVienHunre.qlsinhvienhunreDataSet2TableAdapters.LopTableAdapter();
            this.maSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namNhapHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNganhHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienhunreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienhunreDataSet2)).BeginInit();
            this.panelGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nganhHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienhunreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienhunreDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giới Tính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Năm nhập học";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(134, 26);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(114, 20);
            this.textBoxID.TabIndex = 9;
            // 
            // textBoxHo
            // 
            this.textBoxHo.Location = new System.Drawing.Point(134, 54);
            this.textBoxHo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxHo.Name = "textBoxHo";
            this.textBoxHo.Size = new System.Drawing.Size(114, 20);
            this.textBoxHo.TabIndex = 10;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.Location = new System.Drawing.Point(0, 5);
            this.nam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(52, 19);
            this.nam.TabIndex = 14;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu.Location = new System.Drawing.Point(56, 6);
            this.nu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(41, 19);
            this.nu.TabIndex = 15;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // textBoxNamNhapHoc
            // 
            this.textBoxNamNhapHoc.Location = new System.Drawing.Point(134, 113);
            this.textBoxNamNhapHoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNamNhapHoc.Name = "textBoxNamNhapHoc";
            this.textBoxNamNhapHoc.Size = new System.Drawing.Size(114, 20);
            this.textBoxNamNhapHoc.TabIndex = 16;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(336, 24);
            this.dateTimePickerNgaySinh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(116, 21);
            this.dateTimePickerNgaySinh.TabIndex = 17;
            this.dateTimePickerNgaySinh.Value = new System.DateTime(2024, 4, 9, 22, 9, 26, 0);
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSinhVien.AutoGenerateColumns = false;
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVienDataGridViewTextBoxColumn,
            this.hoSinhVienDataGridViewTextBoxColumn,
            this.tenSinhVienDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.namNhapHocDataGridViewTextBoxColumn,
            this.maNganhHocDataGridViewTextBoxColumn});
            this.dataGridViewSinhVien.DataSource = this.sinhVienBindingSource;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(18, 214);
            this.dataGridViewSinhVien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.RowHeadersWidth = 51;
            this.dataGridViewSinhVien.RowTemplate.Height = 24;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(723, 197);
            this.dataGridViewSinhVien.TabIndex = 18;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qlsinhvienhunreDataSet;
            // 
            // qlsinhvienhunreDataSet
            // 
            this.qlsinhvienhunreDataSet.DataSetName = "qlsinhvienhunreDataSet";
            this.qlsinhvienhunreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(581, 17);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(160, 180);
            this.dataGridView2.TabIndex = 19;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(630, 24);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(66, 29);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(630, 71);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(67, 32);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(630, 120);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(67, 30);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(629, 163);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(67, 31);
            this.buttonReset.TabIndex = 22;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.comboBoxNganhHoc);
            this.groupBox1.Controls.Add(this.panelGioiTinh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePickerNgaySinh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxNamNhapHoc);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.textBoxHo);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(540, 180);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxNganhHoc
            // 
            this.comboBoxNganhHoc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lopBindingSource, "maLop", true));
            this.comboBoxNganhHoc.DataSource = this.lopBindingSource;
            this.comboBoxNganhHoc.DisplayMember = "maLop";
            this.comboBoxNganhHoc.FormattingEnabled = true;
            this.comboBoxNganhHoc.Location = new System.Drawing.Point(336, 87);
            this.comboBoxNganhHoc.Name = "comboBoxNganhHoc";
            this.comboBoxNganhHoc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNganhHoc.TabIndex = 21;
            this.comboBoxNganhHoc.ValueMember = "maLop";
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.qlsinhvienhunreDataSet2;
            // 
            // qlsinhvienhunreDataSet2
            // 
            this.qlsinhvienhunreDataSet2.DataSetName = "qlsinhvienhunreDataSet2";
            this.qlsinhvienhunreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelGioiTinh
            // 
            this.panelGioiTinh.Controls.Add(this.nu);
            this.panelGioiTinh.Controls.Add(this.nam);
            this.panelGioiTinh.Location = new System.Drawing.Point(336, 50);
            this.panelGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.panelGioiTinh.Name = "panelGioiTinh";
            this.panelGioiTinh.Size = new System.Drawing.Size(121, 28);
            this.panelGioiTinh.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tên";
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(134, 82);
            this.textBoxTen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(114, 20);
            this.textBoxTen.TabIndex = 19;
            // 
            // nganhHocBindingSource
            // 
            this.nganhHocBindingSource.DataMember = "NganhHoc";
            this.nganhHocBindingSource.DataSource = this.qlsinhvienhunreDataSet1;
            // 
            // qlsinhvienhunreDataSet1
            // 
            this.qlsinhvienhunreDataSet1.DataSetName = "qlsinhvienhunreDataSet1";
            this.qlsinhvienhunreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // qlsinhvienhunreDataSetBindingSource
            // 
            this.qlsinhvienhunreDataSetBindingSource.DataSource = this.qlsinhvienhunreDataSet;
            this.qlsinhvienhunreDataSetBindingSource.Position = 0;
            // 
            // nganhHocTableAdapter
            // 
            this.nganhHocTableAdapter.ClearBeforeFill = true;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // maSinhVienDataGridViewTextBoxColumn
            // 
            this.maSinhVienDataGridViewTextBoxColumn.DataPropertyName = "maSinhVien";
            this.maSinhVienDataGridViewTextBoxColumn.HeaderText = "maSinhVien";
            this.maSinhVienDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.maSinhVienDataGridViewTextBoxColumn.Name = "maSinhVienDataGridViewTextBoxColumn";
            this.maSinhVienDataGridViewTextBoxColumn.Width = 200;
            // 
            // hoSinhVienDataGridViewTextBoxColumn
            // 
            this.hoSinhVienDataGridViewTextBoxColumn.DataPropertyName = "hoSinhVien";
            this.hoSinhVienDataGridViewTextBoxColumn.HeaderText = "hoSinhVien";
            this.hoSinhVienDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.hoSinhVienDataGridViewTextBoxColumn.Name = "hoSinhVienDataGridViewTextBoxColumn";
            this.hoSinhVienDataGridViewTextBoxColumn.Width = 200;
            // 
            // tenSinhVienDataGridViewTextBoxColumn
            // 
            this.tenSinhVienDataGridViewTextBoxColumn.DataPropertyName = "tenSinhVien";
            this.tenSinhVienDataGridViewTextBoxColumn.HeaderText = "tenSinhVien";
            this.tenSinhVienDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tenSinhVienDataGridViewTextBoxColumn.Name = "tenSinhVienDataGridViewTextBoxColumn";
            this.tenSinhVienDataGridViewTextBoxColumn.Width = 200;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 200;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "gioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "gioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 200;
            // 
            // namNhapHocDataGridViewTextBoxColumn
            // 
            this.namNhapHocDataGridViewTextBoxColumn.DataPropertyName = "namNhapHoc";
            this.namNhapHocDataGridViewTextBoxColumn.HeaderText = "namNhapHoc";
            this.namNhapHocDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.namNhapHocDataGridViewTextBoxColumn.Name = "namNhapHocDataGridViewTextBoxColumn";
            this.namNhapHocDataGridViewTextBoxColumn.Width = 200;
            // 
            // maNganhHocDataGridViewTextBoxColumn
            // 
            this.maNganhHocDataGridViewTextBoxColumn.DataPropertyName = "maLop";
            this.maNganhHocDataGridViewTextBoxColumn.HeaderText = "maLop";
            this.maNganhHocDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.maNganhHocDataGridViewTextBoxColumn.Name = "maNganhHocDataGridViewTextBoxColumn";
            this.maNganhHocDataGridViewTextBoxColumn.Width = 200;
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 442);
            this.Controls.Add(this.dataGridViewSinhVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SinhVien";
            this.Text = "Sinh Viên";
            this.Load += new System.EventHandler(this.SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienhunreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienhunreDataSet2)).EndInit();
            this.panelGioiTinh.ResumeLayout(false);
            this.panelGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nganhHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienhunreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsinhvienhunreDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxHo;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.TextBox textBoxNamNhapHoc;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.Panel panelGioiTinh;
        private qlsinhvienhunreDataSet qlsinhvienhunreDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private qlsinhvienhunreDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxNganhHoc;
        private System.Windows.Forms.BindingSource qlsinhvienhunreDataSetBindingSource;
        private qlsinhvienhunreDataSet1 qlsinhvienhunreDataSet1;
        private System.Windows.Forms.BindingSource nganhHocBindingSource;
        private qlsinhvienhunreDataSet1TableAdapters.NganhHocTableAdapter nganhHocTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private qlsinhvienhunreDataSet2 qlsinhvienhunreDataSet2;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private qlsinhvienhunreDataSet2TableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namNhapHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNganhHocDataGridViewTextBoxColumn;
    }
}

