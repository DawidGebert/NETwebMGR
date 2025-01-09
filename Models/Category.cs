using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FunnyWebRazor.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Title")]
        public string Name { get; set; }

        [Range(1, 10, ErrorMessage = "  Rating should be 1-10")]
        [DisplayName("Rating")]
        public int Rating { get; set; }

        [MaxLength(500)]
        [DisplayName("Review")]
        public string Review { get; set; }
    }
}
