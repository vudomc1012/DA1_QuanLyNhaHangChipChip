using _1_DAL.DALServices;
using _1_DAL.iDALServices;
using _1_DAL.Models;
using _2_BUS.iBUSServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.BUSServices
{
    public class QLlogin:IQLlogin
    {
        iRoleService iRoleService;
        List<Role> _lstRole;
        public QLlogin()
        {
            iRoleService = new RoleService();
            GetlistRoleBUS();
        }
        public List<Role> GetlistRoleBUS()
        {
            return _lstRole = iRoleService.GetlistRole();
        }
    }
}
