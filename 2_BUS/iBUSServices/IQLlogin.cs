using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.iBUSServices
{
    public interface IQLlogin
    {
        public List<Role> GetlistRoleBUS();
    }
}
