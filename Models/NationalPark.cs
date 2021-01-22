using System.ComponentModel.DataAnnotations;

namespace NationalParkApi.Models
{
    public class NationalPark
    {
        public int NationalParkId { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        [Required]
        public string Region { get; set; }
    }
}