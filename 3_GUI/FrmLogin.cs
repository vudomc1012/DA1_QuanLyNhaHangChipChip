using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _2_BUS.BUSServices;
using _1_DAL.Models;
using _2_BUS.iBUSServices;
using _2_BUS.Utilities;

namespace _3_GUI
{
    

    public partial class FrmLogin : Form
    {
        private Utilities uti;
        private IQLNhanVienService _qlnv;
        public NhanVien nhanVien;
        string userName = "";
        string passWord = "";
        public FrmLogin()
        {
            _qlnv = new QLNhanVienService();
            uti = new Utilities();
            InitializeComponent();
            nhanVien = new NhanVien();
        }

        
      
        private void FrmLogin_Load(object sender, EventArgs e)
        {

            if(Properties.Settings.Default.userName != null)
            {
                txtUsername.Text = Properties.Settings.Default.userName;
            }
           
            
            txtUsername.ForeColor = Color.Gray;

            txtPassWord.PasswordChar = '\0';
            txtPassWord.Text = "Password";
            txtPassWord.ForeColor = Color.Gray;

            bool capsLock = Console.CapsLock;
            if (capsLock == true)
                lblCapsLock.Text = "Bạn đang bật Capslock";
            else
                lblCapsLock.Text = "";

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
         
            txtUsername.ForeColor = Color.Black;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            userName = txtUsername.Text;
            if (userName.Equals("User Name"))
            {
                txtUsername.Text = "User Name";
                txtUsername.ForeColor = Color.Gray;
            }
            else
            {
                if (userName.Equals(""))
                {
                    txtUsername.Text = "User Name";
                    txtUsername.ForeColor = Color.Gray;
                }
                else
                {
                    txtUsername.Text = userName;
                    txtUsername.ForeColor = Color.Black;
                }
            }
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            txtPassWord.Text = "";
            txtPassWord.ForeColor = Color.Black;
            txtPassWord.PasswordChar = '*';

        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            passWord = txtPassWord.Text;
            if (passWord.Equals("Password"))
            {
                txtPassWord.Text = "Password";
                txtPassWord.ForeColor = Color.Gray;
            }
            else
            {
                if (passWord.Equals(""))
                {
                    txtPassWord.PasswordChar = '\0';
                    txtPassWord.Text = "Password";
                    txtPassWord.ForeColor = Color.Gray;
                }
                else
                {
                    txtPassWord.PasswordChar = '*';
                    txtPassWord.Text = passWord;
                    txtPassWord.ForeColor = Color.Black;
                }
            }
        }

      

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                this.txtUsername.Focus();
                this.txtUsername.Select(0, this.txtUsername.Text.Length);
            }
            if(e.KeyCode == Keys.CapsLock)
            {
                bool capsLock = Console.CapsLock;
                if (capsLock == true)
                    lblCapsLock.Text = "Bạn đang bật Capslock";
                else
                    lblCapsLock.Text = "";
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                this.txtPassWord.Focus();
                this.txtPassWord.Select(0, this.txtPassWord.Text.Length);
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                bool capsLock = Console.CapsLock;
                if (capsLock == true)
                    lblCapsLock.Text = "Bạn đang bật Capslock";
                else
                    lblCapsLock.Text = "";
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                bool capsLock = Console.CapsLock;
                if (capsLock == true)
                    lblCapsLock.Text = "Bạn đang bật Capslock";
                else
                    lblCapsLock.Text = "";
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            if (_qlnv.getlstNhanViens().Any(c=>c.Email==txtUsername.Text&& c.Password== uti.GetHash(txtPassWord.Text) && c.Status==true))
            {
               nhanVien= _qlnv.getlstNhanViens().FirstOrDefault(c => c.Email == txtUsername.Text && c.Password == uti.GetHash(txtPassWord.Text));
                MessageBox.Show("Đăng nhập thành công ", "Thông báo");
                if (txtPassWord.Text =="123")
                {
                    FrmDoiMatKhau.mail = txtUsername.Text;
                    FrmDoiMatKhau.mailmain = txtUsername.Text;
                    FrmDoiMatKhau.passcu = txtPassWord.Text;
                    MessageBox.Show("Bạn đang nhập mật khẩu mặc định ,vui lòng đổi mật khẩu giúp em","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FrmDoiMatKhau c = new FrmDoiMatKhau();
                    c.SenderDataDMK(nhanVien);
                    c.ShowDialog();
                   
                }
                FrmDoiMatKhau.mail = txtUsername.Text;
                FrmMain frmMain = new FrmMain();
                frmMain.mail = txtUsername.Text;
                frmMain.SenderData(nhanVien);
                FrmDoiMatKhau.mailmain = txtUsername.Text;
                FrmDoiMatKhau.passcu = txtPassWord.Text;
                FrmQLBan.mail= txtUsername.Text;
                FrmTachHoaDon._EmailTachHD = txtUsername.Text;
                if (chkSaveLogin.Checked)
                {
                    Properties.Settings.Default.userName = txtUsername.Text;
                    Properties.Settings.Default.Save();
                }
                this.Hide();
                frmMain.ShowDialog();
                this.Close();

            } else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo");
            }
        }

        private void linkQMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            FrmQuenMatKhau qmk = new FrmQuenMatKhau();
            qmk.ShowDialog();
            //this.Close();
            
           
           
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(linkLabel1,"Mật khẩu mặc định là 123");
        }

        private void chkSaveLogin_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }

}
