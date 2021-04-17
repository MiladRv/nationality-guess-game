using NationalityGuess.Domain.Model;
using NationalityGuess.Domain.Model.Nationalitie;
using NationalityGuess.Infrastructure.Builders;
using System;
using System.Collections.Generic;

namespace NationalityGuess.Infrastrucuture.Repository.Nationalities
{
    public class NationalityRepository : Repository<Nationality>, INationalityRepository
    {
        private readonly List<Nationality> nationalities;
        public NationalityRepository()
        {

            nationalities = new List<Nationality>
            {
                new NationalityBuilder()
                .WithName("Japanese")
                .Build(),

                new NationalityBuilder()
                .WithName("Chinese")
                .Build(),

                new NationalityBuilder()
                .WithName("Korean")
                .Build(),

                new NationalityBuilder()
                .WithName("Thai")
                .Build(),
            };
        }

        public override IEnumerable<Nationality> GetAll()
        {
            return nationalities;
        }

    }
}
