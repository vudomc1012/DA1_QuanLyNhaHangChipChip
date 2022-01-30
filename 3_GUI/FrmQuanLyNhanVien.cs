using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL.Context;
using _1_DAL.Models;
using _2_BUS.BUSServices;
using _2_BUS.Utilities;

namespace _3_GUI
{
    public partial class FrmQuanLyNhanVien : Form
    {
        private IQLNhanVienService _iQlNhanVienService = new QLNhanVienService();
        private DatabaseContext _dbconContext;
        private Utilities _utilities;
        private int _id;
        private NhanVien nv;
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            loadData();
            _utilities = new Utilities();
            dgrid_NhanVien.Columns["MANV"].Visible = false;
            rbtnHDnhanvien.Checked = true;
           
          

        }
        void loadData()
        {
            _iQlNhanVienService.getlstNhanViens();
            dgrid_NhanVien.ColumnCount = 10;
            dgrid_NhanVien.Columns[0].Name = "Id";
            dgrid_NhanVien.Columns[1].Name = "Tên nhân viên";
            dgrid_NhanVien.Columns[2].Name = "Email";
            dgrid_NhanVien.Columns[3].Name = "Mật khẩu";
            dgrid_NhanVien.Columns[4].Name = "Vai trò";
            dgrid_NhanVien.Columns[5].Name = "Số điện thoại";
            dgrid_NhanVien.Columns[6].Name = "Giới tính";
            dgrid_NhanVien.Columns[7].Name = "Địa chỉ";
            dgrid_NhanVien.Columns[8].Name = "Trạng thái";
            dgrid_NhanVien.Columns[9].Name = "MANV";
            dgrid_NhanVien.Rows.Clear();
            foreach (var x in _iQlNhanVienService.getlstNhanViens())
            {
                dgrid_NhanVien.Rows.Add(x.Id, x.Name, x.Email, x.Password, x.Role == 1 ? "Quản lí" : x.Role == 2 ? "Nhân viên":"",
                    x.PhoneNo, x.Sex == true ? "Nam" : "Nữ", x.Address, x.Status == true ? "Hoạt động" : "Không hoạt động", x.MaNv);
            }
        }


        private void btnThemNV_Click(object sender, EventArgs e)
        {

            if (validate())
            {
                NhanVien NhanVien = new NhanVien();
            NhanVien.Id = dgrid_NhanVien.Rows.Cast<DataGridViewRow>()
                .Max(r => Convert.ToInt32(r.Cells["Id"].Value)) + 1;
            NhanVien.MaNv = "NV" + NhanVien.Id;
            NhanVien.Name = txt_TenNV.Text;
            NhanVien.Email = txtEmail.Text;
            NhanVien.Address = txt_DiaChiNV.Text;
            NhanVien.PhoneNo = txt_SDT.Text;
            NhanVien.Sex = Convert.ToBoolean(chk_nam.Checked ? true : false);
            NhanVien.Status = Convert.ToBoolean(rbtnHDnhanvien.Checked ? true : false);
            NhanVien.Password = _utilities.GetHash("123");
            NhanVien.Role = chk_quanLi.Checked ? 1 : 2;
            if ((MessageBox.Show("Bạn muốn thêm một nhân viên ?",
                "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                _iQlNhanVienService.Add(NhanVien);
                MessageBox.Show("Thêm thành công", "Thông báo");
                loadData();
            }
            }
        }

        private bool validate()
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match mat = regex.Match(txtEmail.Text);
            if (txt_TenNV.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Tên không được nhập số","Thông báo");
                return false;
            } else if (txt_SDT.Text.Any(char.IsLetter))
            {
                MessageBox.Show("SĐT không để chữ","Thông báo");
                return false;
            } else if(txt_SDT.Text.Length < 10 || txt_SDT.Text.Length > 11)
            {
                MessageBox.Show("SĐT không đúng độ dài", "Thông báo");
                return false;
            } else if (!mat.Success)
            {
                MessageBox.Show("Email không đúng dạng","Thông báo");
                return false;
            } else if(txtEmail.Text == null || txt_SDT.Text == null || txt_TenNV.Text == null || txtEmail.Text == "" || txt_SDT.Text == "" || txt_TenNV.Text == "")
            {
                MessageBox.Show("Thông tin không để trống", "Thông báo");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if(nv != null)
            {
                rbtnKHDnhanvien.Checked = true;
                //nhanVien.Role = 1;
                if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                    "Thông báo !!!!!!!!!!!!!!!",
                    MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    nv.Status = false;
                    _iQlNhanVienService.Update(nv);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo");
            }
        }
       
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if(nv != null)
            {
                if (validate())
                {
                    var nhanVien = _iQlNhanVienService.getlstNhanViens().Where(c => c.MaNv == txtMaNV.Text).FirstOrDefault();
                    nhanVien.Name = txt_TenNV.Text;
                    nhanVien.Email = txtEmail.Text;
                   
                    nhanVien.Role = chk_quanLi.Checked ? 1 : 2;
                    nhanVien.Address = txt_DiaChiNV.Text;
                    nhanVien.PhoneNo = txt_SDT.Text;
                    nhanVien.Sex = chk_nam.Checked ? true : false;
                    nhanVien.Status = (bool)(rbtnHDnhanvien.Checked ? true : false);
                    if ((MessageBox.Show("Bạn có chắc chắc sẽ dùng chức năng trên?",
                        "Thông báo !",
                        MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        _iQlNhanVienService.Update(nhanVien);
                    }
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo");
            }

        }

        private void chk_quanLi_CheckedChanged_1(object sender, EventArgs e)
        {
            //chk_nhanVien.Checked = !chk_quanLi.Checked;
        }



        private void chk_nhanVien_CheckedChanged(object sender, EventArgs e)
        {
            //chk_quanLi.Checked = !chk_nhanVien.Checked;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Bạn muốn lưu ?",
                       "Thông báo",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes))
                {
                    _iQlNhanVienService.Save();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Chức năng lỗi rồi :(. Liên hệ nhóm để sửa", "Thông báo");
            }
            
        }
        
        private void txt_TenNV_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_TenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên của bạn.");
                return;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email của bạn.");
                return;
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_TenNV.ResetText();
            txtEmail.ResetText();
            txt_SDT.ResetText();
            txt_DiaChiNV.ResetText();
            txtMatKhau.ResetText();
        }

        private void dgrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if(rowindex == _iQlNhanVienService.getlstNhanViens().Count || rowindex < 0)
            {
                txt_TenNV.ResetText();
                txtEmail.ResetText();
                txt_SDT.ResetText();
                txt_DiaChiNV.ResetText();
                txtMatKhau.ResetText();
                chk_nam.Checked = false;
                chk_nhanVien.Checked = false;
                chk_nu.Checked = false;
                chk_quanLi.Checked = false;
            } else
            {
                _id = Convert.ToInt32(dgrid_NhanVien.Rows[rowindex].Cells[0].Value.ToString());
                txt_TenNV.Text = dgrid_NhanVien.Rows[rowindex].Cells[1].Value.ToString();
                txtEmail.Text = dgrid_NhanVien.Rows[rowindex].Cells[2].Value.ToString();
                txtMatKhau.Text = _utilities.GetHash(dgrid_NhanVien.Rows[rowindex].Cells[3].Value.ToString());
                //if (dgrid_NhanVien.Rows[rowindex].Cells[4].Value.ToString() == "Nhân Viên")
                //{
                //    chk_quanLi.Checked = false;
                //}
                //else
                //{
                //    chk_nhanVien.Checked = false;
                //}
                txt_SDT.Text = dgrid_NhanVien.Rows[rowindex].Cells[5].Value.ToString();
                chk_nam.Checked = dgrid_NhanVien.Rows[rowindex].Cells[6].Value.ToString() == "Nam" ? true : false;
                chk_nu.Checked = dgrid_NhanVien.Rows[rowindex].Cells[6].Value.ToString() == "Nữ" ? true : false;
                txt_DiaChiNV.Text = dgrid_NhanVien.Rows[rowindex].Cells[7].Value.ToString();
                rbtnHDnhanvien.Checked = dgrid_NhanVien.Rows[rowindex].Cells[8].Value.ToString() == "Hoạt động" ? true : false;
                rbtnKHDnhanvien.Checked = dgrid_NhanVien.Rows[rowindex].Cells[8].Value.ToString() == "Không Hoạt động" ? true : false;
                txtMaNV.Text = dgrid_NhanVien.Rows[rowindex].Cells[9].Value.ToString();
                nv = _iQlNhanVienService.getlstNhanViens().Where(c => c.MaNv == txtMaNV.Text).FirstOrDefault();

                if (nv.Status == true)
                {
                    rbtnHDnhanvien.Checked = true;
                }
                else
                {
                    rbtnKHDnhanvien.Checked = true;
                }
                if (nv.Role == 1)
                {
                    chk_quanLi.Checked = true;
                    chk_nhanVien.Checked = false;
                }
                else
                {
                    chk_nhanVien.Checked = true;
                    chk_quanLi.Checked = false;
                }
            }
        }

        private void chk_quanLi_Click(object sender, EventArgs e)
        {
            if (chk_nhanVien.Checked)
            {
                chk_nhanVien.Checked = false;
            }
        }

        private void chk_nhanVien_Click(object sender, EventArgs e)
        {
            if (chk_quanLi.Checked)
            {
                chk_quanLi.Checked = false;
            }
        }

        private void chk_nam_Click(object sender, EventArgs e)
        {
            if (chk_nu.Checked)
            {
                chk_nu.Checked = false;
            }
        }

        private void chk_nu_Click(object sender, EventArgs e)
        {
            if (chk_nam.Checked)
            {
                chk_nam.Checked = false;
            }
        }

       
    }
}
