﻿using System.ComponentModel.DataAnnotations;

namespace CakeShop.Core.Models
{
    public class Cake
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(255)]
        public string LongDescription { get; set; }

        [Required]
        [StringLength(255)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(255)]
        public bool IsCakeOfTheWeek { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //Property for calories in the cake as it is displayed to users. Note that this is not actually displaying it, this just is the value that is displayed. 
        [Required]
        [Display(Name = "Calories")]
        public int Calories { get; set; }

    }
}
