using KARE_Tracker_API.Bussiness.Shared.Abstract;
using KARE_Tracker_API.Models.Models;
using KARE_Tracker_API.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KARE_Tracker_API.Bussiness.Shared.Concrete
{
    public class Service<T> : IService<T> where T : BaseModel
    {
        private readonly IRepository<T> _repo;

        public Service(IRepository<T> repo)
        {
            _repo = repo;
        }

        public T Add(T entity)
        {
            return _repo.Add(entity);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _repo.GetAll(predicate).Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _repo.GetAll();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _repo.GetFirstOrDefault(predicate);
        }

        public T Update(T entity)
        {
             return _repo.Update(entity);
        }
    }
}
