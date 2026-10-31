using FuelAccounting.Entities;

namespace FuelAccounting.Repositories;

public interface ICarRepository
{
    IEnumerable<Car> ReadCars();

    Car ReadCarById(int id);

    void CreateCar(Car car);

    void UpdateCar(Car car);

    void DeleteCar(int id);
}