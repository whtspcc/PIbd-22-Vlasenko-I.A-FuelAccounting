using FuelAccounting.Entities.Enums;

namespace FuelAccounting.Entities;

public class Driver
{
    public int Id { get; private set; }

    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    public CarCategory CarCategory { get; private set; }

    public static Driver CreateEntity(int id, string first, string last,
        CarCategory carCategory)
    {
        return new Driver
        {
            Id = id,
            FirstName = first ?? string.Empty,
            LastName = last ?? string.Empty,
            CarCategory = carCategory
        };
    }
}