using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Models
{
    public class ProductViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]

        public string Color { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        [Range(0, 100)]
        public int Amount { get; set; }
        // prop => tab 2 times
    }
}
