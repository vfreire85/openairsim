namespace OpenAirSim.Core.Models
{
    public class Airport
    {
        public string IATACode { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public double MainRwyLength { get; set; } // in meters
        public int AnnualPassengerCapacity { get; set; }
        public int InaugurationYear { get; set; }

        public Airport(string iataCode, string name, string country, double mainRwyLength, int annualPassengerCapacity, int inaugurationYear)
        {
            IATACode = iataCode;
            Name = name;
            Country = country;
            MainRwyLength = mainRwyLength;
            AnnualPassengerCapacity = annualPassengerCapacity;
            InaugurationYear = inaugurationYear;
        }
    }
}
