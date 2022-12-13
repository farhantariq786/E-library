using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ELibrary.Models
{
    public class DataModel
    {
        [Key]
        public int StdId { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [StringLength(12)]
        [Required(ErrorMessage = "Maximum Data must be between 12 Characters only")]
        [Column(TypeName ="nvarchar(12)")]
        public string Name { get; set; }

        [RegularExpression(".+.\\..+", ErrorMessage = "Email Format is seems Wrong")]
        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Email { get; set; }

        [Required]

        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm Password and Password should be same")]
        public string ConfirmPassword { get; set; }

        
        [Required]
        public DateTime Age { get; set; }

    }
}
