using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using _2_BUS.iBUSServices;
using _2_BUS.BUSServices;
using _1_DAL.Models;

namespace _3_GUI
{
    public partial class FrmQuenMatKhau : Form
    {
        private IQuenMatKhau QMK = new QuenMatKhau();
        private IQLNhanVienService nv = new QLNhanVienService();
        int _TimeNow, _Time;
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        NhanVien _NhanVien;
        private string mess = "Thông báo";
        private string _pass;
        private string _code;

        private int flag;
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
            label2.Visible = false;
            Txt_XacNhan.Visible = false;
            btn_XacNhan.Visible = false;
        }
        //Hàm có nhiệm vụ lấy tham số truyền vào

        private void GetMessage(string Message)
        {
            txt_Email.Text = Message;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            _TimeNow = DateTime.Now.Minute;

            if (_TimeNow - _Time > 1)
            {
                MessageBox.Show("Đã quá thời gian 1 phút  mã code đã vô hiệu hóa");
                MessageBox.Show("Quên mật khẩu thất bại","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                

            }
            else if (flag == 3)
            {
                MessageBox.Show("Đã quá 3 lần xác nhân mã code đã vô hiệu hóa !");
                MessageBox.Show("Quên mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
              

            }
            else if (Txt_XacNhan.Text == _code)
            {
                _NhanVien = new NhanVien();
                _NhanVien = nv.getlstNhanViens().FirstOrDefault(c => c.Email == txt_Email.Text);
                _NhanVien.Password = _pass;
                nv.Update(_NhanVien);
                nv.Save();
            
                DialogResult result = MessageBox.Show("Quên mật khẩu thành công ,bạn có muốn đăng nhập luôn không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes) 
                {
                    this.Close();
               
                }
                 
                txt_Email.Enabled = true;
                txt_Email.Text = string.Empty;               
                Txt_XacNhan.Visible = false;
                btn_XacNhan.Visible = false;
                label2.Visible = false;
                btn_SendtoEmail.Visible = true;
                
             
            }
            else if(Txt_XacNhan.Text == "")
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {
                flag += 1;
                MessageBox.Show("Mã code không hợp lệ, nhập lại", mess);
            }
        }

        private void btn_SendtoEmail_Click(object sender, EventArgs e)
        {
            vadidatefrom();
            if (btn_SendtoEmail.Text == "Gửi")
            {
                flag = 0;
                txt_Email.Enabled = false;
                if (nv.getlstNhanViens().Any(c => c.Email == txt_Email.Text) == false)
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống", mess);
                    txt_Email.Enabled = true;
                    return;
                }
                else
                {
                    var sendPassCode = QMK.SenderMail(txt_Email.Text);
                    if (sendPassCode == null)
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                    else
                    {
                        _pass = sendPassCode.pass;
                        _code = sendPassCode.code;

                    
                        MessageBox.Show("Mã Code đã được gửi vào email", mess);
                        _Time = DateTime.Now.Minute;
                        Txt_XacNhan.Visible = true;
                        btn_XacNhan.Visible = true;
                        label2.Visible = true;
                        btn_SendtoEmail.Visible = false;
                    }
                }
            }

            else if (btn_SendtoEmail.Text == "Xác nhận")
            {
                _TimeNow = DateTime.Now.Minute;

                if (_TimeNow - _Time > 1)
                {
                    MessageBox.Show("Đã quá thời gian 1 phút .\n Mã code đã vô hiệu hóa");

                }
                else if (flag == 3)
                {
                    MessageBox.Show("Đã quá 3 lần xác nhân .\n Mã code đã vô hiệu hóa");
            

                }
                else if (Txt_XacNhan.Text == _code)
                {
                    MessageBox.Show("Quên mật khẩu thành công ", "Thông báo");
                    _NhanVien = new NhanVien();
                    _NhanVien = QMK.nhanViens(txt_Email.Text);
                    _NhanVien.Password = _pass;
                    _NhanVien.Status = false;
                    MessageBox.Show(QMK.UpdatePass(_NhanVien), mess);
                    this.Close();
                 
                }
                else
                {
                    flag += 1;
                    MessageBox.Show("Mã code không hợp lệ", mess);
                }
            }
        }

   

      

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng quên mật khẩu?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        bool vadidatefrom()
        {
            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                MessageBox.Show("Không được để trống email ");
                return false;
            }
          
            return true;
        }

       

      







    }
}
