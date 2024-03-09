using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain.Common;

namespace WebAPI.Domain.Entities
{
    public class Detail : EntityBase
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required  int CategoryId{ get; set; }
        public Category Category { get; set; }
    }
}
