using dotNet_Part3;
using dotNet_Part3.Entities;
using static dotNet_Part3.FileManager.FileManager;
using static dotNet_Part3.FileManager.PathUtils;

namespace Net_Basic.Part1 {
    static class Program {
        public static void Main(string[] args)
        {
            string inputFilePath = GetInputFilePath();
            string outputFilePath = GetOutputFilePath();

            List<CustomObject> objects = ReadObjectsFromFile(inputFilePath);

            var filteredObjects = ObjectQueries.WhereQuery(objects);
            Console.WriteLine("Filtered Objects:");
            foreach (var obj in filteredObjects)
            {
                Console.WriteLine(obj.Name);
            }

            var firstObject = ObjectQueries.FirstOrDefaultQuery(objects);
            Console.WriteLine("First Object:");
            Console.WriteLine(firstObject.Name);

            var anyObject = ObjectQueries.AnyQuery(objects);
            Console.WriteLine("Any Object satisfying the condition: " + anyObject);

            var distinctObjects = ObjectQueries.DistinctQuery(objects);
            Console.WriteLine("Distinct Objects:");
            foreach (var obj in distinctObjects)
            {
                Console.WriteLine(obj.Name);
            }

            var groupedObjects = ObjectQueries.GroupByQuery(objects);
            Console.WriteLine("Grouped Objects:");
            foreach (var group in groupedObjects)
            {
                Console.WriteLine("Group: " + group.Key);
                foreach (var obj in group)
                {
                    Console.WriteLine(obj.Name);
                }
            }

            var sortedObjects = ObjectQueries.OrderByQuery(objects);
            Console.WriteLine("Sorted Objects:");
            foreach (var obj in sortedObjects)
            {
                Console.WriteLine(obj.Name);
            }

            var selectedObjects = ObjectQueries.SelectQuery(objects);
            Console.WriteLine("Selected Objects:");
            foreach (var obj in selectedObjects)
            {
                Console.WriteLine(obj);
            }

            WriteObjectsToJsonFile(objects, outputFilePath);
        }
    }
}