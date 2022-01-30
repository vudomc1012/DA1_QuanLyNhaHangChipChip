using _1_DAL.Models;
using _2_BUS.BUSServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
  
    public partial class FrmMain : Form
    {
        public int other = 1;
        private Button crreentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        string mnv;
        string ten;
        public string mail;
        IQLNhanVienService _qLNhanVienService;
        private NhanVien _nhanVien = new NhanVien();
        private int flag = 0;

        public FrmMain()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChillForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
       
        }
        public void SenderData(NhanVien nVien)
        {
            _nhanVien = nVien;
          
            checkRoles();
            if (flag == 1)
            {
                btnQuanLyNhanVien.Visible= true;
                btnQuanLyHoaDon.Visible = true;

            }
            else
            {

                btnQuanLyNhanVien .Visible= false;
                btnQuanLyHoaDon .Visible= false;
            }
        }
        void checkRoles()
        {
            if (_nhanVien.Role == 1)
            {
                flag = 1;
            }
            else
            {
                flag = 2;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
              index =   random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (crreentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    crreentButton = (Button)btnSender;
                    crreentButton.BackColor = color;
                    crreentButton.ForeColor = Color.White;
                    crreentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChillForm.Visible = true;
                }
            }
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            if (other == 1)
            {
                ActivateButton(btnSender); 
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                }
            }
        }

        public void btnPhucVu_Click(object sender, EventArgs e)
        {
            other = 1;
            FrmQLBan frmBan = new FrmQLBan(this);
            frmBan.getNhanVien(_nhanVien);
            frmBan.getFrmMain(this);
            OpenChildForm(frmBan, sender);
        }

        private void btnQuanLyThucDon_Click(object sender, EventArgs e)
        {
            other = 1;
            OpenChildForm(new FrmQuanLyThucDon(), sender);
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            other = 1;
            OpenChildForm(new FrmQuanLyHoaDon(), sender);
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            other = 1;
            OpenChildForm(new FrmQuanLyNhanVien(), sender);
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       
        private void Reset()
        {
            DisableButton();
            label1.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            crreentButton = null;
            btnCloseChillForm.Visible = false;
        }

        private void btnCloseChillForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {

                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                this.Close();
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            
            FrmDoiMatKhau a = new FrmDoiMatKhau();

          
            a.ShowDialog();
        }
      

        private void FrmMain_Load(object sender, EventArgs e)
        {
            labNgayGio.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblChao.Text = " Chào: " + mail;
            
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            labGio.Text = DateTime.Now.ToString("HH:mm");
        }
        public string manv(string MaNv, string Ten)//khi cần hiện mã nv đang đăng nhập gọi nó ra(xem nhân viên nào xuất hoá đơn)
        {
            mnv = MaNv;
            ten = Ten;
            return Ten;
        }

        
    }
}
