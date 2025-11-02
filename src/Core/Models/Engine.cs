namespace OpenAirSim.Core.Models
{
    public class Engine
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double Thrust { get; set; }
        public double ConsumptionPerHour { get; set; }

        public Engine(string model, string manufacturer, double thrust, double consumption)
        {
            Model = model;
            Manufacturer = manufacturer;
            Thrust = thrust;
            ConsumptionPerHour = consumption;
        }
    }
}
