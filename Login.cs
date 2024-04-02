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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=localhost;Initial Catalog=quanly_sinhvien;User ID=sa;Password=Password789";
        private void dangnhap_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();

                // Câu lệnh SQL tìm kiếm
                string sql = "SELECT count(*) FROM accuser WHERE username = @user AND userpassword = @pass";

                try
                {
                    // Mở kết nối
                    connection.Open();
                    // Gán giá trị cho tham số @user
                    command.Parameters.AddWithValue("@user", username_textbox.Text);
                    command.Parameters.AddWithValue("@pass", password_textbox.Text);
                    // Thi hành truy vấn tìm kiếm và nhận kết quả vào một DataTable
                    command.CommandText = sql;
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                        username_textbox.Clear();
                        password_textbox.Clear();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
