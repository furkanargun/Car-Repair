using System.ComponentModel.DataAnnotations;

namespace CarRepair.Models
{
    public class Gear
    {
        [Key]
        public int Id { get; set; }
        public string GearType { get; set; }
    }
}
