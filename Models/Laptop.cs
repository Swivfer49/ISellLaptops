namespace ISellLaptops.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int Year { get; set; }
        public Brand Brand { get; set; }
    }
}
