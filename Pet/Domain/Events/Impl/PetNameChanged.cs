namespace Pet.Api.Domain.Events.Impl
{
    public class PetNameChanged : IDomainEvent//tambien podrias usar records pues un evento es algo que ocurrió en el pasado y no debería cambiar
    {
        public string PetName { get; init; }
        
        public PetNameChanged(string petName)
        {
            PetName = petName;
        }
    }
}
