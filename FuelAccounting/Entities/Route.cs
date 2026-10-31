namespace FuelAccounting.Entities
{
    public class Route
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string StartPoint { get; private set; } = string.Empty;
        public string EndPoint { get; private set; } = string.Empty;
        public double Distance { get; private set; }

        public static Route CreateEntity(int id, string name, string startPoint,
            string endPoint, double distance)
        {
            return new Route
            {
                Id = id,
                Name = name ?? string.Empty,
                StartPoint = startPoint ?? string.Empty,
                EndPoint = endPoint ?? string.Empty,
                Distance = distance
            };
        }
    }
}
