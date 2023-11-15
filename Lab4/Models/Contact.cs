using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab4.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać imię!")]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [Required(ErrorMessage = "Proszę podać poprawny eamil!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Temat")]
        public string Subject { get; set; }

        [MinLength(length: 5, ErrorMessage = "Wiadomość musi mieć co najmniej 5 znaków!")]
        [Required(ErrorMessage = "Proszę wpisz wiadomość!")]
        [Display(Name = "Wiadomość")]
        public string Message { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }


        [HiddenInput]
        [Display(Name = "Utworzono")]
        public DateTime Created { get; set; }

    }
}
