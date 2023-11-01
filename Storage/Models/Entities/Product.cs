using System.ComponentModel.DataAnnotations;

namespace Storage.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Price { get; set; } = 0;
        public Category Category { get; set; }
        public string Shelf { get; set; } = string.Empty;
        public int Count { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Order date")]
        public DateTime OrderDate { get; set; }
    }
}
