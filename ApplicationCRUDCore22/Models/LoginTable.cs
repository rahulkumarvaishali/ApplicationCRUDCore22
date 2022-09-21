using System.ComponentModel.DataAnnotations;

namespace ApplicationCRUDCore22.Models
{
    public class LoginTable
    {
        [Key]
        [Required]
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Password { set; get; }
    }
}
