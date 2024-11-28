namespace VetAssistant.Common
{
    public class ValidationMessages
    {
        public static class Clinic
        {
            public const string ErrorMessageName = "The {0} field is required";
            public const string ErrorMessageNameLength = "The {0} length is between {2} and {1}";

            public const string ErrorMessageTown = "The {0} field is required";
            public const string ErrorMessageTownLength = "The {0} length is between {2} and {1}";

            public const string ErrorMessageAddress = "The {0} field is required";
            public const string ErrorMessageAddressLength = "The {0} length is between {2} and {1}";

            public const string ErrorMessageEmail = "The {0} field is required";
            public const string ErrorMessageEmailLength = "The {0} length is between {2} and {1}";

            public const string ErrorMessagePhoneNumber = "The {0} field is required";
            public const string ErrorMessagePhoneNumberLength = "The {0} length is between {2} and {1}";

            public const string ErrorMessageWorkingTime = "The {0} field is required";
            public const string ErrorMessageWorkingTimeLenght = "The {0} length is between {2} and {1}";
        }
    }
}
