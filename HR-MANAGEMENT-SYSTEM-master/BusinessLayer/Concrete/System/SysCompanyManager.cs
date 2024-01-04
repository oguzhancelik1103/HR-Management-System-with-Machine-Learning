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
    public class SysCompanyManager : ISysCompanyService
    {
        ISysCompanyDal _companyDal;

        public SysCompanyManager(ISysCompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public void Insert(SysCompany company)
        {
            _companyDal.Insert(company);
        }

        public void Delete(SysCompany company)
        {
            _companyDal.Delete(company);
        }

        public SysCompany GetByID(int id)
        {
            return _companyDal.Get(x => x.Id == id);
        }

        public List<SysCompany> GetList()
        {
            return _companyDal.List();
        }

        public void Update(SysCompany company)
        {
            _companyDal.Update(company);
        }
    }
}