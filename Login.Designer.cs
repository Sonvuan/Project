namespace QLSinhVienHunre
{
    partial class Login
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
            this.dangnhap_button = new System.Windows.Forms.Button();
            this.quenmk_button = new System.Windows.Forms.Button();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // dangnhap_button
            // 
            this.dangnhap_button.Location = new System.Drawing.Point(117, 309);
            this.dangnhap_button.Name = "dangnhap_button";
            this.dangnhap_button.Size = new System.Drawing.Size(153, 52);
            this.dangnhap_button.TabIndex = 1;
            this.dangnhap_button.Text = "Đăng nhập";
            this.dangnhap_button.UseVisualStyleBackColor = true;
            this.dangnhap_button.Click += new System.EventHandler(this.dangnhap_button_Click);
            // 
            // quenmk_button
            // 
            this.quenmk_button.Location = new System.Drawing.Point(386, 309);
            this.quenmk_button.Name = "quenmk_button";
            this.quenmk_button.Size = new System.Drawing.Size(187, 52);
            this.quenmk_button.TabIndex = 2;
            this.quenmk_button.Text = "Quên mật khẩu";
            this.quenmk_button.UseVisualStyleBackColor = true;
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(225, 157);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(304, 31);
            this.username_textbox.TabIndex = 1;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(225, 230);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(304, 31);
            this.password_textbox.TabIndex = 4;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.quenmk_button);
            this.Controls.Add(this.dangnhap_button);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dangnhap_button;
        private System.Windows.Forms.Button quenmk_button;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}