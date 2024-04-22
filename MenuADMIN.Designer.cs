namespace QLSinhVienHunre
{
    partial class MenuADMIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLop = new System.Windows.Forms.Button();
            this.btGiangVien = new System.Windows.Forms.Button();
            this.btTaiKhoan = new System.Windows.Forms.Button();
            this.btLopHocPhan = new System.Windows.Forms.Button();
            this.btNganhHoc = new System.Windows.Forms.Button();
            this.btMonHoc = new System.Windows.Forms.Button();
            this.btSinhVien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btLop);
            this.groupBox1.Controls.Add(this.btGiangVien);
            this.groupBox1.Controls.Add(this.btTaiKhoan);
            this.groupBox1.Controls.Add(this.btLopHocPhan);
            this.groupBox1.Controls.Add(this.btNganhHoc);
            this.groupBox1.Controls.Add(this.btMonHoc);
            this.groupBox1.Controls.Add(this.btSinhVien);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(16, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(118, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btLop
            // 
            this.btLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btLop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLop.Location = new System.Drawing.Point(14, 99);
            this.btLop.Margin = new System.Windows.Forms.Padding(2);
            this.btLop.Name = "btLop";
            this.btLop.Size = new System.Drawing.Size(88, 23);
            this.btLop.TabIndex = 7;
            this.btLop.Text = "Lớp";
            this.btLop.UseVisualStyleBackColor = true;
            this.btLop.Click += new System.EventHandler(this.btLop_Click);
            // 
            // btGiangVien
            // 
            this.btGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btGiangVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGiangVien.Location = new System.Drawing.Point(14, 72);
            this.btGiangVien.Margin = new System.Windows.Forms.Padding(2);
            this.btGiangVien.Name = "btGiangVien";
            this.btGiangVien.Size = new System.Drawing.Size(88, 23);
            this.btGiangVien.TabIndex = 6;
            this.btGiangVien.Text = "Giảng viên";
            this.btGiangVien.UseVisualStyleBackColor = true;
            this.btGiangVien.Click += new System.EventHandler(this.btGiangVien_Click);
            // 
            // btTaiKhoan
            // 
            this.btTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTaiKhoan.Location = new System.Drawing.Point(14, 18);
            this.btTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btTaiKhoan.Name = "btTaiKhoan";
            this.btTaiKhoan.Size = new System.Drawing.Size(88, 23);
            this.btTaiKhoan.TabIndex = 5;
            this.btTaiKhoan.Text = "Tài khoản";
            this.btTaiKhoan.UseVisualStyleBackColor = true;
            this.btTaiKhoan.Click += new System.EventHandler(this.btTaiKhoan_Click);
            // 
            // btLopHocPhan
            // 
            this.btLopHocPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btLopHocPhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLopHocPhan.Location = new System.Drawing.Point(14, 180);
            this.btLopHocPhan.Margin = new System.Windows.Forms.Padding(2);
            this.btLopHocPhan.Name = "btLopHocPhan";
            this.btLopHocPhan.Size = new System.Drawing.Size(88, 23);
            this.btLopHocPhan.TabIndex = 3;
            this.btLopHocPhan.Text = "Lớp học phần";
            this.btLopHocPhan.UseVisualStyleBackColor = true;
            this.btLopHocPhan.Click += new System.EventHandler(this.btLopHocPhan_Click);
            // 
            // btNganhHoc
            // 
            this.btNganhHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btNganhHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNganhHoc.Location = new System.Drawing.Point(14, 153);
            this.btNganhHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btNganhHoc.Name = "btNganhHoc";
            this.btNganhHoc.Size = new System.Drawing.Size(88, 23);
            this.btNganhHoc.TabIndex = 2;
            this.btNganhHoc.Text = "Ngành học";
            this.btNganhHoc.UseVisualStyleBackColor = true;
            this.btNganhHoc.Click += new System.EventHandler(this.btNganhHoc_Click);
            // 
            // btMonHoc
            // 
            this.btMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMonHoc.Location = new System.Drawing.Point(14, 126);
            this.btMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btMonHoc.Name = "btMonHoc";
            this.btMonHoc.Size = new System.Drawing.Size(88, 23);
            this.btMonHoc.TabIndex = 1;
            this.btMonHoc.Text = "Môn học";
            this.btMonHoc.UseVisualStyleBackColor = true;
            this.btMonHoc.Click += new System.EventHandler(this.btMonHoc_Click);
            // 
            // btSinhVien
            // 
            this.btSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSinhVien.Location = new System.Drawing.Point(14, 45);
            this.btSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.btSinhVien.Name = "btSinhVien";
            this.btSinhVien.Size = new System.Drawing.Size(88, 23);
            this.btSinhVien.TabIndex = 0;
            this.btSinhVien.Text = "Sinh viên";
            this.btSinhVien.UseVisualStyleBackColor = true;
            this.btSinhVien.Click += new System.EventHandler(this.btSinhVien_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.buttonDangXuat);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 366);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox2.Location = new System.Drawing.Point(2, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(148, 84);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonThoat.Location = new System.Drawing.Point(97, 327);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(49, 32);
            this.buttonThoat.TabIndex = 3;
            this.buttonThoat.Text = "THOÁT";
            this.buttonThoat.UseVisualStyleBackColor = true;
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDangXuat.Location = new System.Drawing.Point(9, 327);
            this.buttonDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(49, 32);
            this.buttonDangXuat.TabIndex = 2;
            this.buttonDangXuat.Text = "ĐĂNG XUẤT";
            this.buttonDangXuat.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 81);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(150, 81);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 284);
            this.panel3.TabIndex = 6;
            // 
            // MenuADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(802, 366);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuADMIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btLopHocPhan;
        private System.Windows.Forms.Button btNganhHoc;
        private System.Windows.Forms.Button btMonHoc;
        private System.Windows.Forms.Button btSinhVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonDangXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btTaiKhoan;
        private System.Windows.Forms.Button btGiangVien;
        private System.Windows.Forms.Button btLop;
    }
}

