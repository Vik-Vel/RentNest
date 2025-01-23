﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static RentNest.Infrastructure.Constants.DataConstants;


namespace RentNest.Infrastructure.Data.Models
{
    [Comment("House Agent")]
    public class Agent
    {
        [Key]
        [Comment("Agent Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(AgentPhoneNumberMax)]
        [Comment("Agent Phone Number")]
        public required string PhoneNumber { get; set; }

        [Required]
        [Comment("User Identifier")]
        public required string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public List<House> Houses { get; set;} = new List<House>();
    }
}
