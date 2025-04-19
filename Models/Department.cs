using System.ComponentModel.DataAnnotations;

namespace GovermentSystem.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Departments { get; set; }
    }
}
