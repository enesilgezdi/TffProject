
using TffProjectManagement.Models.ReturnModels;
using TffProjectManagement.Models;
using TffProjectManagement.Repository;

namespace TffProjectManagement.Service;

public class TeamService : ITeamService
{
    TeamRepository teamRepository = new TeamRepository();

    public ReturnModel<Team> GetById(int id)
    {
        try
        {
            Team team = teamRepository.GetById(id);
            return new ReturnModel<Team>
            {
                Data = team,
                Message = $"Aradığınız Id ye ait takım görüntülendi: {id}",
                Success = true
            };
        }
        catch (Exception ex)
        {
            return new ReturnModel<Team>
            {
                Data = null,
                Message = ex.Message,
                Success = false
            };
        }


    }

}
