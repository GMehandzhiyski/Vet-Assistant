namespace VetAssistant.Common
{
    public static class ValidationConstants
    {
        public static class Pet
        {
            public const int NameMinLenght = 2;
            public const int NameMaxLenght = 50;

            public const int SpeciesMinLenght = 2;
            public const int SpeciesMaxLenght = 100;

            public const int BreedMinLenght = 2;
            public const int BreedMaxLenght = 100;

            public const int TransponderCodeLocationMinLenght = 2;
            public const int TransponderCodeLocationMaxLenght = 25;

            public const int TransponderLocationMinLenght = 2;
            public const int TransponderLocationMaxLenght = 100;

            public const int DetailsLocationMinLenght = 2;
            public const int DetailsLocationMaxLenght = 500;
        }

    }
}
