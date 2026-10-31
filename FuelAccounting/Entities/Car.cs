using FuelAccounting.Entities.Enums;

namespace FuelAccounting.Entities;

public class Car
{
    public int Id { get; private set; }

    public string LicensePlate { get; private set; } = string.Empty;

    public string Model { get; private set; } = string.Empty;

    public CarCategory CarCategory { get; private set; }

    public double TankCapacity { get; private set; }

    public static Car CreateEntity(int id, string licensePlate, string model,
        CarCategory carCategory, double tankCapacity)
    {
        return new Car
        {
            Id = id,
            LicensePlate = licensePlate ?? string.Empty,
            Model = model ?? string.Empty,
            CarCategory = carCategory,
            TankCapacity = tankCapacity
        };
    }
}