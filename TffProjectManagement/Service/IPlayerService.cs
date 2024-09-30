

using TffProjectManagement.Models;
using TffProjectManagement.Models.ReturnModels;

namespace TffProjectManagement.Service;

public interface IPlayerService
{
    ReturnModel<Player> GetById(Guid id);

    ReturnModel<List<Player>> GetAll();

    ReturnModel<Player> Updated(Guid id, Player player);

}
