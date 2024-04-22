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
    public partial class LopForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public LopForm()
        {
            InitializeComponent();
            LoadData();
        }
        #region methods
        void LoadData()
        {
            cbMaNganh.DataSource = db.NganhHoc.Select(p => p.maNganhHoc).ToList();
            LoadDGVLop();
            LoadDGVGV();
        }
        void LoadDGVLop()
        {
            var result = from c in db.Lop
                         where c.NganhHoc.maNganhHoc == cbMaNganh.SelectedValue 
                         select new
                         {
                             maLop = c.maLop,
                             maNganhHoc = c.NganhHoc.maNganhHoc,
                             tenNganhHoc = c.NganhHoc.tenNganhHoc,
                             maGiangVien = c.GiangVien.maGiangVien,
                             hotenGiangVien = c.GiangVien.hotenGiangVien
                         };
            dGVLop.DataSource = result.ToList();       
        }
        void LoadDGVGV()
        {
            var result = from c in db.GiangVien
                         select new
                         {
                             maGiangVien = c.maGiangVien,
                             hotenGiangVien = c.hotenGiangVien,
                             ngaySinh = c.ngaySinh
                         };
            dGVGiangVien.DataSource = result.ToList();
        }
        void AddBinding(object dGV)
        {
            if (dGV == dGVLop.DataSource)
            {
                tbMaLop.DataBindings.Add("Text", dGV, "maLop", true, DataSourceUpdateMode.Never);
            }
            tbMaGiangVien.DataBindings.Add("Text", dGV, "maGiangVien", true, DataSourceUpdateMode.Never);
        }
        void ClearBinding()
        {
            tbMaLop.DataBindings.Clear();
            tbMaGiangVien.DataBindings.Clear();
        }

        int SelectIdNganh()
        {
            if(cbMaNganh.SelectedValue != null)
            {
                int result = db.NganhHoc.Where(p => p.maNganhHoc == cbMaNganh.SelectedValue).Select(p => p.idNganhHoc).SingleOrDefault();
                return result;
            }
            else { return -1; }
        }

        int SelectIdGiangVien()
        {
            if(tbMaGiangVien.Text != null)
            {
                int result = db.GiangVien.Where(p => p.maGiangVien == tbMaGiangVien.Text).Select(p => p.idGiangVien).SingleOrDefault();
                return result;
            }
            else { return -1; }

        }

        int SelectIdLop()
        {
            if(tbMaLop.Text != null)
            {
                int result = db.Lop.Where(p => p.maLop == tbMaLop.Text).Select(p => p.idLop).SingleOrDefault();
                return result;
            }else { return -1; }

        }
        void AddData()
        {
            try 
            {
                Lop lop = new Lop()
                {
                    idNganhHoc = SelectIdNganh(),
                    idGiangVien = SelectIdGiangVien()
                };
                db.Lop.Add(lop);
                db.SaveChanges();

                Lop lopUpdate = db.Lop.Find(lop.idLop);
                lopUpdate.maLop = cbMaNganh.SelectedValue.ToString() + lopUpdate.idLop;
                db.SaveChanges();
                MessageBox.Show("Thêm lớp thành công.");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                MessageBox.Show("Lỗi khi thêm lớp: " + ex.Message);
            }

        }
        void EditData()
        {
            try
            {
                Lop lop = db.Lop.Find(SelectIdLop());
                lop.idGiangVien = SelectIdGiangVien();
                lop.idNganhHoc = SelectIdNganh();
                db.SaveChanges();
                MessageBox.Show("Sửa thông tin lớp thành công.");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                MessageBox.Show("Lỗi khi thêm lớp: " + ex.Message);
            }

        }

        void DeleteData()
        {
            try
            {
                if (!db.SinhVien.Any(p => p.idLop == SelectIdLop()))
                {
                    Lop lopDel = db.Lop.Find(SelectIdLop());
                    db.Lop.Remove(lopDel);
                    db.SaveChanges();
                    MessageBox.Show("Xóa lớp thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể xóa lớp có sinh viên");
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                MessageBox.Show("Lỗi khi thêm lớp: " + ex.Message);
            }
        }

        void ResetData()
        {
            tbMaGiangVien.Clear();
            tbMaLop.Clear();
        }
        #endregion
        #region event
        private void btAdd_Click(object sender, EventArgs e)
        {
            AddData();
            LoadDGVLop();
            ClearBinding();
            ResetData();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EditData();
            LoadDGVLop();
            ClearBinding();
            ResetData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadDGVLop();
            ClearBinding();
            ResetData();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ClearBinding();
            ResetData();
        }

        private void cbMaNganh_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGVLop();
        }

        private void dGVGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding(dGVGiangVien.DataSource);
        }

        private void dGVLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            ClearBinding();
            AddBinding(dGVLop.DataSource);
        }
        #endregion
    }
}
