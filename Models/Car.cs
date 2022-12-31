using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepair.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        
        public int ModelId { get; set; }
        [ForeignKey("ModelId")]
        public Model Model { get; set; }
       
        public int Year { get; set; }
       
        public int EngineId { get; set; }
        [ForeignKey("EngineId")]
        public EngineCapacity EngineCapacity { get; set; }
        
        public string? Image { get; set; }
        public double Price { get; set; }
        public double KM { get; set; }
        
        public int GearId { get; set; }
        [ForeignKey("GearId")]
        public Gear Gear { get; set; }
    }
}
