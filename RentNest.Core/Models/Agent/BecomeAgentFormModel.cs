using System.ComponentModel.DataAnnotations;
using static RentNest.Core.Constants.MessageConstants;
using static RentNest.Infrastructure.Constants.DataConstants;

namespace RentNest.Core.Models.Agent
{
    //Go into interface
    public class BecomeAgentFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(AgentPhoneNumberMaxLength,
            MinimumLength = AgentPhoneNumberMinLength,
            ErrorMessage = LengthMessage)]
        [Display(Name = "Phone number")]
        [Phone]
        public string PhoneNumber { get; set; } = null!;
    }
}
