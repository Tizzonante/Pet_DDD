namespace Pet.Api.Domain.ValueObjects
{
    public record PetName// o tambien puedes usar un| record class| o un |readonly record struct| record struct
    {
        public string Value { get; init; }

        //este contructor tambien podria ser privado, tambien funcionaria
        internal PetName(string value)
        {
            Value = value;
        }

        public static PetName Create(string value)
        {
            return new PetName(value);
        }

        private static void Validate(string value)
        {
            if (value.Length > 50)
            {
                throw new ArgumentOutOfRangeException("Name must not be greater than 50 characters");
            }
        }
    }
}
