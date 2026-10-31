using FuelAccounting.Entities;

namespace FuelAccounting.Repositories;

public interface IFuelReplenishmentRepository
{
    IEnumerable<FuelReplenishment> ReadFuelReplenishments(DateTime? dateFrom = null,
        DateTime? dateTo = null, int? fuelId = null, int? driverId = null);

    void CreateFuelReplenishment(FuelReplenishment fuelReplenishment);

    void DeleteFuelReplenishment(int id);
}