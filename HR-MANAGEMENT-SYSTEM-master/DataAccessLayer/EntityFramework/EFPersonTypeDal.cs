using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.Models;
using EntityLayer.Concrete.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFPersonTypeDal : GenericRepository<PersonType>, IPersonTypeDal
    {
        Context _context;

        public EFPersonTypeDal(Context context) : base(context)
        {
            _context = context;
        }
    }
}
