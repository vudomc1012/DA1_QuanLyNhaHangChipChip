using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _1_DAL.iDALServices
{
    public interface iRoleService
    {
        public string AddRole(Role role);
        public string UpdateRole(Role role);
        public string DeleteRole(Role role);
        public string SaveRole();
        public List<Role> GetRolesFromDB();
        public List<Role> GetlistRole();
    }
}
