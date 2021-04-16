using System;

namespace NationalityGuess.Domain.Model.UserGuesses
{
    public class PlayerGuess : DomainBase
    {
        public Guid PlayerId { get; set; }
        public int SelectedOptionId { get; set; }
        public int CorrectOptionId { get; set; }

        public bool IsTrue()
        {
            return SelectedOptionId == CorrectOptionId;
        }


    }
}
