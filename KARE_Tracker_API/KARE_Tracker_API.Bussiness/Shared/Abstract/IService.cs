using KARE_Tracker_API.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KARE_Tracker_API.Bussiness.Shared.Abstract
{
    public interface IService<T> where T : BaseModel
    {
        IQueryable<T> GetAll(Expression<Func<T,bool>> predicate);
        IQueryable<T> GetAll();
        T GetFirstOrDefault(Expression<Func<T,bool>> predicate);
        T Update(T entity);
        T Add(T entity);
        void Delete(int id);
    }
}
