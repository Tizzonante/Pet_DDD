namespace Pet.Api.PersonDomian.ValueObjects
{
    public abstract record NamePerson
    {
        public string Fullname => $"{Name} {Lastname}";

        protected string Name { get; init; }

        protected string Lastname { get; init; }

        internal NamePerson(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }
    }
}
