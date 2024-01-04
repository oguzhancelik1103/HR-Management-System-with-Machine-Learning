using DataAccessLayer.Abstract;
using DataAccessLayer.Models;
using EntityLayer.Concrete.People;
using EntityLayer.Concrete.System;
using EntityLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class PersonModelRepository : IPersonModelDal
    {
        Context _context;

        DbSet<Person> _person;
        DbSet<PersonCard> _card;
        DbSet<SysUser> _user;

        public PersonModelRepository(Context context)
        {
            _context = context;
            _person = _context.Set<Person>();
            _card = _context.Set<PersonCard>();
            _user = _context.Set<SysUser>();
        }

        public void Insert(PersonModel model)
        {
            var addedEntity = _context.Entry(model);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(PersonModel model)
        {
            var updatedEntity = _context.Entry(model);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(PersonModel model)
        {
            var deletedEntity = _context.Entry(model);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
