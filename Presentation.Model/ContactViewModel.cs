using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    public class ContactViewModel
    {
        public ContactViewModel()
        {
        }

        [Display(Name = "ContactName")]
        [Required]
        [MaxLength(50, ErrorMessage = "The contact name has a maximum length of 50 characters")]
        public string ContactName { get; set; }

        [Display(Name = "eMail Address")]
        [Required(ErrorMessage = "The eMail Address is a Required field")]
        [MaxLength(254, ErrorMessage = "The Email Address can not be longer than 254 characters")]
        public string ContactEmail { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone number is a Required field")]
        [MaxLength(10, ErrorMessage = "The phone number can not be longer than 10 characters")]
        public string ContactPhoneNumber { get; set; }

        [Display(Name = "Describe your project")]
        [Required(ErrorMessage = "The description is a Required field")]
        [MaxLength(500, ErrorMessage = "The description can not be longer than 10 characters")]
        public string ContactDescription { get; set; }
    }
}
