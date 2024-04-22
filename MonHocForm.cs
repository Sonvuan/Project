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
    public partial class MonHocForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public MonHocForm()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
        }
       
        void AddBinding()
        {
            if (dGVSinhVien.DataSource == null) return;
            else
            {
                tbMaMH.DataBindings.Add("Text", dGVSinhVien.DataSource, "maMonHoc", true, DataSourceUpdateMode.Never);
                tbTenMH.DataBindings.Add("Text", dGVSinhVien.DataSource, "tenMonHoc", true, DataSourceUpdateMode.Never);
                tbSoTC.DataBindings.Add("Text", dGVSinhVien.DataSource, "soTinChi", true, DataSourceUpdateMode.Never);
                dTPNamBD.DataBindings.Add("Value", dGVSinhVien.DataSource, "namBatDau", true, DataSourceUpdateMode.Never);
                tbMoTaMH.DataBindings.Add("Text", dGVSinhVien.DataSource, "moTaMonHoc", true, DataSourceUpdateMode.Never);
            }
        }
        MonHoc SelectData(String maMonHoc)
        {
            MonHoc monHoc = db.MonHoc.Where(p => p.maMonHoc == maMonHoc).SingleOrDefault();
            return monHoc;
        }
        void ClearBinding()
        {
            tbMaMH.DataBindings.Clear();
            tbTenMH.DataBindings.Clear();
            dTPNamBD.DataBindings.Clear();
            tbSoTC.DataBindings.Clear();
            tbMoTaMH.DataBindings.Clear();
            foreach (RadioButton radioButton in panelQuyDnh.Controls)
            {
                    radioButton.Checked = false;
            }
            cbHTDG.DataBindings.Clear();
        }
        void LoadData()
        {
            var result = from c in db.MonHoc
                         where c.idMonHoc > 0
                         select new
                         {
                             maMonHoc = c.maMonHoc,
                             tenMonHoc = c.tenMonHoc,
                             soTinChi = c.soTinChi,
                             namBatDau = c.namBatDau,
                             quyDinh = c.quyDinh,
                             moTaMonHoc = c.moTaMonHoc,
                             hinhThucDanhGia=c.HinhThuc.hinhThucDanhGia
                         };
            dGVSinhVien.DataSource = result.ToList();
            cbHTDG.DataSource = db.HinhThuc.Select(p => p.tenHinhThucDanhGia).ToList();
        }
        void AddData()
        {
            string selectedValue = null;

            foreach (RadioButton radioButton in panelQuyDnh.Controls)
            {
                if (radioButton.Checked)
                {
                    selectedValue = radioButton.Text;
                    break;
                }
            }

            MonHoc monHoc = new MonHoc()
            {
                maMonHoc =new string(tbTenMH.Text.Where(char.IsUpper).ToArray()),
                tenMonHoc = tbTenMH.Text,
                soTinChi = Convert.ToInt32(tbSoTC.Text),
                namBatDau = dTPNamBD.Value.Year,
                quyDinh = selectedValue,
                moTaMonHoc = tbMoTaMH.Text,
                hinhThucDanhGia = db.HinhThuc.Where(p => p.tenHinhThucDanhGia == cbHTDG.SelectedValue).Select(p => p.hinhThucDanhGia).SingleOrDefault()
            };

            try
            {
                if (db.MonHoc.Where(p => p.maMonHoc == monHoc.maMonHoc).Any())
                {
                    MessageBox.Show("Mã môn học này đã tồn tại");
                    ResetData();
                }
                else
                {
                    db.MonHoc.Add(monHoc);
                    db.SaveChanges();

                    MessageBox.Show("Thêm Môn Học Thành Công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Môn Học thất bại! Lỗi: " + ex.Message);
            }
        }

        void EditData(String maMonHoc)
        {
            MonHoc monHoc = db.MonHoc.Find(SelectData(maMonHoc).idMonHoc);

            string selectedValue = null;

            foreach (RadioButton radioButton in panelQuyDnh.Controls)
            {
                if (radioButton.Checked)
                {
                    selectedValue = radioButton.Text;
                    break;
                }
            }

            if (monHoc != null)
            {
                monHoc.maMonHoc = new string(tbTenMH.Text.Where(char.IsUpper).ToArray());
                monHoc.tenMonHoc = tbTenMH.Text;
                monHoc.soTinChi = Convert.ToInt32(tbSoTC.Text);
                monHoc.namBatDau = dTPNamBD.Value.Year;
                monHoc.quyDinh = selectedValue;
                monHoc.moTaMonHoc = tbMoTaMH.Text;
                monHoc.hinhThucDanhGia = db.HinhThuc.Where(p => p.tenHinhThucDanhGia == cbHTDG.SelectedValue).Select(p => p.hinhThucDanhGia).SingleOrDefault();

                try
                {
                    if(db.MonHoc.Where(p => p.maMonHoc == monHoc.maMonHoc).Any())
                    {
                        MessageBox.Show("Mã môn học này đã tồn tại");
                        ResetData();
                    }
                    else
                    {
                       db.SaveChanges();
                       MessageBox.Show("Sửa thông tin môn học thành công!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thông tin môn học thất bại! Lỗi: " + ex.Message);
                }
            };
        }

        void DeleteData(String maMonHoc)
        {
            try
            {
                db.MonHoc.Remove(SelectData(maMonHoc));
                db.SaveChanges();
                MessageBox.Show("Xóa môn học thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa môn học thất bại! Lỗi: " + ex.Message);
            }
        }

        void ResetData()
        {
            tbMaMH.Clear();
            tbMoTaMH.Clear();
            dTPNamBD.Text = "";
            tbMoTaMH.Clear();
            tbSoTC.Clear();
            tbTenMH.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
            LoadData();
            ClearBinding();
            AddBinding();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditData(tbMaMH.Text.ToString());
            LoadData();
            ClearBinding();
            AddBinding();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData(tbMaMH.Text.ToString());
            LoadData();
            ClearBinding();
            AddBinding();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetData();
        }

    }
}