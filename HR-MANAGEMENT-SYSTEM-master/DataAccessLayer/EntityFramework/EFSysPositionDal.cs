using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.Models;
using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFSysPositionDal : GenericRepository<SysPosition>, ISysPositionDal
    {
        Context _context;

        public EFSysPositionDal(Context context) : base(context)
        {
            _context = context;
        }
    }
}