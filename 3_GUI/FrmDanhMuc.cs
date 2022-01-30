using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL.Models;
using _2_BUS.iBUSServices;
using _2_BUS.BUSServices;
using _2_BUS.Utilities;

namespace _3_GUI
{
    public partial class FrmDanhMuc : Form
    {
        private iQLMenuService _iQLMenuService;
        private MonAnChiTiet _monCT;
        private DonVi _donVi;
        private DanhMucFood _dmFood;
        private CachCheBien _cachCB;
        private ThucDon _item;
        private Utilities _utilities;
        FrmQuanLyThucDon frm = new FrmQuanLyThucDon();
        public FrmDanhMuc()
        {
            InitializeComponent();
            _iQLMenuService = new QLMenuService();
            FrmQuanLyThucDon_Load();
        }
        private void FrmQuanLyThucDon_Load()
        {
            
            dgvDanhMuc.ColumnCount = 3;
            dgvDanhMuc.Columns[0].Name = "Mã danh mục";
            dgvDanhMuc.Columns["Mã danh mục"].Visible = false;
            dgvDanhMuc.Columns[0].Width = 100;
            dgvDanhMuc.Columns[1].Name = "Tên danh mục";
            dgvDanhMuc.Columns[2].Name = "Trạng thái";
            dgvDanhMuc.Rows.Clear();
            foreach (var x in _iQLMenuService.GetDanhMucFoods())
            {
                dgvDanhMuc.Rows.Add(x.Id, x.Name, x.Status == true ? "Hoạt động" : "Không hoạt động");
            }
            
            this.dgvDanhMuc.ClearSelection();
            frm.FrmQuanLyThucDon_Load();
            frm.LoadCBox();
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thêm?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (checkNullCat())
                {
                    _dmFood = new DanhMucFood();
                    _dmFood.Id = _iQLMenuService.GetDanhMucFoods().Count;
                    _dmFood.Name = txtTenDanhMuc.Text;
                    if (rbtn_HDdanhmuc.Checked)
                    {
                        _dmFood.Status = true;
                    }
                    else
                    {
                        _dmFood.Status = false;
                    }
                    _iQLMenuService.AddCategory(_dmFood);
                    FrmQuanLyThucDon_Load();
                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin");
                }
            }
            else
            {
                return;
            }
        }
        private bool checkNullCat()
        {
            if (txtTenDanhMuc.Text is null || (!rbtn_HDdanhmuc.Checked && !rbtn_KHDdanhmuc.Checked))
            {
                return false;
            }
            return true;
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index == _iQLMenuService.GetDanhMucFoods().Count || index == -1)
            {
                txtMaDanhMuc.Text = null;
                txtTenDanhMuc.Text = null;
                rbtn_KHDdanhmuc.Checked = false;
                rbtn_HDdanhmuc.Checked = false;
            }
            else
            {
                int ID = (int)dgvDanhMuc.Rows[index].Cells[0].Value;
                _dmFood = _iQLMenuService.GetDanhMucFoods().Where(c => c.Id == ID).FirstOrDefault();
                txtMaDanhMuc.Text = _dmFood.Id.ToString();
                txtTenDanhMuc.Text = _dmFood.Name;
                if (_dmFood.Status == true)
                {
                    rbtn_HDdanhmuc.Checked = true;
                }
                else
                {
                    rbtn_KHDdanhmuc.Checked = true;
                }
            }
        }

        private void btnSuaNhom_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (_monCT is null)
                {
                    MessageBox.Show("Chọn danh mục muốn sửa");
                }
                else if (!checkNullCat())
                {
                    MessageBox.Show("Nhập đủ thông tin");
                }
                else
                {
                    _dmFood.Name = txtTenDanhMuc.Text;
                    if (rbtn_KHDdanhmuc.Checked)
                    {
                        _dmFood.Status = false;
                    }
                    else
                    {
                        _dmFood.Status = true;
                    }
                    _iQLMenuService.UpdateCategory(_dmFood);
                    FrmQuanLyThucDon_Load();
                }
            }
        }
        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (_dmFood != null)
                {
                    _dmFood.Status = false;
                    _iQLMenuService.UpdateCategory(_dmFood);
                    FrmQuanLyThucDon_Load();

                }
                else
                {
                    MessageBox.Show("Chọn danh mục để xóa");
                }
            }
        }

        private void txtTimkiemDM_TextChanged(object sender, EventArgs e)
        {
            dgvDanhMuc.ColumnCount = 3;
            dgvDanhMuc.Columns[0].Name = "Mã danh mục";
            dgvDanhMuc.Columns[0].Width = 100;
            dgvDanhMuc.Columns[1].Name = "Tên danh mục";
            dgvDanhMuc.Columns[2].Name = "Trạng thái";
            foreach (var x in _iQLMenuService.TimKiem(txtTimkiemDM.Text))
            {
                dgvDanhMuc.Rows.Add(x.cat.Id, x.cat.Name, x.cat.Status == true ? "Hoạt động" : "Không hoạt động");
            }
        }
    }
}
