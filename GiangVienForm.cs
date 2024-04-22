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
    public partial class GiangVienForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public GiangVienForm()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
        }

        #region methods
        void LoadData()
        {
            var result = from c in db.GiangVien
                         where c.idGiangVien > 0
                         select new
                         {
                             maGiangVien = c.maGiangVien,
                             hotenGiangVien = c.hotenGiangVien,
                             ngaySinh = c.ngaySinh,
                             gioiTinh = c.gioiTinh
                         };
            dGVGiangVien.DataSource = /*db.SinhVien.OrderBy(p => p.idSinhVien).Skip(1).*/result.ToList();
        }
        void AddBinding()
        {
            if (dGVGiangVien.DataSource == null) return;
            else
            {
                tbMaGV.DataBindings.Add("Text", dGVGiangVien.DataSource, "maGiangVien", true, DataSourceUpdateMode.Never);
                tbHoTen.DataBindings.Add("Text", dGVGiangVien.DataSource, "hotenGiangVien", true, DataSourceUpdateMode.Never);
            }
        }
        void ClearBinding()
        {
            tbMaGV.DataBindings.Clear();
            tbHoTen.DataBindings.Clear();
            dTPNgaySinh.DataBindings.Clear();
        }
        void AddAcc(GiangVien giangVien)
        {
            NguoiDung nguoiDung = new NguoiDung()
            {
                idGiangVien = giangVien.idGiangVien,
                matKhau = giangVien.idGiangVien + giangVien.maGiangVien,
                chucVu = "GV"
            };
            db.NguoiDung.Add(nguoiDung);
            db.SaveChanges();
            MessageBox.Show("Thêm giảng viên và người dùng thành công!");
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
            GiangVien giangVien = new GiangVien()
            {
                hotenGiangVien = tbHoTen.Text,
                ngaySinh = dTPNgaySinh.Value.Date,
                gioiTinh = selectedValue.ToString()
            };

            try
            {
                db.GiangVien.Add(giangVien);
                db.SaveChanges();

                GiangVien giangVienUpdate = db.GiangVien.Find(giangVien.idGiangVien);
                giangVienUpdate.maGiangVien = ("GV" + giangVien.idGiangVien).ToString();
                db.SaveChanges();

                AddAcc(giangVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm giảng viên thất bại! Lỗi: " + ex.Message);
            }
        }

        GiangVien SelectData(String maGiangVien)
        {
            GiangVien giangVien = db.GiangVien.Where(p => p.maGiangVien == maGiangVien).SingleOrDefault();
            return giangVien;
        }

        void EditData(String maGiangVien)
        {
            GiangVien giangVien = db.GiangVien.Find(SelectData(maGiangVien).idGiangVien);
            if (giangVien != null)
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

                giangVien.hotenGiangVien = tbHoTen.Text;
                giangVien.ngaySinh = dTPNgaySinh.Value.Date;
                giangVien.gioiTinh = selectedValue.ToString();
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sửa thông tin giảng viên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thông tin giảng viên thất bại! Lỗi: " + ex.Message);
                }
            };
        }

        void DeleteData(String maGiangVien)
        {
            GiangVien giangVien = db.GiangVien.Where(p => p.maGiangVien == maGiangVien).SingleOrDefault();
            NguoiDung nguoiDung = db.NguoiDung.Where(p => p.idGiangVien == giangVien.idGiangVien).SingleOrDefault();
            try
            {
                db.NguoiDung.Remove(nguoiDung);
                db.GiangVien.Remove(giangVien);
                db.SaveChanges();
                MessageBox.Show("Xóa giảng viên và người dùng thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa giảng viên thất bại! Lỗi: " + ex.Message);
            }
        }

        void ResetData ()
        {
            tbMaGV.Clear();
            tbHoTen.Clear();
            dTPNgaySinh.Text = "";
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

        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaGV.Text))
            {
                EditData(tbMaGV.Text);
                LoadData();
                ClearBinding();
                AddBinding();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để chỉnh sửa!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaGV.Text))
            {
                DeleteData(tbMaGV.Text);
                LoadData();
                ClearBinding();
                AddBinding();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetData();
        }
    }
}
