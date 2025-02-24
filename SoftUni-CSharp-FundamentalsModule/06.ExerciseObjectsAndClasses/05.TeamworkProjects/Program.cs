namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            
            int teamsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamsCount; i++)
            {
                string[] createTeamInput = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                string creator  = createTeamInput[0];
                string teamName = createTeamInput[1];

                if (IsTeamExisting(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                } 
                else if (IsCreastorExisting(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team(creator, teamName);
                    teams.Add(newTeam);
                    
                    Console.WriteLine($"{newTeam}");
                }
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] joinTeamInput = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string follower = joinTeamInput[0];
                string teamName = joinTeamInput[1];

                if (!IsTeamExisting(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (IsMemberExisting(teams, follower))
                {
                    Console.WriteLine($"Member {follower} cannot join team {teamName}!");
                }
                else
                {
                    teams.Find(x => x.TeamName == teamName)
                        .AddFollower(follower);
                }
            }

            List<Team> sortedTeams = teams.Where(x => x.UserCount > 1)
                .OrderByDescending(x => x.UserCount)
                .ThenBy(x => x.TeamName)
                .ToList();
            
            foreach (Team team in sortedTeams)
            {
                Console.Write($"{team.TeamName}\n" +
                              $"- {team.Creator}\n");

                sortedTeams.Find(x => x.TeamName == team.TeamName)
                    .SortFollowers(team.Followers);
                foreach (string follower in team.Followers)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, $"-- {follower}"));
                }
            }

            List<Team> disbandTeams = teams.Where(x => x.UserCount == 1)
                .OrderBy(x => x.TeamName)
                .ToList();
            
            Console.WriteLine("Teams to disband:");
            
            foreach (Team team in disbandTeams)
            {
                Console.Write($"{team.TeamName}\n");
            }
        }

        private static bool IsTeamExisting(List<Team> teams, string teamName)
        {
            return teams.Select(x => x.TeamName).Contains(teamName);
        }
        
        private static bool IsCreastorExisting(List<Team> teams, string creator)
        {
            return teams.Select(x => x.Creator).Contains(creator);
        }
        
        private static bool IsMemberExisting(List<Team> teams, string member)
        {
            return teams.Select(x => x.Creator).Contains(member)
            || teams.Any(x => x.Followers.Contains(member));
        }
    }

    class Team
    {
        public Team(string creator, string teamName)
        {
            Creator = creator;
            UserCount++;
            TeamName = teamName;
            Followers = new List<string>();
        }

        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Followers { get; set; }
        public uint UserCount { get; set; }

        public void AddFollower( string follower)
        {
            Followers.Add(follower);
            UserCount++;
        }
        
        public void SortFollowers(List<string> teamFollowers)
        {
            teamFollowers.Sort();
        }
        public override string ToString()
        {
            return $"Team {TeamName} has been created by {Creator}!".ToString();
        }
    }
}
