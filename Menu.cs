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
        Login login = new Login();
        
        public Menu()
        {
            InitializeComponent();
            login.ShowDialog();
        }

        private void mon_hoc_button_Click(object sender, EventArgs e)
        {
            mon.Show();
        }

        private void sinh_vien_button_Click(object sender, EventArgs e)
        {
            sinhVien.Show();
        }

        private void lop_button_Click(object sender, EventArgs e)
        {
            lop.Show();
        }

        private void diem_button_Click(object sender, EventArgs e)
        {
            diem.Show();
        }

        private void khoa_button_Click(object sender, EventArgs e)
        {
            khoa.Show();
        }
    }
}
