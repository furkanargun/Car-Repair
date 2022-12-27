using System.ComponentModel.DataAnnotations;

namespace CarRepair.Models
{
    public class KM
    {
        [Key]
        public int KmId { get; set; }
        public double Km { get; set; }
    }
}
