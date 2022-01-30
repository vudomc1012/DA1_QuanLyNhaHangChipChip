using _1_DAL.Models;
using _2_BUS_BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.iBUSServices
{
    public interface IQuenMatKhau
    {
        public PassCode SenderMail(string mail);
        public NhanVien nhanViens(string email);
        public string UpdatePass(NhanVien nv);
    }
}
