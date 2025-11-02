using System.Text.Json;
using OpenAirSim.Core.Models;

namespace OpenAirSim.Core.Managers
{
    public class DataManager
    {
        public List<Manufacturer> Manufacturers { get; private set; } = new();
        public List<Aircraft> Aircrafts { get; private set; } = new();
        public List<Airport> Airports { get; private set; } = new();
        public List<Airline> Airlines { get; private set; } = new();

        private readonly string _dataPath;

        public DataManager(string dataPath)
        {
            _dataPath = dataPath;
        }

        public void LoadData()
        {
            Console.WriteLine("Loading OpenAirSim data...");

            Manufacturers = LoadFile<List<Manufacturer>>("manufacturers.json");
            Airports = LoadFile<List<Airport>>("airports.json");
            Aircrafts = LoadFile<List<Aircraft>>("aircrafts.json");
            Airlines = LoadFile<List<Airline>>("airlines.json");

            Console.WriteLine($"Manufacturers: {Manufacturers.Count}, Aircraft: {Aircrafts.Count}, Airports: {Airports.Count}, Airlines: {Airlines.Count} ");
        }

        private T LoadFile<T>(string fileName)
        {
            string fullPath = Path.Combine(_dataPath, fileName);
            if (!File.Exists(fullPath))
            {
                Console.WriteLine($"[Warning] File {fileName} not found in {_dataPath}. Returning empty object.");
                return Activator.CreateInstance<T>();
            }

            string json = File.ReadAllText(fullPath);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<T>(json, options)!;
        }

        public Manufacturer? ObtainManufacturerByName(string name)
        {
            return Manufacturers.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public Aircraft? ObtainAircraftByModel(string model)
        {
            return Aircrafts.FirstOrDefault(a => a.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
        }

        public Airport? ObtainAirportByCode(string code)
        {
            return Airports.FirstOrDefault(a => a.IATACode.Equals(code, StringComparison.OrdinalIgnoreCase));
        }

        public Airline? ObtainAirlineByName(string name)
        {
            return Airlines.FirstOrDefault(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
