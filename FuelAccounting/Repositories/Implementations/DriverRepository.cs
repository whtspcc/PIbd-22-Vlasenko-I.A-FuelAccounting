using FuelAccounting.Entities;
using FuelAccounting.Entities.Enums;

namespace FuelAccounting.Repositories.Implementations;

internal class DriverRepository : IDriverRepository
{
    public void CreateDriver(Driver driver)
    {
        throw new NotImplementedException();
    }

    public void DeleteDriver(int id)
    {
        throw new NotImplementedException();
    }

    public Driver ReadDriverById(int id)
    {
        return Driver.CreateEntity(0, string.Empty, string.Empty, CarCategory.None);
    }

    public IEnumerable<Driver> ReadDrivers()
    {
        return [];
    }

    public void UpdateDriver(Driver driver)
    {
        throw new NotImplementedException();
    }
}