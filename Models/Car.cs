using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepair.Models
{
    public class Car
    {
        [Key]
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int EngineCapacity { get; set; }
        //public string Image { get; set; }
        public double Price { get; set; }
        public double KM { get; set; }
        public string Gear { get; set; }
    }
}
