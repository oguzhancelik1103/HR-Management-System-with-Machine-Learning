using BusinessLayer.Abstract.System;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.System
{
    public class SysPositionManager : ISysPositionService
    {
        ISysPositionDal _positionDal;

        public SysPositionManager(ISysPositionDal positionDal) 
        {
            _positionDal = positionDal;
        }

        public void Delete(SysPosition pos)
        {
            _positionDal.Delete(pos);
        }

        public SysPosition GetByID(int id)
        {
            return _positionDal.Get(x => x.Id == id);
        }

        public List<SysPosition> GetList()
        {
            return _positionDal.List();
        }

        public void Insert(SysPosition pos)
        {
            _positionDal.Insert(pos);
        }

        public void Update(SysPosition pos)
        {
            _positionDal.Update(pos);
        }
    }
}