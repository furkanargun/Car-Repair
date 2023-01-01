using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepair.Models
{
    public class Model
    {
        [Key]
        public int ModelID { get; set; }
        public string ModelName { get; set; }
       
        public int BrandID { get; set; }
        [ForeignKey("BrandID")]
        public Brand Brand { get; set; }
       
        //public int Year { get; set; }

        //public int EngineId { get; set; }
        //[ForeignKey("EngineId")]
        //public EngineCapacity EngineCapacity { get; set; }
        ////public string Image { get; set; }
       
        //public double Price { get; set; }
        //public double KM { get; set; }
       
        //public int GearId { get; set; }
        //[ForeignKey("GearId")]
        //public Gear Gear { get; set; }
    }
}
