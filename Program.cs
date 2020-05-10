using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new CarIdentifier(1));

            string json1 = SerializeNewtonsoft<Car>(car);
            Car carDeserialized = DeserializeNewtonsoft<Car>(json1);

            Console.WriteLine(CarIdentifier.None.Identifier);
        }

        static string SerializeNewtonsoft<T>(T instance)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            jsonSerializer.Serialize(writer, instance);
            writer.Flush();
            string json = Encoding.UTF8.GetString(stream.ToArray());
            return json;
        }


        static T DeserializeNewtonsoft<T>(string json)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(json);
            writer.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            JsonTextReader reader = new JsonTextReader(new StreamReader(stream));
            return (T)(object)jsonSerializer.Deserialize<T>(reader);
        }

    }
}
