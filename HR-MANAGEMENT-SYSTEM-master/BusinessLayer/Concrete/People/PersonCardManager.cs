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
    public class PersonCardManager : IPersonCardService
    {
        IPersonCardDal _personDal;

        public PersonCardManager(IPersonCardDal personDal)
        {
            _personDal = personDal;
        }

        public void AddCard(PersonCard card)
        {
            _personDal.Insert(card);
        }

        public void DeleteCard(PersonCard card)
        {
            _personDal.Delete(card);
        }

        public PersonCard GetByID(int id)
        {
            return _personDal.Get(x => x.PersonID == id);
        }

        public List<PersonCard> GetList()
        {
            return _personDal.List();
        }

        public void UpdateCard(PersonCard card)
        {
            _personDal.Update(card);
        }
    }
}