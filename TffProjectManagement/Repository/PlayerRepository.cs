

using TffProjectManagement.Models;

namespace TffProjectManagement.Repository;

public class PlayerRepository : IRepository<Player, Guid>
{
    public Player Add(Player entity)
    {
        BaseRepository.Players.Add(entity);
        return entity;
    }

    public Player? Delete(Guid id)
    {
        Player? player = GetById(id);
        if (player == null) {
            // Exception Fırlat
            return null;
        }
        BaseRepository.Players.Remove(player);
        return player;
    }

    public List<Player> GetAll()
    {
        return BaseRepository.Players;
    }

    public Player? GetById(Guid id)
    {
        return BaseRepository.Players.SingleOrDefault( x => x.Id == id);
    }

    public Player? Update(Guid id, Player entity)
    {
        var updatedPlayer = GetById(id);
        if (updatedPlayer == null) { return null; }

        updatedPlayer.Id = entity.Id;
        updatedPlayer.Name = entity.Name;
        updatedPlayer.Age = entity.Age;
        updatedPlayer.Branch = entity.Branch;
        updatedPlayer.MarketValue = entity.MarketValue;
        updatedPlayer.Number = entity.Number;
        updatedPlayer.Surname = entity.Surname;
        updatedPlayer.TeamId = entity.TeamId;

        return updatedPlayer;
    }
}
