using FuelAccounting.Entities;

namespace FuelAccounting.Repositories;

public interface IFuelingCarRepository
{
    IEnumerable<FuelingCar> ReadFuelingCars(DateTime? dateFrom = null,
        DateTime? dateTo = null, int? fuelId = null,
        int? driverId = null, int? carId = null);

    void CreateFuelingCar(FuelingCar fuelingCar);
}