using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static RentNest.Infrastructure.Constants.DataConstants;


namespace RentNest.Infrastructure.Data.Models
{
    [Comment("House to rent")]
    public class House
    {
        [Key]
        [Comment("House Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        [Comment("House Title")]
        public required string Title { get; set; }

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        [Comment("House address")]

        public required string Address { get; set; }

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        [Comment("House Description")]

        public required string Description { get; set; }

        [Required]
        //[MaxLength(HouseImageMaxLength)]
        [Comment("House Image Url")]

        public required string Image { get; set; }

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        [Column(TypeName =("decimal(18,2)"))]
       // [Range(typeof(decimal), HousePricePerMonthMin, HousePricePerMonthMax, ConvertValueInInvariantCulture = true)]
        [Comment("House Price Per Month")]

        public decimal PricePerMonth { get; set; }

        [Required]
        [Comment("House Category Identifier")]
        public int CategoryId { get; set; }

        [Required]
        [Comment("House Agent Identifier")]
        public int AgentId { get; set; }

        [Required]
        [Comment("Renter Identifier")]
        public string? RenterId { get; set; }


        [ForeignKey(nameof(AgentId))]
        Agent Agent { get; set; } = null!;

        [ForeignKey(nameof(CategoryId))]
        Category Category { get; set; } = null!;

       

    }
}
