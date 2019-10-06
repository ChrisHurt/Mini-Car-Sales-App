using System;
using System.Diagnostics;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using MiniCarSalesApp.Helpers;

namespace MiniCarSalesApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RunUnitTests();

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static void RunUnitTests()
        {
            // Testing properties of Vehicle class
            Vehicle vehicle = new Vehicle();
            vehicle.Make = "Ford";
            vehicle.Model = "Focus Trend";
            vehicle.Type = VehicleType.undefined;

            Console.WriteLine("Testing make property of vehicle...");
            Debug.Assert(vehicle.Make == "Ford", "Error: could not set make of vehicle");
            Console.WriteLine("Make property successfully set to: " + vehicle.Make);

            Console.WriteLine("Testing model property of vehicle...");
            Debug.Assert(vehicle.Model == "Focus Trend", "Error: could not set model of vehicle");
            Console.WriteLine("Model property successfully set to: " + vehicle.Model);

            Console.WriteLine("Testing VehicleType property of vehicle...");
            Debug.Assert(vehicle.Type == VehicleType.undefined, "Error: could not set make of vehicle");
            Console.WriteLine("VehicleType property successfully set to: " + vehicle.Type);

            // Testing properties of Car class
            Car car = new Car();
            car.Make = "Ford";
            car.Model = "Focus Trend";
            car.Type = VehicleType.car;
            car.BodyType = "Hatch";
            car.Engine = "1.5L Turbo";
            car.Doors = 4;
            car.Wheels = 4;


            Console.WriteLine("Testing Make property of car...");
            Debug.Assert(car.Make == "Ford", "Error: could not set Make of car");
            Console.WriteLine("Make property successfully set to: " + car.Make);

            Console.WriteLine("Testing Model property of car...");
            Debug.Assert(car.Model == "Focus Trend", "Error: could not set Model of car");
            Console.WriteLine("Model property successfully set to: " + car.Model);

            Console.WriteLine("Testing VehicleType property of car...");
            Debug.Assert(car.Type == VehicleType.car, "Error: could not set Make of car");
            Console.WriteLine("carType property successfully set to: " + car.Type);

            Console.WriteLine("Testing BodyType property of car...");
            Debug.Assert(car.BodyType == "Hatch", "Error: could not set Make of car");
            Console.WriteLine("BodyType property successfully set to: " + car.BodyType);

            Console.WriteLine("Testing Engine property of car...");
            Debug.Assert(car.Engine == "1.5L Turbo", "Error: could not set Engine of car");
            Console.WriteLine("Engine property successfully set to: " + car.Engine);

            Console.WriteLine("Testing Doors property of car...");
            Debug.Assert(car.Doors == 4, "Error: could not set Doors of car");
            Console.WriteLine("Doors property successfully set to: " + car.Doors);

            Console.WriteLine("Testing Wheels property of car...");
            Debug.Assert(car.Wheels == 4, "Error: could not set Wheels of car");
            Console.WriteLine("Wheels property successfully set to: " + car.Wheels);

            // Testing XML serialisation and deserialisation

            Console.WriteLine("Testing XML Serialization of vehicle...");
            XMLSerializer.WriteVehicleXML(vehicle);
            Vehicle readVehicle = XMLSerializer.ReadVehicleXML("undefined");
            Debug.Assert(readVehicle.Make == "Ford");
            Console.WriteLine("XML Serialization of vehicle succeeded.");

            Console.WriteLine("Testing XML Serialization of car...");
            XMLSerializer.WriteVehicleXML(car);
            Car readCar = (Car)XMLSerializer.ReadVehicleXML("Car");
            Debug.Assert(readCar.Doors == 4);
            Console.WriteLine("XML Serialization of car succeeded.");


        }
    }
}
