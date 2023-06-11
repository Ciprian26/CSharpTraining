using dotNet_Part3.Entities;

namespace dotNet_Part3 {
    public class ObjectQueries {
        public static List<CustomObject> WhereQuery(List<CustomObject> objects)
        {
            return objects.Where(obj => obj.Name == "Robin").ToList();
        }

        public static CustomObject FirstOrDefaultQuery(List<CustomObject> objects)
        {
            return objects.FirstOrDefault(obj => obj.Name == "Owl");
        }

        public static bool AnyQuery(List<CustomObject> objects)
        {
            return objects.Any(obj => obj.Id >= 5);
        }

        public static List<CustomObject> DistinctQuery(List<CustomObject> objects)
        {
            return objects.Distinct().ToList();
        }

        public static List<IGrouping<string, CustomObject>> GroupByQuery(List<CustomObject> objects)
        {
            return objects.GroupBy(obj => obj.Name).ToList();
        }

        public static List<CustomObject> OrderByQuery(List<CustomObject> objects)
        {   
            return objects.OrderBy(obj => obj.Name).ToList();
        }

        public static List<object> SelectQuery(List<CustomObject> objects)
        {
            return objects.Select(obj => new { obj.Name, obj.Description }).ToList<object>();
        }
    }
}
