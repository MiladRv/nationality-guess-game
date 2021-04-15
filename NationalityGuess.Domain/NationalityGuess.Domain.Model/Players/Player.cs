using NationalityGuess.Domain.Model.UserGuesses;
using System;
using System.Collections.Generic;

namespace NationalityGuess.Domain.Model.Users
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public List<PlayerGuess> Guesses { get; set; }

        public int CalculateScore()
        {
            return 0;
        }
    }
}
