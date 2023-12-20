using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnionAB104.Domain.Entities
{
    public class Department : BaseNameableEntity
    {
       

        public ICollection<Employee>? Employees { get; set; }
    }
}
