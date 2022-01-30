using _1_DAL.Context;
using _1_DAL.iDALServices;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.DALServices
{
    public class RoleService : iRoleService
    {
        private DatabaseContext _dbConText = new DatabaseContext();
        private List<Role> _lstRoles;

        public RoleService()
        {
        }

        public string AddRole(Role role)
        {
            _dbConText.Roles.Add(role);
            return "Thêm thành công";
        }
        public string UpdateRole(Role role)
        {
            _dbConText.Roles.Update(role);

            return "Sửa thành công";
        }

        public string DeleteRole(Role role)
        {
            _dbConText.Roles.Update(role);

            return "Xóa thành công";
        }
        public List<Role> GetRolesFromDB()
        {
            return _lstRoles = _dbConText.Roles.ToList();
        }
        public List<Role> GetlistRole()
        {
            return _lstRoles;
        }
        public string SaveRole()
        {
            _dbConText.SaveChanges();
            return "Lưu thành công";
        }
    }
}
