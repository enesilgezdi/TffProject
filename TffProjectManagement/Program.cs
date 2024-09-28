

using TffProjectManagement.Service;

Console.WriteLine("Hello, World!");
TeamService teamService = new TeamService();

Console.WriteLine(teamService.GetById(300));