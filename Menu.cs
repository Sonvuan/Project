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
    public partial class Menu : Form
    {
        Diem diem = new Diem();
        Khoa khoa = new Khoa();
        LopHoc lop = new LopHoc();
        MonHoc mon = new MonHoc();
        SinhVien sinhVien = new SinhVien();
        private Form currentFormChild;

        public Menu()
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

        private void buttonSinhVien_Click(object sender, EventArgs e)
        {
           OpenChildForm(new SinhVien());
        }

        private void buttonMonHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MonHoc());
        }

        private void buttonKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Khoa());
        }

        private void buttonLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopHoc());
        }

        private void buttonDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Diem());
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy sự kiện đóng form
            }
        }
    }
}
