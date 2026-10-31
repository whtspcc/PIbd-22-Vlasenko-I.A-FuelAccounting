namespace FuelAccounting.Entities;

public class FuelReplenishmentItem
{
    public int Id { get; private set; }

    public int FuelId { get; private set; }

    public double Liters { get; private set; }      

    public static FuelReplenishmentItem CreateElement(int id, int fuelId,
        double liters)
    {
        return new FuelReplenishmentItem
        {
            Id = id,
            FuelId = fuelId,
            Liters = liters
        };
    }
}