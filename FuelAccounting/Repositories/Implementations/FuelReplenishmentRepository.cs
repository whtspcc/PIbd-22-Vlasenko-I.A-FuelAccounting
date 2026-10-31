using FuelAccounting.Entities;

namespace FuelAccounting.Repositories.Implementations;

internal class FuelReplenishmentRepository : IFuelReplenishmentRepository
{
    public void CreateFuelReplenishment(FuelReplenishment fuelReplenishment)
    {
        throw new NotImplementedException();
    }

    public void DeleteFuelReplenishment(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<FuelReplenishment> ReadFuelReplenishments(DateTime? dateFrom = null,
        DateTime? dateTo = null, int? fuelId = null, int? driverId = null)
    {
        return [];
    }
}