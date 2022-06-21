using Pet.Api.Infraestructura;
using Pet.Api.Domain.ValueObjects;
using Pet.Api.Domain.Events;

namespace Pet.Api.Application
{
    public class ApplicationLayer
    {
        private readonly IMessageBroker _messageBroker;

        public ApplicationLayer(IMessageBroker messageBroker)
        {
            _messageBroker = messageBroker;
        }

        /// <summary>
        /// aqui si puedo crear el ValueObject del tipo PetName, porque estos dentro de la aplicacion, lo que no puedo hacer es recibirlo como parametro
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            var petName = PetName.Create(name);
            var pet = new Domain.Entities.Pet(petName);

            foreach (IDomainEvent domainEvent in pet.DomainEvents)
            {
                _messageBroker.Publish(domainEvent); 
            }
        }
    }
}
