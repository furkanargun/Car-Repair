using System.ComponentModel.DataAnnotations;

namespace CarRepair.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string? CarBrand { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public double EngineCapacity { get; set; }
        public string? Image { get; set; }
        public double Price { get; set; }
        public double KM { get; set; }
        public string Gear { get; set; }
    }
}
