namespace Pet.Api.Domain.Events.Impl
{
    //tambien podrias usar record en lugar de class, pues un evento es algo que ocurrió en el pasado y no debería cambiar
    public class PetDateOfBirthChanged : IDomainEvent
    {
        public DateOnly DateOfBirth { get; init; }

        public PetDateOfBirthChanged(DateOnly dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }
    }
}
