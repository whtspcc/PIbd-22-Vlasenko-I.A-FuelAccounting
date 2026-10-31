using FuelAccounting.Entities;

namespace FuelAccounting.Entities;

public class FuelReplenishment
{
    public int Id { get; private set; }

    public int DriverId { get; private set; }

    public DateTime DateReceipt { get; private set; }

    public IEnumerable<FuelReplenishmentItem> FuelFuelReplenishments { get; private set; } = [];

    public static FuelReplenishment CreateOperation(int id, int driverId,
        IEnumerable<FuelReplenishmentItem> fuelFuelReplenishments)
    {
        return new FuelReplenishment
        {
            Id = id,
            DriverId = driverId,
            DateReceipt = DateTime.Now,
            FuelFuelReplenishments = fuelFuelReplenishments
        };
    }
}