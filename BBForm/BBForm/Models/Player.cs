using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BBForm.Models
{
    // James Alberts 3/9/19
    public class Player
    {
        public int Id { get; set; }

        [Display(Name = "Last Name, First Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Jersey Number")]
        [Required]
        public int JerseyNumber { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DOB { get; set; }

        [Display(Name = "Height (# ft # in)")]
        [Required]
        public string Height { get; set; }

        [Display(Name = "Current Team")]
        [Required]
        public string CurrentTeam { get; set; }
    }
}
