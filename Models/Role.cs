using System.ComponentModel.DataAnnotations;

namespace GovermentSystem.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Roles { get; set; }
    }
}
