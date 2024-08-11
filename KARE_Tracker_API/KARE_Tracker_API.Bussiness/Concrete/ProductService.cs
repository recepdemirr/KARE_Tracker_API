using KARE_Tracker_API.Bussiness.Abstract;
using KARE_Tracker_API.Bussiness.Shared.Abstract;
using KARE_Tracker_API.Bussiness.Shared.Concrete;
using KARE_Tracker_API.Models.Models;
using KARE_Tracker_API.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARE_Tracker_API.Bussiness.Concrete
{
    public class ProductService : Service<Products>, IProductService
    {
        public ProductService(IRepository<Products> repo) : base(repo)
        {
        }
    }
}
