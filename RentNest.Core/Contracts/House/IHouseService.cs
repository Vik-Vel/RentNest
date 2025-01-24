using RentNest.Core.Models.Home;

namespace RentNest.Core.Contracts.House
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses();
    }
}
