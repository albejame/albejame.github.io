using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BBForm.Models
{
    // James Alberts 3/9/19
    // Class to add test data to database
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BBFormContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BBFormContext>>()))
            {
                // Don't seed if DB contains any teams
                if (context.Team.Any())
                {
                    return;
                }

                context.Team.AddRange(
                    new Team
                    {
                        Name = "Atlanta Hawks"
                    },

                    new Team
                    {
                        Name = "Boston Celtics"
                    },

                    new Team
                    {
                        Name = "Brooklyn Nets"
                    },

                    new Team
                    {
                        Name = "Charlotte Hornets"
                    },

                    new Team
                    {
                        Name = "Chicago Bulls"
                    },

                    new Team
                    {
                        Name = "Cleveland Cavaliers"
                    },

                    new Team
                    {
                        Name = "Dallas Mavericks"
                    },

                    new Team
                    {
                        Name = "Denver Nuggets"
                    },

                    new Team
                    {
                        Name = "Detroit Pistons"
                    },

                    new Team
                    {
                        Name = "Golden State Warriors"
                    },

                    new Team
                    {
                        Name = "Houston Rockets"
                    },

                    new Team
                    {
                        Name = "Indiana Pacers"
                    },

                    new Team
                    {
                        Name = "LA Clippers"
                    },

                    new Team
                    {
                        Name = "Los Angeles Lakers"
                    },

                    new Team
                    {
                        Name = "Memphis Grizzlies"
                    },

                    new Team
                    {
                        Name = "Miami Heat"
                    },

                    new Team
                    {
                        Name = "Milwaukee Bucks"
                    },

                    new Team
                    {
                        Name = "Minnesota Timberwolves"
                    },

                    new Team
                    {
                        Name = "New Orleans Pelicans"
                    },

                    new Team
                    {
                        Name = "New York Knicks"
                    },

                    new Team
                    {
                        Name = "Oklahoma City Thunder"
                    },

                    new Team
                    {
                        Name = "Orlando Magic"
                    },

                    new Team
                    {
                        Name = "Philadelphia 76ers"
                    },

                    new Team
                    {
                        Name = "Phoenix Suns"
                    },

                    new Team
                    {
                        Name = "Portland Trail Blazers"
                    },

                    new Team
                    {
                        Name = "Utah Jazz"
                    }
                );

                context.SaveChanges();

                context.Player.AddRange(
                    new Player
                    {
                        Name = "Adams, Jaylen",
                        JerseyNumber = 10,
                        DOB = DateTime.Parse("1996-05-04"),
                        Height = "6 ft 2 in",
                        CurrentTeam = "Atlanta Hawks"
                    },

                    new Player
                    {
                        Name = "Butler, Jimmy",
                        JerseyNumber = 6,
                        DOB = DateTime.Parse("1989-09-14"),
                        Height = "6 ft 8 in",
                        CurrentTeam = "Philadelphia 76ers"
                    },

                    new Player
                    {
                        Name = "Millsap, Paul",
                        JerseyNumber = 4,
                        DOB = DateTime.Parse("1985-02-10"),
                        Height = "6 ft 8 in",
                        CurrentTeam = "Denver Nuggets"
                    },

                    new Player
                    {
                        Name = "Rubio, Ricky",
                        JerseyNumber = 3,
                        DOB = DateTime.Parse("1990-10-21"),
                        Height = "6 ft 4 in",
                        CurrentTeam = "Utah Jazz"
                    },

                    new Player
                    {
                        Name = "Mitchell, Donovan",
                        JerseyNumber = 45,
                        DOB = DateTime.Parse("1996-09-07"),
                        Height = "6 ft 3 in",
                        CurrentTeam = "Utah Jazz"
                    }
                );

                context.SaveChanges();

                if (context.PlayerTeam.Any())
                {
                    return;
                }

                context.PlayerTeam.AddRange(
                    new PlayerTeam
                    {
                        PlayerName = "Adams, Jaylen",
                        TeamName = "Atlanta Hawks"
                    },

                    new PlayerTeam
                    {
                        PlayerName = "Butler, Jimmy",
                        TeamName = "Philadelphia 76ers"
                    },

                    new PlayerTeam
                    {
                        PlayerName = "Butler, Jimmy",
                        TeamName = "Minnesota Timberwolves"
                    },

                    new PlayerTeam
                    {
                        PlayerName = "Butler, Jimmy",
                        TeamName = "Chicago Bulls"
                    },

                    new PlayerTeam
                    {
                        PlayerName = "Milsap, Paul",
                        TeamName = "Atlanta Hawks"
                    },

                    new PlayerTeam
                    {
                        PlayerName = "Milsap, Paul",
                        TeamName = "Denver Nuggets"
                    },

                    new PlayerTeam
                    {
                        PlayerName = "Milsap, Paul",
                        TeamName = "Utah Jazz"
                    },

                    new PlayerTeam
                    {
                        PlayerName = "Rubio, Ricky",
                        TeamName = "Utah Jazz"
                    },

                    new PlayerTeam
                    {
                        PlayerName = "Rubio, Ricky",
                        TeamName = "Minnesota Timberwolves"
                    },

                    new PlayerTeam
                    {
                        PlayerName = "Mitchell, Donovan",
                        TeamName = "Utah Jazz"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
