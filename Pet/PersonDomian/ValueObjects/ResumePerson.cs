namespace Pet.Api.PersonDomian.ValueObjects
{
    public record ResumePerson : NamePerson
    {
        public string Degree { get; init; }

        public string Value { get; init; }

        internal ResumePerson(string degree, string name, string lastname) : base(name, lastname)
        {
            Degree = degree;
            Value = $"{Degree} {Fullname}";
        }        

        public static ResumePerson Create(string degree, string name, string lastname)
        {
            return new ResumePerson(degree,name,lastname);
        }
    }
}
