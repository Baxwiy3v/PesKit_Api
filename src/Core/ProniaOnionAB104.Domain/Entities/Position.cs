using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnionAB104.Domain.Entities
{
    public class Position: BaseNameableEntity
    {
        [Required]
        public ICollection<Employee>? Employees { get; set; }
    }
}
