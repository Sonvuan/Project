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
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=qlsinhvienhunre;User ID=sa;Password=Password789");
        

        private void hienthi()
        {
            try
            {
                cnn.Open();
                string sql = "select * from SinhVien where maSinhVien > 0";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewSinhVien.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
            }
        }
       

        private void SinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlsinhvienhunreDataSet.SinhVien' table. You can move, or remove it, as needed.
/*            this.sinhVienTableAdapter.Fill(this.qlsinhvienhunreDataSet.SinhVien);*/
            hienthi();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string query = "INSERT INTO qlsinhvienhunre.dbo.SinhVien (maSinhVien, hoSinhVien, tenSinhVien, ngaySinh, gioiTinh, namNhapHoc, maNganhHoc) VALUES(N'@idSV', N'@hoSV', N'@tenSV', '@ngaySinh', N'@gioiTinh', @namNhapHoc, N'@idNganh');";
            using(SqlCommand com = new SqlCommand(query, cnn))
            {
                com.Parameters.AddWithValue("@idSV", textBoxID.Text);
                com.Parameters.AddWithValue("@hoSV", textBoxHo.Text);
                com.Parameters.AddWithValue("@tenSV", textBoxTen.Text);
                com.Parameters.AddWithValue("@ngaySinh", dateTimePickerNgaySinh.Text);
                RadioButton gtcheck = null;
                foreach (RadioButton gt in panelGioiTinh.Controls)
                {
                    if (gt.Checked)
                    {
                        gtcheck = gt;
                        break;
                    }
                }
                com.Parameters.AddWithValue("@gioiTinh", dateTimePickerNgaySinh.Text);

            }
        }
    }
}
