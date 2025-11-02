namespace OpenAirSim.Core.Models

{
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
        public List<Aircraft> ManufacturedAircraft { get; set; } = new();
        public List<Engine> ManufacturedEngines { get; set; } = new();

        public Manufacturer(string name, string country, string type)
        {
            Name = name;
            Country = country;
            Type = type;
        }
    }
}
