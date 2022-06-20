using System.ComponentModel.DataAnnotations;

namespace Pustok_Project.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Icon { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Text { get; set; }
    }
}
