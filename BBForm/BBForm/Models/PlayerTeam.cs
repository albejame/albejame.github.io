using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BBForm.Models
{
    // James Alberts 3/9/19
    public class PlayerTeam
    {
        public int Id { get; set; }

        [Display(Name = "Team")]
        [Required]
        public string TeamName { get; set; }

        [Display(Name = "Player")]
        [Required]
        public string PlayerName { get; set; }
    }
}
