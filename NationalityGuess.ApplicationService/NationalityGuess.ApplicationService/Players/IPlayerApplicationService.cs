using NationalityGuess.Domain.Model.Users;
using System.Linq;

namespace NationalityGuess.ApplicationService.Players
{
    public interface IPlayerApplicationService
    {
        IQueryable<Player> GetAll();
    }
}
