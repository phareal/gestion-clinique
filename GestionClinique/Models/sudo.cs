using System.ComponentModel.DataAnnotations;

namespace GestionClinique.Models
{
    public class sudo
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}