using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARE_Tracker_API.Models.Models
{
    public class Status: BaseModel
    {
       public ICollection<Products> Products { get; set; }
    }
}
