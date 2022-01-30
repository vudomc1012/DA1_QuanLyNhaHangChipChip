using _1_DAL.Models;
using _2_BUS.BUSServices;
using _2_BUS.iBUSServices;
using _2_BUS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class FrmDoiMatKhau : Form
    {
        private Utilities uti;
        private IQLNhanVienService _qlnv;
        private IQuenMatKhau QMK = new QuenMatKhau();
        private NhanVien _nv;
        public static string passcu;
        public static string mail;
        public static string mailmain;
        public FrmDoiMatKhau()
        {
            uti = new Utilities();
            _qlnv = new QLNhanVienService();
            InitializeComponent();
            _nv = new NhanVien();
        }


        public void SenderDataDMK(NhanVien nVien)
        {
            _nv = nVien;

            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            _nv = _qlnv.getlstNhanViens().Where(c => c.Email == mailmain).FirstOrDefault();
            try
            {
                validate();
              

                if (_nv.Password != uti.GetHash(txtPass.Text)  )
                {
                    MessageBox.Show("Mật khẩu cũ của bạn nhập không chính xác", "Thông báo");
                }
                else if (txtNewPass.Text != txtNewPass2.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu không chính xác", "Thông báo");
                }
                else
                {

                    _nv = _qlnv.getlstNhanViens().Where(c => c.Email == mail).FirstOrDefault();
                    _nv = QMK.nhanViens(mail);
                    _nv.Password = uti.GetHash(txtNewPass.Text);
                    MessageBox.Show(QMK.UpdatePass(_nv), "Thông báo", MessageBoxButtons.OK);
                    this.Close();

                }
            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
            
        }
        bool validate()
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Mật khẩu cũ không được để trống  ");
                return false;
            }
            if (string.IsNullOrEmpty(txtNewPass.Text))
            {
                MessageBox.Show("Mật khẩu mới không được để trống ");
                return false;
            }
            if (txtNewPass.TextLength < 5 && txtNewPass.TextLength <= 20)
            {
                MessageBox.Show("Độ dài mật khẩu phải từ 6 đến 20 kí tự");
                return false;
            }
            if (string.IsNullOrEmpty(txtNewPass2.Text))
            {
                MessageBox.Show("Không được để trống  ");
                return false;
            }
            return true;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
