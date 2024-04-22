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
    public partial class NganhHocForm : Form
    {
        qlsinhvienhunreEntities db = new qlsinhvienhunreEntities();
        public NganhHocForm()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
        }
        void AddBinding()
        {
            if (dTGNganhHoc.DataSource == null) return;
            else
            {
                tbMaNH.DataBindings.Add("Text", dTGNganhHoc.DataSource, "maNganhHoc", true, DataSourceUpdateMode.Never);
                tbTenNH.DataBindings.Add("Text", dTGNganhHoc.DataSource, "tenNganhHoc", true, DataSourceUpdateMode.Never);
             /*   tbSoTC.DataBindings.Add("Text", dTGNganhHoc.DataSource, "soTinChi", true, DataSourceUpdateMode.Never);*/
  

            }
        }
        void ClearBinding()
        {
            tbMaNH.DataBindings.Clear();
            tbTenNH.DataBindings.Clear();
         /*   tbSoTC.Clear();*/
           
        }

        NganhHoc SelectData(String maNganhHoc)
        {
            NganhHoc nganhHoc = db.NganhHoc.Where(p => p.maNganhHoc == maNganhHoc).SingleOrDefault();
            return nganhHoc;
        }
     
        void LoadData()
        {
            var result = from c in db.NganhHoc
                         where c.idNganhHoc > 0
                         select new
                         {
                             maNganhHoc = c.maNganhHoc,
                             tenNganhHoc = c.tenNganhHoc,
                             soTinChi = c.soTinChi,
                             namBatDau = c.namBatDau  ,
                         };
            dTGNganhHoc.DataSource = result.ToList();
        }
        void AddData()
        {
            NganhHoc nganhHoc = new NganhHoc()
            {
                maNganhHoc = new string(tbTenNH.Text.Where(char.IsUpper).ToArray()),
                tenNganhHoc = tbTenNH.Text,
                namBatDau = dTime.Value.Date.Year,

            };

            try
            {
                db.NganhHoc.Add(nganhHoc);
                db.SaveChanges();
                MessageBox.Show("Thêm ngành học thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm ngành học thất bại! Lỗi: " + ex.Message);
            }
        }

        void EditData(String maNganhHoc)
        {
            NganhHoc nganhHoc = db.NganhHoc.Find(SelectData(maNganhHoc).idNganhHoc);
          

                nganhHoc.tenNganhHoc = tbTenNH.Text;
       /*         nganhHoc.soTinChi = Convert.ToInt32(tbSoTC.Text);*/
                 nganhHoc.namBatDau = dTime.Value.Date.Year;
               
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sửa thông tin sinh viên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thông tin sinh viên thất bại! Lỗi: " + ex.Message);
                }
            
        }

        void DeleteData(String maNganhHoc)
        {
            try
            {
                db.NganhHoc.Remove(SelectData(maNganhHoc));
                db.SaveChanges();
                MessageBox.Show("Xóa Ngành Học thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Ngành Học thất bại! Lỗi: " + ex.Message);
            }
        }

        void ResetData()
        {
            tbMaNH.Clear();
            tbTenNH.Clear();
            dTime.Text = "";
           /* tbSoTC.Clear();*/
        }

        
        #region events
        private void button1_Click(object sender, EventArgs e)
        {
            AddData();
            LoadData();
            ClearBinding();
            AddBinding();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditData(tbMaNH.Text.ToString());
            LoadData();
            ClearBinding();
            AddBinding();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteData(tbMaNH.Text.ToString());
            LoadData();
            ClearBinding();
            AddBinding();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChiaMonForm chiaMonForm = new ChiaMonForm();
            chiaMonForm.ShowDialog();
            LoadData();
        }
        #endregion
    }
}
