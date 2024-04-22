using quanlisinhvienHUNRE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienHunre
{
    public partial class MenuADMIN : Form
    {
        private Form currentFormChild;

        public MenuADMIN()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            childForm.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy sự kiện đóng form
            }
        }

        private void btGiangVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GiangVienForm());
        }

        private void buttonLopHocPhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopHocPhanForm());
        }

        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TaiKhoanNguoiDung());
        }

        private void btSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVienForm());
        }

        private void btMonHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MonHocForm());
        }

        private void btNganhHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NganhHocForm());
        }

        private void btLopHocPhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopHocPhanForm());
        }

        private void btLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopForm());
        }

    }
}
