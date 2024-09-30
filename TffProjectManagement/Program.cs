

using TffProjectManagement.Models;
using TffProjectManagement.Service;

//Console.WriteLine("Hello, World!");
//TeamService teamService = new TeamService();

//Console.WriteLine(teamService.GetById(300));

PlayerService playerService = new PlayerService();

var player = new Player
{
    Id = new Guid("{D1ACC6AB-5D3A-43EB-AA39-9FEF0F1D1C56}"),
    Age = 26,
    Name = "David",
    Surname = "Beckham",
    Number = "32",
    Branch = "Futbol",
    MarketValue = 100000000,
    TeamId = 1
};

Console.WriteLine(playerService.Updated(player.Id, player));