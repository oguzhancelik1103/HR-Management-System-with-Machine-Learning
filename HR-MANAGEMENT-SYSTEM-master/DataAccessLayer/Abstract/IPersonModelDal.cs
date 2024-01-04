using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IPersonModelDal
    {
        //PersonModel Get(Expression<Func<T, bool>> filter);

        //List<PersonModel> List(Expression<Func<T, bool>> filter);

        //List<PersonModel> List();

        void Insert(PersonModel model);

        void Update(PersonModel model);

        void Delete(PersonModel model);
    }
}
