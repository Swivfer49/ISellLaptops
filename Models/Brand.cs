﻿namespace ISellLaptops.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Laptop> Laptops { get; set; } = null!;
    }
}
