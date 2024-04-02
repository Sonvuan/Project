namespace QLSinhVienHunre
{
    partial class Menu
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
            this.thoat_button = new System.Windows.Forms.Button();
            this.dang_xuat_button = new System.Windows.Forms.Button();
            this.sinh_vien_button = new System.Windows.Forms.Button();
            this.mon_hoc_button = new System.Windows.Forms.Button();
            this.lop_button = new System.Windows.Forms.Button();
            this.diem_button = new System.Windows.Forms.Button();
            this.khoa_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // thoat_button
            // 
            this.thoat_button.Location = new System.Drawing.Point(414, 417);
            this.thoat_button.Name = "thoat_button";
            this.thoat_button.Size = new System.Drawing.Size(141, 47);
            this.thoat_button.TabIndex = 1;
            this.thoat_button.Text = "Thoát";
            this.thoat_button.UseVisualStyleBackColor = true;
            // 
            // dang_xuat_button
            // 
            this.dang_xuat_button.Location = new System.Drawing.Point(181, 417);
            this.dang_xuat_button.Name = "dang_xuat_button";
            this.dang_xuat_button.Size = new System.Drawing.Size(141, 47);
            this.dang_xuat_button.TabIndex = 2;
            this.dang_xuat_button.Text = "Đăng xuất";
            this.dang_xuat_button.UseVisualStyleBackColor = true;
            // 
            // sinh_vien_button
            // 
            this.sinh_vien_button.Location = new System.Drawing.Point(229, 147);
            this.sinh_vien_button.Name = "sinh_vien_button";
            this.sinh_vien_button.Size = new System.Drawing.Size(288, 45);
            this.sinh_vien_button.TabIndex = 3;
            this.sinh_vien_button.Text = "Sinh viên";
            this.sinh_vien_button.UseVisualStyleBackColor = true;
            this.sinh_vien_button.Click += new System.EventHandler(this.sinh_vien_button_Click);
            // 
            // mon_hoc_button
            // 
            this.mon_hoc_button.Location = new System.Drawing.Point(229, 198);
            this.mon_hoc_button.Name = "mon_hoc_button";
            this.mon_hoc_button.Size = new System.Drawing.Size(288, 45);
            this.mon_hoc_button.TabIndex = 4;
            this.mon_hoc_button.Text = "Môn học";
            this.mon_hoc_button.UseVisualStyleBackColor = true;
            this.mon_hoc_button.Click += new System.EventHandler(this.mon_hoc_button_Click);
            // 
            // lop_button
            // 
            this.lop_button.Location = new System.Drawing.Point(229, 249);
            this.lop_button.Name = "lop_button";
            this.lop_button.Size = new System.Drawing.Size(288, 45);
            this.lop_button.TabIndex = 5;
            this.lop_button.Text = "Lớp";
            this.lop_button.UseVisualStyleBackColor = true;
            this.lop_button.Click += new System.EventHandler(this.lop_button_Click);
            // 
            // diem_button
            // 
            this.diem_button.Location = new System.Drawing.Point(229, 300);
            this.diem_button.Name = "diem_button";
            this.diem_button.Size = new System.Drawing.Size(288, 45);
            this.diem_button.TabIndex = 6;
            this.diem_button.Text = "Điểm";
            this.diem_button.UseVisualStyleBackColor = true;
            this.diem_button.Click += new System.EventHandler(this.diem_button_Click);
            // 
            // khoa_button
            // 
            this.khoa_button.Location = new System.Drawing.Point(229, 351);
            this.khoa_button.Name = "khoa_button";
            this.khoa_button.Size = new System.Drawing.Size(288, 45);
            this.khoa_button.TabIndex = 7;
            this.khoa_button.Text = "Khoa";
            this.khoa_button.UseVisualStyleBackColor = true;
            this.khoa_button.Click += new System.EventHandler(this.khoa_button_Click);
            // 
            // MenuQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 547);
            this.Controls.Add(this.khoa_button);
            this.Controls.Add(this.diem_button);
            this.Controls.Add(this.lop_button);
            this.Controls.Add(this.mon_hoc_button);
            this.Controls.Add(this.sinh_vien_button);
            this.Controls.Add(this.dang_xuat_button);
            this.Controls.Add(this.thoat_button);
            this.Controls.Add(this.label1);
            this.Name = "MenuQL";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thoat_button;
        private System.Windows.Forms.Button dang_xuat_button;
        private System.Windows.Forms.Button sinh_vien_button;
        private System.Windows.Forms.Button mon_hoc_button;
        private System.Windows.Forms.Button lop_button;
        private System.Windows.Forms.Button diem_button;
        private System.Windows.Forms.Button khoa_button;
    }
}

