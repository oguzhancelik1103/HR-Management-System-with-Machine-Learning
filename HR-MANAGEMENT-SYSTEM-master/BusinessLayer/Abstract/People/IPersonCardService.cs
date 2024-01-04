using EntityLayer.Concrete.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.People
{
    public interface IPersonCardService
    {
        List<PersonCard> GetList();
        void AddCard(PersonCard card);
        void DeleteCard(PersonCard card);
        void UpdateCard(PersonCard card);
        PersonCard GetByID(int id);
    }
}