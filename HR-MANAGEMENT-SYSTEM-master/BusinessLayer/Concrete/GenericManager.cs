using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenericManager<T> : IService<T> where T : class
    {
        IRepository<T> _repository;

        public GenericManager(IRepository<T> repository) 
        {
            _repository = repository;
        }
        public void Delete(T p)
        {
            _repository.Delete(p);
        }

        public T GetByID(int id)
        {
            //return _repository.Get(x => x.)
            return null;
        }

        public void Insert(T p)
        {
            _repository.Insert(p);
        }

        public List<T> GetList()
        {
            return _repository.List();
        }

        public void Update(T p)
        {
            _repository.Update(p);
        }
    }
}
