using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    [Table("user_credentials")]
    public class UserCredentials
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("username")]
        public string Username { get; set; }

        [Required]
        [Column("algo")]
        public string Algo { get; set; }

        [Required]
        [Column("iterations")]
        public int Iterations { get; set; }

        [Required]
        [Column("salt_b64")]
        public string SaltB64 { get; set; }

        [Required]
        [Column("dk_len")]
        public int DkLen { get; set; }

        [Required]
        [Column("hash_b64")]
        public string HashB64 { get; set; }
    }
}
