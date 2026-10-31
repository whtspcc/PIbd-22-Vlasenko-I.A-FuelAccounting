using FuelAccounting.Entities;
using FuelAccounting.Entities;

namespace FuelAccounting.Repositories;

public interface IFuelRepository
{
    IEnumerable<Fuel> ReadFuels();

    Fuel ReadFuelById(int id);

    void CreateFuel(Fuel fuel);

    void UpdateFuel(Fuel fuel);

    void DeleteFuel(int id);
}