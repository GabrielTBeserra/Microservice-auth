using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AUTH_SERVICE_DOMAIN.Entities.User
{
    [Table("User")]
    public class UserEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("email")]
        public string Email { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Required]
        [Column("lastname")]
        public string LastName { get; set; }
        [Required]
        [Column("password")]
        public string Password { get; set; }
    }
}
