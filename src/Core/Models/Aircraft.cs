using System.Collections.Generic;

namespace OpenAirSim.Core.Models
{
    // <summary>
    // Describes what an in-game aircraft is, with basic, technical and economic information.
    // </summary>
    public class Aircraft
    {
        // Basic information
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Family { get; set; }
        public int YearIntroduction { get; set;}

        // Engines
        public List<Engine> Engines { get; set; } = new List<Engine>();

        // Technical data
        public double CruiseSpeedKm { get; set; }
        public double MaxTakeOffWeightKg { get; set; }
        public double EmptyWeightKg { get; set; }
        public double FuelCapacityKg { get; set; }
        public int PassengerCapacity { get; set; }
        public double CargoCapacityKg { get; set; }
        public double RangeKm { get; set; }

        // Economics and operational data
        public double FuelConsumptionPerHour => CalculateFuelConsumption();
        public double MaintenanceCostPerHour { get; set; }
        public double BasePrice { get; set; }

        public Aircraft (string model,
                         string manufacturer,
                         string family,
                         int yearIntroduction,
                         double cruiseSpeedKm,
                         double maxTakeOffWeightKg,
                         double emptyWeightKg,
                         double fuelCapacityKg,
                         int passengerCapacity,
                         double cargoCapacityKg,
                         double rangeKm,
                         double maintenanceCostPerHour,
                         double basePrice
            )
        {
            Model = model;
            Manufacturer = manufacturer;
            Family = family;
            YearIntroduction = yearIntroduction;
            CruiseSpeedKm = cruiseSpeedKm;
            MaxTakeOffWeightKg = maxTakeOffWeightKg;
            EmptyWeightKg = emptyWeightKg;
            FuelCapacityKg = fuelCapacityKg;
            PassengerCapacity = passengerCapacity;
            CargoCapacityKg = cargoCapacityKg;
            RangeKm = rangeKm;
            MaintenanceCostPerHour = maintenanceCostPerHour;
            BasePrice = basePrice;
        }

        // <sumamry>
        // Adds an engine to this aircraft.
        // <//summary>
        public void AddEngine(Engine engine)
        {
            if(engine != null)
                Engines.Add(engine);
        }

        // <summary>
        // Estimates total fuel consumption per hour based on number of engines and efficiency.
        // </summary>
        private double CalculateFuelConsumption()
        {
            double total = 0;
            foreach (var engine in Engines)
                total += engine.ConsumptionPerHour;
            return total;
        }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} (Family: {Family}) - {PassengerCapacity} pax, {Engines.Count} engines";
        }
    }
}
