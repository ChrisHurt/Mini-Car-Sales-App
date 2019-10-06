using System;
using System.IO;
using System.Xml.Serialization;

namespace MiniCarSalesApp.Helpers
{
    public static class XMLSerializer
    {
     public static void WriteVehicleXML(Vehicle toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                string data = textWriter.ToString();
                string path = Directory.GetCurrentDirectory();
                File.WriteAllText(path + @"/" + toSerialize.Type + ".xml", data);
            }
        }
        public static Vehicle ReadVehicleXML(string vehicleType)
        {
            //string path = Directory.GetCurrentDirectory();
            string data = File.ReadAllText(Directory.GetCurrentDirectory() + @"/" + vehicleType + ".xml");

            XmlSerializer xmlSerializer;

            switch (vehicleType)
            {
                case "undefined":
                    xmlSerializer = new XmlSerializer(typeof(Vehicle));
                    using (TextReader reader = new StringReader(data))
                    {
                        Vehicle result = (Vehicle)xmlSerializer.Deserialize(reader);
                        return result;
                    }
                case "Car":
                    xmlSerializer = new XmlSerializer(typeof(Car));
                    using (TextReader reader = new StringReader(data))
                    {
                        Car result = (Car)xmlSerializer.Deserialize(reader);
                        return result;
                    }
                case "Bike":
                    
                    break;
                case "Boat":

                    break;
            }
            return default(Vehicle);
        }  
    }
}
