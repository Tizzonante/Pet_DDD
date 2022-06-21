using Pet.Api.Domain.Events;

namespace Pet.Api.Common.Domain.Entities
{
    public class Entity
    {
        protected readonly List<IDomainEvent> _events;

        public ICollection<IDomainEvent> DomainEvents => _events;

        protected Entity()
        {
            _events = new List<IDomainEvent>();
        }

        public void AddDomainEvent(IDomainEvent eventItem)
        {
            _events.Add(eventItem);
        }

        public void RemoveDomainEvent(IDomainEvent eventItem)
        {
            _events?.Remove(eventItem);
        }
    }
}
