using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienHunre
{
    public partial class LoginForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public LoginForm()
        {
            InitializeComponent();
        }
        #region methods
        void CheckAcc()
        {
            if (db.NguoiDung.Where(tk => tk.SinhVien.maSinhVien == tbUserName.Text && tk.matKhau == tbPassWord.Text).SingleOrDefault() != null)
            {
                /*                MessageBox.Show("Đăng nhập thành công");
                                // Nếu thông tin đăng nhập chính xác, đóng form đăng nhập và mở form menu chính
                                this.Hide();
                                MenuSV menuSV = new MenuSV();
                                menuSV.ShowDialog();
                                this.Close();*/
            }
            else if (db.NguoiDung.Where(tk => tk.GiangVien.maGiangVien == tbUserName.Text && tk.matKhau == tbPassWord.Text).SingleOrDefault() != null)
            {
                /*                MessageBox.Show("Đăng nhập thành công");
                                // Nếu thông tin đăng nhập chính xác, đóng form đăng nhập và mở form menu chính
                                this.Hide();
                                MenuGV menuGV = new MenuGV();
                                menuGV.ShowDialog();
                                this.Close();*/
            }
            else if (db.NguoiDung.Where(tk => tk.matKhau == tbPassWord.Text).SingleOrDefault() != null)
            {
                MessageBox.Show("Đăng nhập thành công");
                // Nếu thông tin đăng nhập chính xác, đóng form đăng nhập và mở form menu chính
                this.Hide();
                MenuADMIN menuADMIN = new MenuADMIN();
                menuADMIN.ShowDialog();
                this.Close();
            }
            else if (tbPassWord == null || tbUserName == null)
            {
                MessageBox.Show("Vui lòng điền điền đẩy đủ thông tin");
                tbUserName.Clear();
                tbPassWord.Clear();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                tbUserName.Clear();
                tbPassWord.Clear();
            }
        }

        #endregion

        #region event
        private void dangnhap_button_Click(object sender, EventArgs e)
        {
            CheckAcc();
        }
        #endregion
    }
}