using System.ComponentModel.DataAnnotations;

namespace GovermentSystem.Models
{
    public class Designation
    {
        [Key]
        public int Id { get; set; }
        public string Designations { get; set; }
    }
}
