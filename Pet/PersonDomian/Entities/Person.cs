using Pet.Api.PersonDomian.ValueObjects;

namespace Pet.Api.PersonDomian.Entities
{
    public class Person
    {
        public Guid Id { get; init; }//{ get; internal init; }

        public ResumePerson Resume { get; private set; }

        private Person()
        {

        }
        public Person(ResumePerson resume)
        {
            Id = Guid.NewGuid();
            Resume = resume;
        }
        public Person(Guid id, ResumePerson resume)
        {
            Id = id;
            Resume = resume;
        }
    }
}
