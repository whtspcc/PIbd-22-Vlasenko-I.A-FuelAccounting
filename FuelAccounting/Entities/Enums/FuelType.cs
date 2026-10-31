namespace FuelAccounting.Entities.Enums
{
    [Flags]
    public enum FuelType
    {
        None = 0,

        AI92 = 1,

        AI95 = 2,

        Diesel = 3,

        Gas = 8
    }
}
