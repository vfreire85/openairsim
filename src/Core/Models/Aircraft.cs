namespace OpenAirSim.Core.Models
{
    public class Aircraft
    {
        public string Model { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public List<Engine> Engines { get; set; } = new();
        public double PassengerCapacity { get; set; }
        public double CargoCapacityKg { get; set; }
        public double RangeKm { get; set; }
        public double FuelConsumptionKm { get; set; }
        public int YearIntroduction { get; set;}

        public Aircraft (string model, Manufacturer manufacturer, double passengerCapacity, double cargoCapacityKg, double rangeKm, double fuelConsumptionKm, int yearIntroduction)
        {
            Model = model;
            Manufacturer = manufacturer;
            PassengerCapacity = passengerCapacity;
            CargoCapacityKg = cargoCapacityKg;
            RangeKm = rangeKm;
            FuelConsumptionKm = fuelConsumptionKm;
            YearIntroduction = yearIntroduction;
        }

        public double CalculateEstimatedConsumption(double distanceKm)
        {
            return FuelConsumptionKm * distanceKm;
        }
    }
}
