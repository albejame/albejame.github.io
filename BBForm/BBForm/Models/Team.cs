using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BBForm.Models
{
    // James Alberts 3/9/19
    public class Team
    {
        // James Alberts 3/9/19
        public int Id { get; set; }

        // James Alberts 3/9/19
        [Display(Name = "Team")]
        [Required]
        public string Name { get; set; }
    }
}
