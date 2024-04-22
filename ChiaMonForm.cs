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
    public partial class ChiaMonForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public ChiaMonForm()
        {
            InitializeComponent();
            LoadData();
        }
        #region methods
        void LoadData()
        {
            cbMaNganh.DataSource = db.NganhHoc.Select(p => p.maNganhHoc).ToList();
            LoadDGV();
        }
        void LoadDGV()
        {
            var result = from c in db.PhanChiaMonHoc
                         where c.NganhHoc.maNganhHoc == cbMaNganh.SelectedValue
                         select new
                         {
                             maMonHoc = c.MonHoc.maMonHoc,
                             tenMonHoc = c.MonHoc.tenMonHoc,
                             soTinChi = c.MonHoc.soTinChi,
                             quyDinh = c.MonHoc.quyDinh,
                             tenHinhThucDanhGia = c.MonHoc.HinhThuc.tenHinhThucDanhGia
                         };
            dGVNganhHoc.DataSource = result.ToList();
            NganhHoc selectID = db.NganhHoc.Where(p => p.maNganhHoc == cbMaNganh.SelectedValue).SingleOrDefault();

            var result2 = from c in db.MonHoc
                         where !db.PhanChiaMonHoc.Any(p => p.idMonHoc == c.idMonHoc && p.idNganhHoc == selectID.idNganhHoc)
                         select new
                         {
                             maMonHoc = c.maMonHoc,
                             tenMonHoc = c.tenMonHoc,
                             soTinChi = c.soTinChi,
                             quyDinh = c.quyDinh,
                             tenHinhThucDanhGia = c.HinhThuc.tenHinhThucDanhGia
                         };
            dGVMonHoc.DataSource = result2.ToList();
        }
        void AddBinding(object dGV)
        {
            tbMaMon.DataBindings.Add("Text",dGV, "maMonHoc",true,DataSourceUpdateMode.Never);
        }

        void ClearBinding()
        {
            tbMaMon.DataBindings.Clear();
        }

        void AddData()
        {

            if (SelectIdNganh() > 0 && SelectIdMon() > 0 )
            {
                if (!db.PhanChiaMonHoc.Any(p => p.idMonHoc == SelectIdMon() && p.idNganhHoc == SelectIdNganh()))
                {
                    PhanChiaMonHoc phanChiaMonHoc = new PhanChiaMonHoc()
                    {
                        idNganhHoc = SelectIdNganh(),
                        idMonHoc = SelectIdMon()
                    };
                    db.PhanChiaMonHoc.Add(phanChiaMonHoc);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Môn học " + tbMaMon.Text + " đã có trong ngành " + cbMaNganh.SelectedValue.ToString());
                }
            }
            else
            {
                MessageBox.Show("Không thể thêm dữ liệu vì dữ liệu ngành hoặc môn học không tồn tại.");
            }
        }

        void DeleteData()
        {

            if (SelectIdMon() > 0 && SelectIdMon() > 0)
            {
                PhanChiaMonHoc phanChiaMonHoc = db.PhanChiaMonHoc.FirstOrDefault(p => p.idMonHoc == SelectIdMon()&& p.idNganhHoc == SelectIdNganh());
                if (phanChiaMonHoc != null)
                {
                    db.PhanChiaMonHoc.Remove(phanChiaMonHoc);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Môn học " + tbMaMon.Text + " không có trong ngành " + cbMaNganh.SelectedValue.ToString());
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa dữ liệu vì dữ liệu ngành hoặc môn học không tồn tại.");
            }
        }


        int SelectIdNganh ()
        {
            if(cbMaNganh.SelectedValue != null)
            {
                int nganhHoc = db.NganhHoc.Where(p => p.maNganhHoc == cbMaNganh.SelectedValue).Select(p => p.idNganhHoc).SingleOrDefault();
                return nganhHoc;
            }
            else { return -1; } 

        }

        int SelectIdMon()
        {
            if(tbMaMon.Text != null)
            {
                int monHoc = db.MonHoc.Where(p => p.maMonHoc == tbMaMon.Text).Select(p => p.idMonHoc).SingleOrDefault();
                return monHoc;
            }
            else { return -1; }

        }

        void UpdateData()
        {
            int sum = 0;

            foreach(var item in db.PhanChiaMonHoc.Where(p => p.idNganhHoc == SelectIdNganh()).Select(p => p.MonHoc.soTinChi).ToList()){
                sum += Convert.ToInt32(item);
            }
            NganhHoc nganhHoc = db.NganhHoc.Find(SelectIdMon());
            nganhHoc.soTinChi = sum;
            db.SaveChanges();

            MessageBox.Show("Đã cập nhật số tín chỉ cảu ngành" + cbMaNganh.SelectedValue.ToString());
        }

        #endregion

        #region event
        private void cbMaNganh_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            AddData();
            LoadDGV();
            ClearBinding();
        }

        private void dGVMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding(dGVMonHoc.DataSource);
        }

        private void dGVNganhHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearBinding();
            AddBinding(dGVNganhHoc.DataSource);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadData();
        }

        private void btCapNhatTC_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        #endregion
    }
}
