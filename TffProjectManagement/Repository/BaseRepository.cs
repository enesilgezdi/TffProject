

using TffProjectManagement.Models;
using TffProjectManagement.Models.Enums;

namespace TffProjectManagement.Repository;

public class BaseRepository
{
    public static List<Team> Teams = new List<Team>()
    {
        new Team
        {
            Id = 1,
            Name = "FENERBAHÇE",
            Since = new DateTime(1907,5,3)
        },
        new Team
        {
            Id=2,
            Name = "KASIMPAŞA",
            Since = new DateTime(1921,1,1)
        },
        new Team
        {
            Id=3,
            Name = "LİVERPOOL",
            Since = new DateTime(1892,6,3)
        }
    };

    public static List<Player> Players = new List<Player>()
    {
        new Player
        {
           Id=new Guid("{D1ACC6AB-5D3A-43EB-AA39-9FEF0F1D1C56}"),
           Age = 25,
           Name = "LEO",
           Surname = "Messi",
           Number = "10",
           Branch = Branch.Futbol,
           MarketValue = 100000000,
           TeamId = 1,
           Gender = Gender.Male
        }
    };
}
