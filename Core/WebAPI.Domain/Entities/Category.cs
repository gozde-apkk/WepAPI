using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Common;

namespace WebAPI.Domain.Entities
{
    public class Category : EntityBase, IEntityBase
    {
        public  int ParentId { get; set; }
        public  string Name { get; set; }
        public  int Priorty { get; set; }
        public ICollection<Detail> Details { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}
