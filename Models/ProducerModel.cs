using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Models
{
    public class ProducerModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First name should be between 3 to 50 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name should be between 3 to 50 characters")]
        public string LastName { get; set; }

        [Display(Name = "Actors Bio")]
        [Required(ErrorMessage = "Actor's bio is required")]
        public string Bio { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Actor's bio is required")]
        public string ProfilePictureURL { get; set; }
        //Relationships

        public List<MovieModel> Movies { get; set; }
    }
}
