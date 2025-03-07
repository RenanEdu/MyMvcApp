using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }

    }
}