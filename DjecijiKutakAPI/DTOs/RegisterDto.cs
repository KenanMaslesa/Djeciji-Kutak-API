using System.ComponentModel.DataAnnotations;

namespace DjecijiKutakAPI.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Ime je obavezno polje")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Prezime je obavezno polje")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email je obavezno polje")]
        [EmailAddress(ErrorMessage = "Unesite validnu email adresu")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lozinka je obavezno polje")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Molimo Vas potvrdite loziku")]
        [Compare("Password", ErrorMessage = "Lozinke se ne podudaraju")]
        public string ConfirmPassword { get; set; }

    }
}