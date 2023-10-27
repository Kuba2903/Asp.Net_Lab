using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Car
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nie podano nazwy modelu")]
        [Display(Name = "Model samochodu")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Nie podano nazwy producenta")]
        [Display(Name = "Producent samochodu")]
        public string Producent { get; set; }
        [Required(ErrorMessage ="Nie podano pojemności silnika")]
        [Display(Name = "Pojemność silnika")]
        public decimal PojemmoscSilnika { get; set; }
        [Required(ErrorMessage ="Nie podano mocy")]
        [Display(Name = "Moc")]
        public int Moc { get; set; }
        [Required(ErrorMessage ="Nie podano rodzaju silnika")]
        [Display(Name = "Rodzaj silnika")]
        public string RodzajSilnika { get; set; }
        [Required(ErrorMessage ="Nie podano numeru rejestracyjnego")]
        [Display(Name = "Numer rejestracyjny")]
        public string NrRejestracyjny { get; set; }
        [Required(ErrorMessage ="Nie podano nazwy właściciela")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",ErrorMessage ="Niepoprawna nazwa")]
        [Display(Name = "Właściciel samochodu")]
        public string Wlasciciel { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        [HttpGet]
        public String Edit(int? id)
        {
            return "Edycja " + id;
        }
    }
}
