using BusinessLayer.Abstract.People;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.People
{
    public class PersonTypeManager : IPersonTypeService
    {
        IPersonTypeDal _personDal;

        public PersonTypeManager(IPersonTypeDal personDal)
        {
            _personDal = personDal;
        }
        public void AddType(PersonType type)
        {
            _personDal.Insert(type);
        }

        public void DeleteType(PersonType type)
        {
            _personDal.Insert(type);
        }

        public PersonType GetByID(int id)
        {
            return _personDal.Get(x => x.Id == id);
        }

        public List<PersonType> GetList()
        {
            return _personDal.List();
        }

        public void UpdateType(PersonType type)
        {
            _personDal.Update(type);
        }
    }
}