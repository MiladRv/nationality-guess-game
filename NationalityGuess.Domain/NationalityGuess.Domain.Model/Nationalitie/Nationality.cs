using System;
using System.Collections.Generic;

namespace NationalityGuess.Domain.Model.Nationalitie
{
    public class Nationality : DomainBase
    {
        private static List<Nationality> nationalities;
        public Nationality()
        {
            nationalities = new List<Nationality>
            {
                new Nationality
                {
                   Id = Guid.NewGuid(),
                   Name = "Japanese"
                },
                new Nationality
                {
                   Id = Guid.NewGuid(),
                   Name = "Chinese"
                },
                new Nationality
                {
                   Id = Guid.NewGuid(),
                   Name = "Korean"
                },
                new Nationality
                {
                   Id = Guid.NewGuid(),
                   Name = "Thai"
                }
            };
        }

        public string Name { get; private set; }

        public static List<Nationality> GetNationalities()
        {
            return nationalities;
        }
    }
}
