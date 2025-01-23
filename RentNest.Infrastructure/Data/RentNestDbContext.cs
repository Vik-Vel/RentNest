using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentNest.Infrastructure.Data.Models;

namespace RentNest.Infrastructure.Data
{
    public class RentNestDbContext : IdentityDbContext
    {
        public RentNestDbContext(DbContextOptions<RentNestDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<House>()
                   .HasOne(h => h.Category)                 // A house has one category via the Category navigation property
                   .WithMany(c => c.Houses)                 // A category has many houses via the Houses navigation property
                   .HasForeignKey(h => h.CategoryId)        // The relationship is established via the CategoryId field in House
                   .OnDelete(DeleteBehavior.Restrict);      // When deleting a category, the related houses are preserved

            builder.Entity<House>()
                 .HasOne(h => h.Agent)                        // A house has one agent via the Agent navigation property        
                 .WithMany(c => c.Houses)                   // An agent has many houses via the Houses navigation property
                 .HasForeignKey(h => h.AgentId)             // The relationship is established via the AgentId field in House
                 .OnDelete(DeleteBehavior.Restrict);         // When deleting an agent, the related houses are preserved

            base.OnModelCreating(builder);
        }

        public DbSet<Agent> Agents { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<House> Houses { get; set; } = null!;
    }
}
