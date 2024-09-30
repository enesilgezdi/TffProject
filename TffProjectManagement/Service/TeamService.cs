
using TffProjectManagement.Models.ReturnModels;
using TffProjectManagement.Models;
using TffProjectManagement.Repository;
using System.ComponentModel.DataAnnotations;
using System.Net;
using TffProjectManagement.Exceptions;
using ValidationException = System.ComponentModel.DataAnnotations.ValidationException;

namespace TffProjectManagement.Service;

public class TeamService : ITeamService
{
    TeamRepository teamRepository = new TeamRepository();

    public ReturnModel<List<Team>> GetAll()
    {
       List<Team> list = teamRepository.GetAll();
        return new ReturnModel<List<Team>>
        {
            Data = list,
            Success = true,
            StatusCode = System.Net.HttpStatusCode.OK
        };
    }

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

    public ReturnModel<Team> Update(int id, Team team)
    {
        try
        {

            CheckTeamNameValidation(team.Name);


            teamRepository.Update(id, team);

            return new ReturnModel<Team>
            {
                Data = team,
                Message = "Takım Güncellendi",
                StatusCode = System.Net.HttpStatusCode.OK,
                Success = true
            };

        }
        catch (NotFoundException ex)
        {
            return ReturnModelOfException(HttpStatusCode.NotFound, ex);
        }
        catch (ValidationException ex)
        {
            return ReturnModelOfException(HttpStatusCode.BadRequest, ex);
        }
    }
    private void CheckTeamNameValidation(string teamName)
    {
        if (teamName.Length < 1)
        {
            throw new ValidationException("İsim alanı minimum 1 haneli olmalıdır.");
        }
    }

    private ReturnModel<Team> ReturnModelOfException(HttpStatusCode statusCode, Exception ex)
    {
        return new ReturnModel<Team>
        {
            Data = null,
            Message = ex.Message,
            Success = false,
            StatusCode = statusCode
        };
    }
}
