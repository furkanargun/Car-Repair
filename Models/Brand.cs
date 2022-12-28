using System.ComponentModel.DataAnnotations;

namespace CarRepair.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        public string? BrandName { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
    }
}
