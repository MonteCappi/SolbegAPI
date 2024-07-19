using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SolbegAPI
{
    public class Employee : FullAuditedAggregateRoot<Guid>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Range(18,100)]
        public int Age { get; set; }

        [Required]
        public GenderType Gender {  get; set; }
    }
}
