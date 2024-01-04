using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.Models;
using EntityLayer.Concrete.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFPersonCardDal : GenericRepository<PersonCard>, IPersonCardDal
    {
        Context _context;

        public EFPersonCardDal(Context context) : base(context)
        {
            _context = context;
        }
    }
}
