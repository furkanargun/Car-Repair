using System.ComponentModel.DataAnnotations;

namespace CarRepair.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}