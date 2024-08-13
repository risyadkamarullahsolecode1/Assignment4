using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(1)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MinLength(1), MaxLength(20)]
        public int NoHp { get; set; } 
    }
}
