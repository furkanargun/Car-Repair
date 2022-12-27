using System.ComponentModel.DataAnnotations;

namespace CarRepair.Models
{
    public class EngineCapacity
    {
        [Key]
        public int EngineId { get; set; }
        public double Capacity { get; set; }
    }
}
