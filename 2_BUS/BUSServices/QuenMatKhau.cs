﻿
using _1_DAL.Models;
using _2_BUS.iBUSServices;
using _2_BUS_BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.BUSServices
{
    public class QuenMatKhau:IQuenMatKhau
    {
        private QLNhanVienService nv1;
        private PassCode _sendPassCode;
        private List<NhanVien> _lstNhanViens;

        private string _email;
        private string _pass;
        private string _code;
        
        public QuenMatKhau()
        {
            nv1 = new QLNhanVienService();
            _lstNhanViens = new List<NhanVien>();
            _lstNhanViens = nv1.getlstNhanViens();
        }
        public string PassRandom(int lengthCode)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";//String char for random password
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, lengthCode)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }
        public string MaHoaPass(string password)
        {
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public PassCode SenderMail(string mail)
        {

            _pass = PassRandom(6);
            _code = PassRandom(6);
            SmtpClient client = new SmtpClient("smtp.gmail.com",25);
            NetworkCredential cred = new NetworkCredential("phonglvph16158@fpt.edu.vn", "p01248460961");
            MailMessage mgs = new MailMessage();
            mgs.From = new MailAddress("phonglvph16158@fpt.edu.vn");
            mgs.To.Add(mail);
            mgs.Subject = "Quên mật khẩu";
            mgs.Body = "Mật khẩu mới là: " + _pass + "\nMã xác nhận của bạn là :" + _code + "\n Mã sẽ vô hiệu lực sau 1 phút";
            client.Credentials = cred;
            client.EnableSsl = true;
            client.Send(mgs);
            _sendPassCode = new PassCode(_pass, _code);
            return _sendPassCode;

        }
        public NhanVien nhanViens(string email)
        {

            return _lstNhanViens.Where(c => c.Email == email).FirstOrDefault();

        }
        public string UpdatePass(NhanVien nv)
        {
            nv1.getlstNhanViens();
            nv1.Update(nv);
            nv1.Save();
            return "Mật khẩu đã được đổi thành công";

        }
    }
}
