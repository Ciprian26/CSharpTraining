using dotNet_Part3.Entities;
using System.Text.Json;

namespace dotNet_Part3.FileManager
{
    public class FileManager
    {
        public static List<CustomObject> ReadObjectsFromFile(string filePath)
        {
            Console.WriteLine("Reading objects from " + filePath);
            List<CustomObject> objects = new List<CustomObject>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] properties = line.Split('|');

                CustomObject obj = new CustomObject
                {
                    Id = int.Parse(properties[0]),
                    Name = properties[1],
                    Description = properties[2]
                };

                objects.Add(obj);
            }
            Console.WriteLine("Done reading");
            return objects;
        }

        public static void WriteObjectsToJsonFile(List<CustomObject> objects, string filePath)
        {
            Console.WriteLine("Writing objects in JSON format in file " + filePath);
            string json = JsonSerializer.Serialize(objects, new JsonSerializerOptions { WriteIndented = true });

            if (!File.Exists(filePath))
            {
                string directoryPath = Path.GetDirectoryName(filePath);
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(filePath, json);
            Console.WriteLine("Done.");
        }
    }
}