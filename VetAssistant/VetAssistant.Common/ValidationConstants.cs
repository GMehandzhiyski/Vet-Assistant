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

        public static class Clinic
        {
            public const int NameMinLenght = 2;
            public const int NameMaxLenght = 150;

            public const int TownMinLenght = 2;
            public const int TownMaxLenght = 200;

            public const int AddressMinLenght = 2;
            public const int AddressMaxLenght = 200;

            public const int EmailMinLenght = 5;
            public const int EmailMaxLenght = 100;

            public const int PhoneNumberMinLenght = 2;
            public const int PhoneNumberMaxLenght = 100;

            public const int WorkingTimeMinLenght = 2;
            public const int WorkingTimeMaxLenght = 100;
        }

        public static class Booking
        {
            public const int DescriptionMinLenght = 5;
            public const int DescriptionMaxLenght = 500;
        }

        public static class Country
        {
            public const int NameMinLenght = 2;
            public const int NameMaxLenght = 70;

            public const int CodeMinLenght = 2;
            public const int CodeMaxLenght = 5;
        }

        public static class Doctor
        {
            public const int FirstNameMinLenght = 2;
            public const int FirstNameMaxLenght = 20;

            public const int LastNameMinLenght = 2;
            public const int LastNameMaxLenght = 20;

            public const int EmailMinLenght = 5;
            public const int EmailMaxLenght = 50;

            public const int PhoneNumberMinLenght = 5;
            public const int PhoneNumberMaxLenght = 50;

            public const int TownMinLenght = 2;
            public const int TownMaxLenght = 80;

            public const int EducationMinLenght = 10;
            public const int EducationMaxLenght = 500;

            public const int SpecialtyMinLenght = 10;
            public const int SpecialtyMaxLenght = 500;

            public const int ExperienceMinLenght = 10;
            public const int ExperienceMaxLenght = 500;

            public const int DetailsMinLenght = 10;
            public const int DetailsMaxLenght = 500;
        }

        public static class Gender
        {
            public const int NameMinLenght = 3;
            public const int NameMaxLenght = 7;
        }

        public static class TypeInspection
        {
            public const int NameMinLenght = 3;
            public const int NameMaxLenght = 200;
        }
    }
}
