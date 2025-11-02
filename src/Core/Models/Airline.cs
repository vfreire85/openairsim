namespace OpenAirSim.Core.Models
{
    public class Airline
    {
        public string Name { get; set; }
        public double Cash { get; set; }
        public double Reputation { get; set; }
        public List<Aircraft> Fleet { get; set; } = new();
        public List<Airport> AirportsServed { get; set; } = new();

        public Airline(string name, double startingCash)
        {
            Name = name;
            Cash = startingCash;
            Reputation = 50.0;
        }

        public void AddAircraft(Aircraft aircraft)
        {
            Fleet.Add(aircraft);
        }

        public void RegisterAirport(Airport airport)
        {
            AirportsServed.Add(airport);
        }
    }
}
