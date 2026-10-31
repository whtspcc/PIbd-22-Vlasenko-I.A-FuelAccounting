using FuelAccounting.Entities.Enums;

namespace FuelAccounting.Entities
{
    public class Fuel
    {
        public int Id { get; private set; }

        public FuelType FuelType { get; private set; }

        public string Name { get; private set; } = string.Empty;

        public string Description { get; private set; } = string.Empty;

        public static Fuel CreateEntity(int id, FuelType fuelType, string name,
            string description)
        {
            return new Fuel
            {
                Id = id,
                FuelType = fuelType,
                Name = name ?? string.Empty,
                Description = description ?? string.Empty
            };
        }
    }
}
    