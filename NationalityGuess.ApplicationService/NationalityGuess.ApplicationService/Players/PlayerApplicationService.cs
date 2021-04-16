using NationalityGuess.Domain.Model.Users;
using System.Linq;

namespace NationalityGuess.ApplicationService.Players
{
    public class PlayerApplicationService : IPlayerApplicationService
    {
        public IQueryable<Player> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
