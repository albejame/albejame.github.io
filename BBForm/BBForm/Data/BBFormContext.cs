using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BBForm.Models;

namespace BBForm.Models
{
    public class BBFormContext : DbContext
    {
        public BBFormContext (DbContextOptions<BBFormContext> options)
            : base(options)
        {
        }

        public DbSet<BBForm.Models.Player> Player { get; set; }

        public DbSet<BBForm.Models.Team> Team { get; set; }

        public DbSet<BBForm.Models.PlayerTeam> PlayerTeam { get; set; }
    }
}
