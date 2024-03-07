using System.ComponentModel.DataAnnotations;

namespace ArkeeroTest.Models
{
    public class Product
    {

        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public double Price { get; set; }

    }
}
