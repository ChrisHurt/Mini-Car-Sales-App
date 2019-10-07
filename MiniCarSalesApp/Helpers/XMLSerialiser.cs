using System;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

namespace MiniCarSalesApp.Helpers
{
    public static class XMLSerializer
    {
        public static void WriteVehicleXML(Vehicle toSerialize)
        {
            Vehicles vehicles;

            if (File.Exists(Directory.GetCurrentDirectory() + @"/vehicles.xml"))
            {
                vehicles = ReadVehiclesXML();
                int highestId = 0;

                foreach(Car car in vehicles.Cars)
                {
                    if(car.Id > highestId)
                    {
                        highestId = car.Id;
                    }
                }

                toSerialize.Id = highestId + 1;
                Array.Resize(ref vehicles.Cars, vehicles.Cars.Length + 1);
                vehicles.Cars[vehicles.Cars.GetUpperBound(0)] = (Car)toSerialize;

            } else
            {
                toSerialize.Id = 0;
                vehicles = new Vehicles { };
                Array.Resize(ref vehicles.Cars, 1);
                vehicles.Cars[0] = (Car)toSerialize;
            }

            XmlSerializer ser = new XmlSerializer(typeof(Vehicles));

            using (TextWriter writer = new StreamWriter("vehicles.xml"))
            {
                ser.Serialize(writer, vehicles);
            }
        }
        public static Vehicles ReadVehiclesXML()
        {
            string data = File.ReadAllText(Directory.GetCurrentDirectory() + @"/vehicles.xml");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Vehicles));
            using (TextReader reader = new StringReader(data))
            {
                Vehicles result = (Vehicles)xmlSerializer.Deserialize(reader);
                return result;
            }
            
        }
    }
}
