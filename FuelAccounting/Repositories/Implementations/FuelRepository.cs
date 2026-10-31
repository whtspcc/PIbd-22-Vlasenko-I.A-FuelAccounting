using FuelAccounting.Entities;
using FuelAccounting.Entities;
using FuelAccounting.Entities.Enums;

namespace FuelAccounting.Repositories.Implementations;

internal class FuelRepository : IFuelRepository
{
    public void CreateFuel(Fuel fuel)
    {
        throw new NotImplementedException();
    }

    public void DeleteFuel(int id)
    {
        throw new NotImplementedException();
    }

    public Fuel ReadFuelById(int id)
    {
        return Fuel.CreateEntity(0, FuelType.None, string.Empty, string.Empty);
    }

    public IEnumerable<Fuel> ReadFuels()
    {
        return [];
    }

    public void UpdateFuel(Fuel fuel)
    {
        throw new NotImplementedException();
    }
}