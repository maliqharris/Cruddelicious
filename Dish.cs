using System.ComponentModel.DataAnnotations;

namespace Dish.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters.")]
        public string Name { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters.")]
        public string Chef { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Tastiness must be between 1 and 10.")]
        public int Tastiness { get; set; }

        [Required]
        public int Calories { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters.")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
