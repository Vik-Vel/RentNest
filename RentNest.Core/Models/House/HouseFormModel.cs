using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static RentNest.Core.Constants.MessageConstants;
using static RentNest.Infrastructure.Constants.DataConstants;


namespace RentNest.Core.Models.House
{
    public class HouseFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseTitleMaxLength, 
            MinimumLength = HouseTitleMinLength, 
            ErrorMessage =RequiredMessage)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseAddressMaxLength, 
            MinimumLength = HouseAddressMinLength, 
            ErrorMessage = RequiredMessage)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseDescriptionMaxLength, 
            MinimumLength = HouseDescriptionMinLength, 
            ErrorMessage = LengthMessage)]
        public string Description { get; set; } = string.Empty;


        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(decimal),
            HousePricePerMonthMin, 
            HousePricePerMonthMax, 
            ErrorMessage = "Price per month must be a positive number and less than {2} leva" )]
        [Display(Name = "Price Per Month")]
        public decimal PricePerMonth { get; set; }

        [Display(Name = "Category")]
        public int CategoryId {  get; set; }

        public IEnumerable<HouseCategoryServiceModel> Categories { get; set; } = new List<HouseCategoryServiceModel>();
    }
}
