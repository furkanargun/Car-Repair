using System.ComponentModel.DataAnnotations;

namespace CarRepair.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
}