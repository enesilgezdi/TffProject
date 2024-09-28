

using TffProjectManagement.Models.ReturnModels;
using TffProjectManagement.Models;

namespace TffProjectManagement.Service;

public interface ITeamService
{
    ReturnModel<Team> GetById(int id);
}
