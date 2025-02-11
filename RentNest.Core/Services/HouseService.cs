using Microsoft.EntityFrameworkCore;
using RentNest.Core.Contracts;
using RentNest.Core.Models.Home;
using RentNest.Infrastructure.Data.Common;
using RentNest.Infrastructure.Data.Models;

namespace RentNest.Core.Services
{
    public class HouseService : IHouseService
    {
        private readonly IRepository repository;

        public HouseService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync()
        {
            return await repository
                .AllReadOnly<House>()
                .OrderByDescending(h => h.Id)
                .Take(3)
                .Select(h => new HouseIndexServiceModel
                {
                    Id = h.Id,
                    ImageUrl = h.ImageUrl,
                    Title = h.Title,
                })
                .ToListAsync();

        }
    }
}
