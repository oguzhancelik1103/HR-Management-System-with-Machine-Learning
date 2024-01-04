using BusinessLayer.Abstract.System;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.System
{
    public class SysUserManager : ISysUserService
    {
        ISysUserDal _userDal;

        public SysUserManager(ISysUserDal userDal)
        {
            _userDal = userDal;
        }

        public void AddUser(SysUser user)
        {
            _userDal.Insert(user);
        }

        public void DeleteUser(SysUser user)
        {
            _userDal.Delete(user);
        }

        public SysUser GetByID(int id)
        {
            return _userDal.Get(x => x.PersonID == id);
        }

        public SysUser GetByUsername(string p)
        {
            return _userDal.Get(x => x.Username == p);
        }

        public SysUser GetByUsernameAndPassword(SysUser user)
        {
            return _userDal.Get(x => x.Username == user.Username && x.Password == user.Password);
        }

        public List<SysUser> GetList()
        {
            return _userDal.List();
        }

        public void UpdateUser(SysUser user)
        {
            _userDal.Update(user);
        }
    }
}
