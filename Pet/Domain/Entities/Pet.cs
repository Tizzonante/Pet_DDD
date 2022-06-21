using Pet.Api.Common.Domain.Entities;
using Pet.Api.Domain.Events;
using Pet.Api.Domain.Events.Impl;
using Pet.Api.Domain.ValueObjects;

namespace Pet.Api.Domain.Entities
{
    /// <summary>
    /// This the root Aggregate (The main entity)
    /// </summary>
    public class Pet : Entity
    {
        //private readonly List<IDomainEvent> _events = new List<IDomainEvent>();

        //public ICollection<IDomainEvent> DomainEvents => _events;

        public Guid Id { get; init; }//{ get; internal init; }

        public PetName Name { get; private set; }

        public PetDateOfBirth DateOfDirth { get; private set; }

        /// <summary>
        /// Asi obviamente no se podra crear  instancias desde ningun otro lado
        /// </summary>
        private Pet()
        {
            //_events = new List<IDomainEvent>();
        }

        #region Contructores publicos
        public Pet(PetName name)
        {
            Id = Guid.NewGuid();
            SetName(name);
        }
        public Pet(PetDateOfBirth dateOfDirth)
        {
            Id = Guid.NewGuid();
            SetDateOfDirth(dateOfDirth);
        }

        public Pet(PetName name, PetDateOfBirth dateOfDirth)
        {
            Id = Guid.NewGuid();
            Name = name;
            DateOfDirth = dateOfDirth;
        }
        #endregion Contructores publicos

        public void SetName(PetName name)
        {
            Name = name;
            var newEvent = new PetNameChanged(name.Value);

            _events.Add(newEvent);
        }

        public void SetDateOfDirth(PetDateOfBirth dateOfDirth)
        {
            DateOfDirth = dateOfDirth;
            var newEvent = new PetDateOfBirthChanged(dateOfDirth.Value);

            _events.Add(newEvent);
        }
    }
}
