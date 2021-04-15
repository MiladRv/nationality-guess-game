using System;

namespace NationalityGuess.Domain.Model.UserGuesses
{
    public class PlayerGuess
    {
        public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public int SelectedOptionId { get; set; }
        public int CorrectOptionId { get; set; }

        public bool IsTrue()
        {
            return SelectedOptionId == CorrectOptionId;
        }


    }
}
