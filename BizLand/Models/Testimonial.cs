using System.ComponentModel.DataAnnotations;

namespace BizLand.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Image { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Position { get; set; }
        [Required]
        [MaxLength(200)]
        public string Desc { get; set; }
    }
}
