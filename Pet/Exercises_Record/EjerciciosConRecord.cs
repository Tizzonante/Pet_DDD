using Pet.Api.Domain.ValueObjects;
namespace Pet.Api.Exercises_Record
{
    public static class EjerciciosConRecord
    {
        public static bool CompareTwoObjects()
        {
            var petName1 = PetName.Create("Rufo");
            var petName2 = PetName.Create("Rufo222");
            //var petName2 = petName1;//para tener una igualdad entre  clases

            return petName1 == petName2;
        }
    }
}
