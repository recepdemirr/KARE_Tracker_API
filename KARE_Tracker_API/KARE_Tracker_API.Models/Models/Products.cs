using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARE_Tracker_API.Models.Models
{
    public class Products : BaseModel
    {
        public DateTime DateCreated { get; set; }
        public int Day { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }


    }
}
