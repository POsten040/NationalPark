using System.ComponentModel.DataAnnotations;

namespace NationalParkApi.Models
{
    public class StatePark
    {
        public int StateParkId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool Free { get; set; }
    }
}