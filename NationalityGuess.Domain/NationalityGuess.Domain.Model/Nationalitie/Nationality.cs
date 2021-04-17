using System;
using System.Collections.Generic;

namespace NationalityGuess.Domain.Model.Nationalitie
{
    public class Nationality : DomainBase
    {
        public Nationality(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public string Name { get; private set; }
    }
}
