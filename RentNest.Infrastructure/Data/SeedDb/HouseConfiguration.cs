using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RentNest.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentNest.Infrastructure.Data.SeedDb
{
    internal class HouseConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder
                  .HasOne(h => h.Category)                 // A house has one category via the Category navigation property
                  .WithMany(c => c.Houses)                 // A category has many houses via the Houses navigation property
                  .HasForeignKey(h => h.CategoryId)        // The relationship is established via the CategoryId field in House
                  .OnDelete(DeleteBehavior.Restrict);      // When deleting a category, the related houses are preserved

            builder
                 .HasOne(h => h.Agent)                        // A house has one agent via the Agent navigation property        
                 .WithMany(c => c.Houses)                   // An agent has many houses via the Houses navigation property
                 .HasForeignKey(h => h.AgentId)             // The relationship is established via the AgentId field in House
                 .OnDelete(DeleteBehavior.Restrict);         // When deleting an agent, the related houses are preserved

            
            var data = new SeedData();

            builder.HasData(new House[] { data.FirstHouse, data.SecondHouse, data.ThirdHouse});
        }
    }
}
