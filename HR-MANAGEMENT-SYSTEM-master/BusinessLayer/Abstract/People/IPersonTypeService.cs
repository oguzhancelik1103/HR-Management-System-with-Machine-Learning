using EntityLayer.Concrete.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.People
{
    public interface IPersonTypeService
    {
        List<PersonType> GetList();
        void AddType(PersonType type);
        void DeleteType(PersonType type);
        void UpdateType(PersonType type);
        PersonType GetByID(int id);
    }
}