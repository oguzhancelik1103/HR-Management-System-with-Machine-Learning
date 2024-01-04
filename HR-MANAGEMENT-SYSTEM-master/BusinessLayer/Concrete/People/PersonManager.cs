using BusinessLayer.Abstract.People;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.People
{
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public void AddPerson(Person person)
        {
            _personDal.Insert(person);
        }

        public void DeletePerson(Person person)
        {
            _personDal.Delete(person);
        }

        public Person GetByID(int id)
        {
            return _personDal.Get(x => x.Id == id);
        }

        public List<Person> GetList()
        {
            return _personDal.List();
        }

        public void UpdatePerson(Person person)
        {
            _personDal.Update(person);
        }
    }
}
