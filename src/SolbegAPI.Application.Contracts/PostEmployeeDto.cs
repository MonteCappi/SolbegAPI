using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolbegAPI
{
    public class PostEmployeeDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        [Required]
        public GenderType Gender { get; set; }
    }
}
