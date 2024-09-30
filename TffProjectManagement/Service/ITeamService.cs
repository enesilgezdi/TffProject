

using TffProjectManagement.Models.ReturnModels;
using TffProjectManagement.Models;

namespace TffProjectManagement.Service;

public interface ITeamService
{
    ReturnModel<Team> GetById(int id);
    ReturnModel<List<Team>> GetAll();
    ReturnModel<Team> Update(int id , Team team);
}
