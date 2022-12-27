using System.ComponentModel.DataAnnotations;

namespace CarRepair.Models
{
    public class Model
    {
        [Key]
        public int ModelId { get; set; }
        public string? ModelName { get; set; }
        public string Color { get; set; }
        public double EngineCapacity { get; set; } 

    }
}
