using KARE_Tracker_API.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KARE_Tracker_API.Repository.Shared.Abstract
{
    public interface IRepository<T> where T : BaseModel
    {
        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T,bool>> predicate);
        T Add(T entity);
        T Update(T entity);
        void Delete(int id);
        void Save();

    }
}
