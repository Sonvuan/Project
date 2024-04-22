using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienHunre
{
    public partial class SinhVienForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public SinhVienForm()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
        }
        #region methods

        void LoadData()
        {
            cbLop.DataSource = db.Lop.Select(p => p.maLop).ToList();
            LoadDGV();
        }
        void LoadDGV()
        {
            var result = from c in db.SinhVien
                         where c.idSinhVien > 0 && c.Lop.maLop == cbLop.SelectedValue
                         select new
                         {
                             maSinhVien = c.maSinhVien,
                             hotenSinhVien = c.hotenSinhVien,
                             maLop = c.Lop.maLop,
                             ngaySinh = c.ngaySinh,
                             gioiTinh = c.gioiTinh,
                             namNhapHoc = c.namNhapHoc,

                         };
            dGVSinhVien.DataSource = result.ToList();
        }

        void AddBinding()
        {
            if (dGVSinhVien.DataSource == null) return;
            else
            {
                tbMaSV.DataBindings.Add("Text", dGVSinhVien.DataSource, "maSinhVien",true,DataSourceUpdateMode.Never);
                tbHoTen.DataBindings.Add("Text", dGVSinhVien.DataSource, "hotenSinhVien", true, DataSourceUpdateMode.Never);
                tbNamNhapHoc.DataBindings.Add("Text", dGVSinhVien.DataSource, "namNhapHoc", true, DataSourceUpdateMode.Never);
                cbLop.DataBindings.Add("Text", dGVSinhVien.DataSource, "maLop", true, DataSourceUpdateMode.Never);
                foreach (RadioButton radioButton in panelGioiTinh.Controls)
                {
                    radioButton.Checked = false;
                }
            }            
        }
        void ClearBinding()
        {
            tbMaSV.DataBindings.Clear();
            tbHoTen.DataBindings.Clear();
            dTPNgaySinh.DataBindings.Clear();
            tbNamNhapHoc.DataBindings.Clear();
            cbLop.DataBindings.Clear();
        }

        SinhVien SelectData (String maSinhVien)
        {
            SinhVien sinhVien = db.SinhVien.Where(p => p.maSinhVien == maSinhVien).SingleOrDefault();
            return sinhVien;
        }

        void AddData()
        {
            string selectedValue = null;

            // Lặp qua tất cả các control trong Panel
            foreach (RadioButton radioButton in panelGioiTinh.Controls)
            {
                // Kiểm tra nếu control là RadioButton
                if (radioButton.Checked)
                {
                    // Lấy giá trị của RadioButton được chọn
                    selectedValue = radioButton.Text;
                    break; // Thoát khỏi vòng lặp sau khi đã tìm thấy RadioButton được chọn

                }
            }
            Lop lop = db.Lop.Where(p => p.maLop == cbLop.SelectedValue).SingleOrDefault();
            SinhVien sinhVien = new SinhVien()
            {
                hotenSinhVien = tbHoTen.Text,
                ngaySinh = dTPNgaySinh.Value.Date,
                gioiTinh = selectedValue,
                namNhapHoc = Convert.ToInt32(tbNamNhapHoc.Text),
                idLop = Convert.ToInt32(lop.idLop),
            };

            try
            {   
                db.SinhVien.Add(sinhVien);
                db.SaveChanges();

                SinhVien sinhVienUpdate = db.SinhVien.Find(sinhVien.idSinhVien);
                sinhVienUpdate.maSinhVien = ("SV" + sinhVien.idSinhVien).ToString();
                db.SaveChanges();

                AddAcc(sinhVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm sinh viên thất bại! Lỗi: " + ex.Message);
            }
        }

        void AddAcc(SinhVien sinhVien)
        {
            NguoiDung nguoiDung = new NguoiDung()
            {
                idSinhVien = sinhVien.idSinhVien,
                matKhau = sinhVien.idSinhVien + sinhVien.maSinhVien,
                chucVu = "SV"
            };
            db.NguoiDung.Add(nguoiDung);
            db.SaveChanges();
            MessageBox.Show("Thêm sinh viên và người dùng thành công!");
        }

        void EditData(String maSinhVien)
        {
            SinhVien sinhVien = db.SinhVien.Find(SelectData(maSinhVien).idSinhVien);
            if (sinhVien != null)
            {
                string selectedValue = null;
                foreach (RadioButton radioButton in panelGioiTinh.Controls)
                {
                    if (radioButton.Checked)
                    {
                        selectedValue = radioButton.Text;
                        break;
                    }
                }

                sinhVien.hotenSinhVien = tbHoTen.Text;
                sinhVien.ngaySinh = dTPNgaySinh.Value.Date;
                sinhVien.gioiTinh = selectedValue.ToString();
                sinhVien.namNhapHoc = Convert.ToInt32(tbNamNhapHoc.Text);
                sinhVien.idLop = Convert.ToInt32(cbLop.SelectedIndex);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sửa thông tin sinh viên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thông tin sinh viên thất bại! Lỗi: " + ex.Message);
                }
            };
        }

        void DeleteData(String maSinhVien)
        {
            SinhVien sinhVien = db.SinhVien.Where(p => p.maSinhVien == maSinhVien).SingleOrDefault();
            NguoiDung nguoiDung = db.NguoiDung.Where(p => p.idSinhVien == sinhVien.idSinhVien).SingleOrDefault();
            try
            {
                db.NguoiDung.Remove(nguoiDung);
                db.SinhVien.Remove(sinhVien);
                db.SaveChanges();
                MessageBox.Show("Xóa sinh viên và người dùng thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa sinh viên thất bại! Lỗi: " + ex.Message);
            }
        }

        void ResetData()
        {
            tbMaSV.Clear();
            tbHoTen.Clear();
            dTPNgaySinh.Text= "";
            tbNamNhapHoc.Clear();
        }
        #endregion

        #region event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
            LoadData();
            ClearBinding();
            AddBinding();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaSV.Text))
            {
                DeleteData(tbMaSV.Text);
                LoadData();
                ClearBinding();
                AddBinding();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaSV.Text))
            {
                EditData(tbMaSV.Text);
                LoadData();
                ClearBinding();
                AddBinding();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để chỉnh sửa!");
            }
        }

        private void cbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dGVSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding();
        }
        #endregion
    }
}
        
