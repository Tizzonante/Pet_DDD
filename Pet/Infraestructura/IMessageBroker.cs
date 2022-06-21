using Pet.Api.Domain.Events;

namespace Pet.Api.Infraestructura
{
    public interface IMessageBroker
    {
        bool Publish(IDomainEvent dominEvent);
    }
}
