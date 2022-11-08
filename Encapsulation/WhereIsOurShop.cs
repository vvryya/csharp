namespace Encapsulation
{
    class GeoLocation
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        double _latitude;
        double _longitude;

        public GeoLocation(double lat, double lng)
        {
            _latitude = lat;
            _longitude = lng;
        }
    }

    class Shop
    {
        public string Name { get; private set; }
        public decimal LastMonthRevenue { get; private set; }
        public GeoLocation Location { get; private set; }

        string _name;
        decimal _lastMonthRevenue;
        GeoLocation _location;

        public Shop(string name, decimal lastMonthRevenue, GeoLocation location)
        {
            _name = name;
            _lastMonthRevenue = lastMonthRevenue;
            _location = location;
        }
    }

    class CWithMain
    {
        static void Main(string[] args)
        { }
    }
}
