using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBForm.Models;

namespace BBForm
{
    // James Alberts 3/9/19
    // Class keeps TeamPlayers Table up to date
    public class UpdatePlayerTeam
    {
        // James Alberts 3/9/19
        // Add record to PlayerTeam
        public static void AddToPlayerTeam(BBFormContext context, string playerName, string teamName)
        {
            // Player and team exists, no teamplayer record
            if (PlayerExists(context, playerName) && TeamExists(context, teamName) && !PlayerTeamRecordExists(context, playerName, teamName))
            {
                context.PlayerTeam.Add(
                    new PlayerTeam
                    {
                        PlayerName = playerName,
                        TeamName = teamName
                    }
                );
                context.SaveChanges();
            }
            else
            {
                return;
            }
        }

        // James Alberts 3/9/19
        // Remove player from PlayerTeam
        public static void RemovePlayerFromPlayerTeam(BBFormContext context, string playerName)
        {
            List<PlayerTeam> ptListWithPlayer = context.PlayerTeam.Where(x => x.PlayerName == playerName).ToList();
            foreach (PlayerTeam pt in ptListWithPlayer)
            {
                context.PlayerTeam.Remove(pt);
            }

            context.SaveChanges();
            return;
        }

        // James Alberts 3/9/19
        // Remove team from PlayerTeam
        public static void RemoveTeamFromPlayerTeam(BBFormContext context, string teamName)
        {
            List<PlayerTeam> ptListWithTeam = context.PlayerTeam.Where(x => x.TeamName == teamName).ToList();
            foreach (PlayerTeam pt in ptListWithTeam)
            {
                context.PlayerTeam.Remove(pt);
            }

            context.SaveChanges();
            return;
        }

        public static bool TeamExists(BBFormContext context, string teamName)
        {
            if (context.Team.Where(x => x.Name == teamName).Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PlayerExists(BBFormContext context, string playerName)
        {
            if (context.Player.Where(x => x.Name == playerName).Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PlayerTeamRecordExists(BBFormContext context, string playerName, string teamName)
        {
            if (context.PlayerTeam.Where(x => x.PlayerName == playerName && x.TeamName == teamName).Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
