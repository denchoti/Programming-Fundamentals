using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _05.TeamworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-");
                string creatorName = newTeam[0];
                string teamName = newTeam[1];

                Team team = new Team(teamName, creatorName);

                bool doesTeamNameExist = teams
                    .Select(x => x.TeamName)
                    .Contains(teamName);

                bool doesCreatorNameExist = teams
                    .Select(x => x.CreatorName)
                    .Contains(creatorName);

                if (!doesTeamNameExist)
                {
                    if (!doesCreatorNameExist) 
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creatorName} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string teamMembers = Console.ReadLine();
            while (teamMembers != "end of assignment")
            {
                string[] command = teamMembers.Split(new char[] { '-', '>' }).ToArray();
                string newUser = command[0];
                string teamName = command[2]; // 1

                bool doesTeamExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool doesCreatorExist = teams.Select(x => x.CreatorName).Contains(newUser);
                bool doesMemberExist = teams
                    .Select(x => x.Members)
                    .Any(x => x.Contains(newUser));


                if (!doesTeamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (doesCreatorExist || doesMemberExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!"); 
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Members.Add(newUser);
                }
                teamMembers = Console.ReadLine();
            }

            Team[] teamsToDisband = teams
                .OrderBy(x => x.TeamName)
                .Where(x => x.Members.Count == 0)
                .ToArray();

            Team[] fullTeam = teams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .Where(x => x.Members.Count > 0)
                .ToArray();

            StringBuilder print = new StringBuilder();
            foreach (Team team in fullTeam)
            {
                print.AppendLine($"{team.TeamName}");
                print.AppendLine($"- {team.CreatorName}");

                foreach (var member in team.Members.OrderBy(x=>x))
                {
                    print.AppendLine($"-- {member}");
                }
            }

            print.AppendLine("Teams to disband:");
            foreach (Team item in teamsToDisband)
            {
                print.AppendLine(item.TeamName);
            }
            Console.WriteLine(print.ToString());
        }
    }
    class Team
    {
        public Team(string teamName, string creatorName)
        {
            TeamName = teamName;
            CreatorName = creatorName;
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
}
