namespace RentNest.Infrastructure.Constants
{
    public class DataConstants
    {
        //Category
        public const int CategoryNameLength = 50;

        //House
        public const int HouseTitleMinLength = 10;

        public const int HouseTitleMaxLength = 50;
        
        public const int HouseAddressMinLength = 30;
                              
        public const int HouseAddressMaxLength = 150;
        
        public const int HouseDescriptionMinLength = 50;
                              
        public const int HouseDescriptionMaxLength = 500;

        public const string HousePricePerMonthMin = "0.00";
                              
        public const string HousePricePerMonthMax = "2000";


        //Agent
        public const int AgentPhoneNumberMinLength = 7;
                            
        public const int AgentPhoneNumberMaxLength = 15;

    }
}
