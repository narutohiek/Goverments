using System.ComponentModel.DataAnnotations;

namespace GovermentSystem.Models
{
    public class Barangay 
    {
        [Key]
        public int Id { get; set; }
        public string Barangays { get; set; }
    }
}
