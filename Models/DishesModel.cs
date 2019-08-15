using System.ComponentModel.DataAnnotations;
using System;
namespace CRUDelicious.Models
{
    public class Dish
    {
        public int DishId { get; set; }

        [Required]
        [Display(Name ="Dish Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name= "Chef Name")]
        public string Chef { get; set; }

        [Required]
        [Range(1,5)]
        public int Tastiness { get; set; }

        [Required]
        [Display(Name ="Calories:")]
        [Range(0, 3000)]
        public int Calories { get; set; }

        [Required]
        [Display(Name ="Description")]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}