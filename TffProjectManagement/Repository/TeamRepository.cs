
using TffProjectManagement.Models;

namespace TffProjectManagement.Repository
{
    public class TeamRepository : IRepository<Team, int>
    {
        public Team Add(Team entity)
        {
            BaseRepository.Teams.Add(entity);
            return entity;
        }

        public Team? Delete(int id)
        {
            Team? team = GetById(id);
            if (team == null) {
                throw new Exception($"Aradığınız Id ye göre Takım Bulunamadı:{id}");
            }
            return team;
        }

        public List<Team> GetAll()
        {
            return BaseRepository.Teams;
        }

        public Team? GetById(int id)
        {
            Team team = BaseRepository.Teams.SingleOrDefault(x=>x.Id == id);
            if (team == null) {
                throw new Exception($"Aradığınız Id ye göre Takım Bulunamadı:{id}");
            }
            return team;
        }

        public Team? Update(int id, Team entity)
        {
           var updatedTeam = GetById(id);
           if (updatedTeam == null) { return null; }
           updatedTeam.Name = entity.Name;
            updatedTeam.Since = entity.Since;

            return updatedTeam;

        }
    }
}
