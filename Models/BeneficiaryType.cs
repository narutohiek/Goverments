using System.ComponentModel.DataAnnotations;

namespace GovermentSystem.Models
{
    public class BeneficiaryType
    {
        [Key]
        public int Id { get; set; }
        public string BeneficiaryTypes { get; set; }
    }
}
