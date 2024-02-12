using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Exam.ApplicationCore.Domain
{
    public class Utilisateur
    {
        [Key]
        public int UtilisateurId { get; set; } // Primary Key

        [Required]
        public string? Nom { get; set; }

        [Required]
        [StringLength(50)]
        public string? Username { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [Category("Security")]
        [PasswordPropertyText(true)]
        public string? Password { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
