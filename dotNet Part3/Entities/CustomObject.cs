namespace dotNet_Part3.Entities
{
    public class CustomObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}";
        }
    }
}
