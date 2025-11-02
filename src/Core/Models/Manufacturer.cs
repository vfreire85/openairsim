using System.Collections.Generic

namespace OpenAirSim.Core.Models
{
    // <summary>
    // Defines a manufacturer of aircraft or engines.
    // </summary>
    public class Manufacturer
    {
        // <summary>
        // Basic information.
        // </summary>
        public string Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        // <summary>
        // This defines some practical aspects of choosing some aircraft or engine over others.
        // </summary>
        public double Reputation { get; set; }
        public double SupportQuality { get; set; }
        public double MaintenanceCommonalityFactor { get; set; }
        // <summary>
        // Lists of models manufactured
        // </summary>
        public List<Aircraft> AircraftModels { get; set; } = new();
        public List<Engine> EngineModels { get; set; } = new();

        public Manufacturer(string name, string country, string description = "",
                            double reputation = 50.0, double supportQuality = 50.0,
                            double commonality = 1.0
            )
        {
            Name = name;
            Country = country;
            Description = description;
            Reputation = reputation;
            SupportQuality = supportQuality;
            MaintenanceCommonalityFactor = commonality;
        }
        // <summary>
        // Adds new aircraft to manufacturer.
        // </summary>
        public void AddAircraft(Aircraft aircraft)
        {
            if(aircraft != null)
                AircraftModels.Add(aircraft);
        }
        // <summary>
        // Adds new engine to manufacturer.
        // </summary>
        public void AddEngine(Engine engine)
        {
            if(engine != null)
                EngineModels.Add(engine);
        }

        public override string ToString()
        {
            return $"{Name} ({Country}) - {AircraftModels.Count} aircraft, {EngineModels.Count} engines";
        }
    }
}
