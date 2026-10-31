using FuelAccounting.Entities;

namespace FuelAccounting.Repositories.Implementations;

internal class CarRepository : ICarRepository
{
    public void CreateCar(Car car)
    {
        throw new NotImplementedException();
    }

    public void DeleteCar(int id)
    {
        throw new NotImplementedException();
    }

    public Car ReadCarById(int id)
    {
        return Car.CreateEntity(0, string.Empty, string.Empty, 0, 0);
    }

    public IEnumerable<Car> ReadCars()
    {
        return [];
    }

    public void UpdateCar(Car car)
    {
        throw new NotImplementedException();
    }
}