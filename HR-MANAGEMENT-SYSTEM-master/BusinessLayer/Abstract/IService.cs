﻿using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IService<T>
    {
        //List<T> List(Expression<Func<T, bool>> filter);
        List<T> GetList();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        T GetByID(int id);
    }
}
