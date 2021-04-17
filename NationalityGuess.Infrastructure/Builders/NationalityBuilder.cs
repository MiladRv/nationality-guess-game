using NationalityGuess.Domain.Model.Nationalitie;

namespace NationalityGuess.Infrastructure.Builders
{
    public class NationalityBuilder
    {
        private string Name { get; set; }

        public NationalityBuilder WithName(string name)
        {
            Name = name;

            return this;
        }

        public Nationality Build()
        {
            var nationality = new Nationality(Name);

            return nationality;
        }
    }
}
