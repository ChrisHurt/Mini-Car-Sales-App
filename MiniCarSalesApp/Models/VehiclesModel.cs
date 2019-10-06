using System;

namespace MiniCarSalesApp
{
    public enum VehicleType
    {
        undefined, car, boat, bike
    }
    [Serializable]
    public class Vehicle
    {
        public int Id { get; set; }
        public VehicleType Type { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
    [Serializable]
    public class Car : Vehicle
    {
        public string BodyType { get; set; }
        public string Engine { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
    }
}