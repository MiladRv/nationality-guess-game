using NationalityGuess.Domain.Model.UserGuesses;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalityGuess.Domain.Model.PlayerGuesses
{
    public interface IPlayerGuessRepository : IRepository<PlayerGuess>
    {
    }
}
