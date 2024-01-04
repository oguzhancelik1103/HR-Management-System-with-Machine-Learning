using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.Models;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFPersonModelDal : PersonModelRepository, IPersonModelDal
    {
        Context _context;

        public EFPersonModelDal(Context context) : base(context)
        {
            _context = context;
        }
    }
}
