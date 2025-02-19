using RentNest.Core.Models.Home;
using RentNest.Core.Models.House;

namespace RentNest.Core.Contracts
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync();
        Task<IEnumerable<HouseCategoryServiceModel>> AllCategoriesAsync();
        Task<bool> CategoryExistsAsync(int categoryId);
        Task<int> CreateAsync(HouseFormModel model, int agentId);

    }
}
