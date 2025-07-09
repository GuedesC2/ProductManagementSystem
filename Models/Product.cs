using System;

namespace ProductManagementSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal Price { get; set; }
        public string Supplier { get; set; }
        public string EAN { get; set; }
    }
}

