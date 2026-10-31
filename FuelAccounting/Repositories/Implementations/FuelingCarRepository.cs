using FuelAccounting.Entities;

namespace FuelAccounting.Repositories.Implementations;

internal class FuelingCarRepository : IFuelingCarRepository
{
    public void CreateFuelingCar(FuelingCar fuelingCar)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<FuelingCar> ReadFuelingCars(DateTime? dateFrom = null,
        DateTime? dateTo = null, int? fuelId = null,
        int? driverId = null, int? carId = null)
    {
        return [];
    }
}