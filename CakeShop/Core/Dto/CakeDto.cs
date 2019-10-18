using System.ComponentModel.DataAnnotations;

namespace CakeShop.Core.Dto
{
    public class CakeDto
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Cake Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Short Description")]
        [MaxLength(50)]
        public string ShortDescription { get; set; }

        [Required]
        [Display(Name = "Long Description")]
        [MaxLength(255)]
        public string LongDescription { get; set; }

        //Calories property for the admins to edit. The type is integer so only integers can be entered for the ammount of calories in each cake.
        [Required]
        [Display(Name = "Calories")]
        public int Calories { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }

        [Display(Name = "Is Cake Of the Week? ")]
        public bool IsCakeOfTheWeek { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
    }
}
