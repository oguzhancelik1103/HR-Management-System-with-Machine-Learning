using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PersonModelManager : IPersonModelService
    {
        IPersonDal _personDal;
        IPersonCardDal _cardDal;
        ISysUserDal _userDal;

        IPersonModelDal _modelDal;

        public PersonModelManager(IPersonDal personDal, IPersonCardDal cardDal,
            ISysUserDal userDal)//, IPersonModelDal modelDal)
        {
            _personDal = personDal;
            _cardDal = cardDal;
            _userDal = userDal;
            //_modelDal = modelDal;
        }

        public void AddModel(PersonModel model)
        {
            _personDal.Insert(model.Person);
            _cardDal.Insert(model.PersonCard);
            _userDal.Insert(model.SysUser);
        }

        public void DeleteModel(PersonModel model)
        {
            _personDal.Delete(model.Person);
            _cardDal.Delete(model.PersonCard);
            _userDal.Delete(model.SysUser);
        }

        public void UpdateModel(PersonModel model)
        {
            _personDal.Update(model.Person);
            _cardDal.Update(model.PersonCard);
            _userDal.Update(model.SysUser);
            //_modelDal.Update(model);
        }
    }
}