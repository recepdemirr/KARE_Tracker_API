using KARE_Tracker_API.Data;
using KARE_Tracker_API.Models.Models;
using KARE_Tracker_API.Repository.Shared.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KARE_Tracker_API.Repository.Shared.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        private DbSet<T> _dbset;
       

        public T Add(T entity)
        {
            _dbset.Add(entity);
            Save();
            return entity;
        }

        public void Delete(int id)
        {
           T entity = _dbset.Find(id);
            entity.IsDeleted = false;
            _dbset.Update(entity);
            Save();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _dbset.Where(x => !x.IsDeleted);
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _dbset.FirstOrDefault(predicate);
        }

        public void Save()
        {
           _context.SaveChanges();
        }

        public T Update(T entity)
        {
            _dbset.Update(entity);
            Save();
            return entity;
        }
    }
}
