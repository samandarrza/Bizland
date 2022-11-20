using System.ComponentModel.DataAnnotations;

namespace BizLand.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Desc { get; set; }
    }
}
