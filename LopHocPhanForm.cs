using QLSinhVienHunre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlisinhvienHUNRE
{
    public partial class LopHocPhanForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public LopHocPhanForm()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
        }
        #region methods

        void AddBinding()
        {
            if (dGVLopHP.DataSource == null) return;
            else
            {
                tbMaHP.DataBindings.Add("Text", dGVLopHP.DataSource, "maLopHocPhan", true, DataSourceUpdateMode.Never);
                tbNamHoc.DataBindings.Add("Text", dGVLopHP.DataSource, "namHoc", true, DataSourceUpdateMode.Never);
                tbMoTa.DataBindings.Add("Text", dGVLopHP.DataSource, "moTa", true, DataSourceUpdateMode.Never);
                tbGioiHSV.DataBindings.Add("Text", dGVLopHP.DataSource, "gioiHanSinhVien", true, DataSourceUpdateMode.Never);
                tbHocKy.DataBindings.Add("Text", dGVLopHP.DataSource, "hocKy", true, DataSourceUpdateMode.Never);
                cbTenGV.DataBindings.Add("Text", dGVLopHP.DataSource, "hotenGiangVien", true, DataSourceUpdateMode.Never);
                cbTenMH.DataBindings.Add("Text", dGVLopHP.DataSource, "tenMonHoc", true, DataSourceUpdateMode.Never);

            }
        }
        int SelectIdLopHocPhan(String maLopHocPhan)
        {
            int lopHocPhan = db.LopHocPhan.Where(p => p.maLopHocPhan == maLopHocPhan).Select(p => p.idLopHocPhan).SingleOrDefault();
            return lopHocPhan;
        }
        int SelectIdMonHoc(String cbMonHoc)
        {
            int monHoc = db.MonHoc.Where(p => p.maMonHoc == cbMonHoc || p.tenMonHoc == cbMonHoc).Select(p => p.idMonHoc).SingleOrDefault();
            return monHoc;
        }
        int SelectIdGiangVien(String cbGiangVien)
        {
            int giangVien = db.GiangVien.Where(p => p.maGiangVien == cbGiangVien || p.hotenGiangVien == cbGiangVien).Select(p => p.idGiangVien).SingleOrDefault();
            return giangVien;
        }
        void ClearBinding()
        {
            tbMaHP.DataBindings.Clear();
            tbNamHoc.DataBindings.Clear();
            tbMoTa.DataBindings.Clear();
            tbGioiHSV.DataBindings.Clear();
            tbHocKy.DataBindings.Clear();
            cbTenMH.DataBindings.Clear();
            cbTenGV.DataBindings.Clear();

        }


        void LoadData()
        {
            var result = from c in db.LopHocPhan
                         where c.idLopHocPhan > -1
                         select new
                         {
                             maLopHocPhan = c.maLopHocPhan,
                             namHoc = c.namHoc,
                             moTa = c.moTa,
                             hocKy = c.hocKy,
                             tenMonHoc = c.MonHoc.tenMonHoc,
                             gioiHanSinhVien = c.gioiHanSinhVien,
                             hotenGiangVien = c.GiangVien.hotenGiangVien,
                          
                         };
            dGVLopHP.DataSource = /*db.SinhVien.OrderBy(p => p.idSinhsVien).Skip(1).*/result.ToList();
            cbTenGV.DataSource = db.GiangVien.Select(p => p.hotenGiangVien).ToList();
            cbTenMH.DataSource = db.MonHoc.Select(p=>p.tenMonHoc).ToList();

        }
        void AddData()
        {
            int idgv = SelectIdGiangVien(cbTenGV.SelectedValue.ToString());
            int idmh = SelectIdMonHoc(cbTenMH.SelectedValue.ToString());
            LopHocPhan lopHocPhan = new LopHocPhan()
            {
                namHoc = Convert.ToInt32(tbNamHoc.Text),
                moTa = tbMoTa.Text,
                hocKy = Convert.ToInt32(tbHocKy.Text),
                gioiHanSinhVien = Convert.ToInt32(tbGioiHSV.Text),
                idGiangVien = idgv,
                idMonHoc = idmh                
            };

            try
            {
                db.LopHocPhan.Add(lopHocPhan);
                db.SaveChanges();

                LopHocPhan lopHocPhanUpdate = db.LopHocPhan.Find(lopHocPhan.idLopHocPhan);
                lopHocPhanUpdate.maLopHocPhan =lopHocPhan.namHoc + lopHocPhan.MonHoc.maMonHoc;
                db.SaveChanges();

                MessageBox.Show("Thêm Lớp Học Phần Thành Công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Lớp Học Phần thất bại! Lỗi: " + ex.Message);
            }
        }

        void EditData(String maLopHocPhan)
        {
            int idlhp = SelectIdLopHocPhan(maLopHocPhan);
            int idgv = SelectIdGiangVien(cbTenGV.SelectedValue.ToString());
            int idmh = SelectIdMonHoc(cbTenMH.SelectedValue.ToString());

            LopHocPhan lopHocPhan = db.LopHocPhan.Find(idlhp);

            if (lopHocPhan != null)
            {
              
                lopHocPhan.moTa = tbMoTa.Text;
                lopHocPhan.hocKy = Convert.ToInt32(tbHocKy.Text);
                lopHocPhan.namHoc = Convert.ToInt32(tbNamHoc.Text);
                lopHocPhan.gioiHanSinhVien = Convert.ToInt32(tbGioiHSV.Text);
                lopHocPhan.idMonHoc = idmh;
                lopHocPhan.idGiangVien = idgv;
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sửa thông tin Lớp Học Phần thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thông tin môn học thất bại! Lỗi: " + ex.Message);
                }
            };
        }
        void DeleteData(String maLopHocPhan)
        {
            try
            {
                int idlhp = SelectIdMonHoc(maLopHocPhan);
                LopHocPhan lopHocPhan = db.LopHocPhan.Where(p => p.idLopHocPhan == idlhp).SingleOrDefault();
                
                db.LopHocPhan.Remove(lopHocPhan);
                db.SaveChanges();
                MessageBox.Show("Xóa lớp học phần thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa lớp học phần thất bại! Lỗi: " + ex.Message);
            }
        }

        void ResetData()
        {
            tbMaHP.Clear();
            tbMoTa.Clear();
            tbGioiHSV.Clear();
            tbMoTa.Clear();
        }
    #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditData(tbMaHP.Text.ToString());
            LoadData();
            ClearBinding();
            AddBinding();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
            LoadData();
            ClearBinding() ;
            AddBinding();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData(tbMaHP.Text.ToString());
            LoadData();
            ClearBinding();
            AddBinding();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void btThamGiaHocPhan_Click(object sender, EventArgs e)
        {
            ThamGiaHocPhanForm thamGiaHocPhanForm = new ThamGiaHocPhanForm();
            thamGiaHocPhanForm.ShowDialog();
        }
    }
}
