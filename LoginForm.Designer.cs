namespace QLSinhVienHunre
{
    partial class LoginForm
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // dangnhap_button
            // 
            this.dangnhap_button.Location = new System.Drawing.Point(58, 161);
            this.dangnhap_button.Margin = new System.Windows.Forms.Padding(2);
            this.dangnhap_button.Name = "dangnhap_button";
            this.dangnhap_button.Size = new System.Drawing.Size(76, 27);
            this.dangnhap_button.TabIndex = 3;
            this.dangnhap_button.Text = "Đăng nhập";
            this.dangnhap_button.UseVisualStyleBackColor = true;
            this.dangnhap_button.Click += new System.EventHandler(this.dangnhap_button_Click);
            // 
            // quenmk_button
            // 
            this.quenmk_button.Location = new System.Drawing.Point(193, 161);
            this.quenmk_button.Margin = new System.Windows.Forms.Padding(2);
            this.quenmk_button.Name = "quenmk_button";
            this.quenmk_button.Size = new System.Drawing.Size(94, 27);
            this.quenmk_button.TabIndex = 4;
            this.quenmk_button.Text = "Quên mật khẩu";
            this.quenmk_button.UseVisualStyleBackColor = true;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(112, 82);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(154, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(112, 120);
            this.tbPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(154, 20);
            this.tbPassWord.TabIndex = 2;
            this.tbPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 234);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.quenmk_button);
            this.Controls.Add(this.dangnhap_button);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dangnhap_button;
        private System.Windows.Forms.Button quenmk_button;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}