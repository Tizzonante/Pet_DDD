namespace Pet.Api.Domain.ValueObjects
{
    public readonly record struct PetDateOfBirth
    {
        public DateOnly Value { get; init; }

        internal PetDateOfBirth(DateOnly value)
        {
            Value = value;
        }

        public static PetDateOfBirth Create(DateOnly value)
        {
            return new PetDateOfBirth(value);
        }

        private void Validate(DateOnly value)
        {
            if (value > DateOnly.FromDateTime(DateTime.Now))
            {
                throw new ArgumentOutOfRangeException("Date of birth can not be greater than current day");
            }
        }
    }
}
