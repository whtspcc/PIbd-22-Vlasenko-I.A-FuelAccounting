namespace FuelAccounting.Entities;

// класс связка, здесь и реализовывается связь многие-ко-многим,
// т.е. водитель через FuelingCar связан с несколькими автомобилями, а автомобиль связан с несколькими водителями
// каждая запись FuelingCar фиксирует одну пару «водитель — автомобиль» вместе с топливом и литрами,
// а одна и та же пара может встречаться во многих записях.
public class FuelingCar
{
    public int Id { get; private set; }

    public int FuelId { get; private set; }

    public int DriverId { get; private set; }

    public int CarId { get; private set; }

    public DateTime FuelingDate { get; private set; }

    public double Liters { get; private set; }

    public static FuelingCar CreateOperation(int id, int fuelId, int driverId,
        int carId, double liters)
    {
        return new FuelingCar
        {
            Id = id,
            FuelId = fuelId,
            DriverId = driverId,
            CarId = carId,
            FuelingDate = DateTime.Now,
            Liters = liters
        };
    }
}