using System.ComponentModel.DataAnnotations;

namespace ApplicationCRUDCore22.Models
{
    public class AppDbContext
    {
        [Key]
        [Required]
        public int id { set; get; }
        [Required]
        public string name { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Mobile { set; get; }
        [Required]
        public string Address { set; get; }
    }
}
