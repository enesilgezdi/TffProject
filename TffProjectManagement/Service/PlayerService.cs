

using System.Net;
using TffProjectManagement.Exceptions;
using TffProjectManagement.Models;
using TffProjectManagement.Models.ReturnModels;
using TffProjectManagement.Repository;

namespace TffProjectManagement.Service;

public class PlayerService : IPlayerService
{
    PlayerRepository playerRepository = new PlayerRepository();
    public ReturnModel<List<Player>> GetAll()
    {
        List<Player> list = playerRepository.GetAll();

        return new ReturnModel<List<Player>>
        {
            Data = list,
            Success = true,
            StatusCode = System.Net.HttpStatusCode.OK
        };
    }

    public ReturnModel<Player> GetById(Guid id)
    {
        try
        {
            Player player = playerRepository.GetById(id);
            return new ReturnModel<Player> {
                Data = player,
                Message = $"Aradığınız Id ye ait takım görüntülendi: {id}",
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK
            };
        } catch (NotFoundException ex)
        {
            return new ReturnModel<Player>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
                StatusCode = System.Net.HttpStatusCode.NotFound

            };
        }
    }

    public ReturnModel<Player> Updated(Guid id, Player player)
    {

        try
        {
            CheckTeamNameValidation(player.Name);

            playerRepository.Update(id, player);

            return new ReturnModel<Player>
            {
                Data = player,
                Message = "Oyuncu Güncellendi",
                StatusCode = System.Net.HttpStatusCode.OK,
                Success = true
            };
        }
        catch (NotFoundException ex)
        {

            return ReturnModelOfException(HttpStatusCode.NotFound, ex);
        }
        catch (ValidationException ex) { 
        
            return ReturnModelOfException(HttpStatusCode.BadRequest, ex);
        }
        
    }

    private void CheckTeamNameValidation(string playerName)
    {
        if (playerName.Length < 1)
        {
            throw new ValidationException("İsim alani minimum 1 haneli olmalidiri ");
        }
    }

    private ReturnModel<Player> ReturnModelOfException(HttpStatusCode statusCode, Exception ex)
    {
        return new ReturnModel<Player>
        {
            Data = null,
            Message = ex.Message,
            Success = false,
            StatusCode = statusCode
        };
    }
}
 