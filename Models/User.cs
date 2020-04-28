using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class User
    {
        private string firstName;
        private string lastName;
        private string email;
        private DateTime birthday;
        private string dietaryNeed;
        private string password;
        private string passwordConfirm;

        [DisplayName("First Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string FirstName { get => firstName; set => firstName = value; }

        [DisplayName("Last Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("Email")]
        [EmailAddress]
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email is not valid")]
        public string Email { get => email; set => email = value; }

        [DisplayName("Dietary Options")]
        public string DietaryNeed { get => dietaryNeed; set => dietaryNeed = value; }


        [DisplayName("Birthday")]
        [Required]
        public DateTime Birthday { get => birthday; set => birthday = value; }

        [DisplayName("Password")]
        [PasswordPropertyText]
        [Required]
        public string Password { get => password; set => password = value; }

        [DisplayName("Confirm Password")]
        [PasswordPropertyText]
        [Required]
        public string PasswordConfirm { get => passwordConfirm; set => passwordConfirm = value; }
    }
}
