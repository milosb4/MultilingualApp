using System.ComponentModel.DataAnnotations;

namespace ELL.Web.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter your email adress")]
        [EmailAddress(ErrorMessage = "Please enter a valid email adress")]
        public string Email { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage ="Your message must be 500 characters or less")]
        public string Message { get; set; }

    }
}