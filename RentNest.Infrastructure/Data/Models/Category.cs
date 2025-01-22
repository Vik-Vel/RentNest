using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static RentNest.Infrastructure.Constants.DataConstants;

namespace RentNest.Infrastructure.Data.Models
{
    [Comment("Category of house")]
    public class Category
    {
        [Key]
        [Comment("Category Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameLength)]
        [Comment("Category Name")]

        public required string Name { get; set; }

        public List<House> Houses { get; set; } = new List<House>();
    }
}
