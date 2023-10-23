using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Car
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nie podano nazwy modelu")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Nie podano nazwy producenta")]
        public string Producent { get; set; }
        [Required(ErrorMessage ="Nie podano pojemności silnika")]
        public decimal PojemmoscSilnika { get; set; }
        [Required(ErrorMessage ="Nie podano mocy")]
        public int Moc { get; set; }
        [Required(ErrorMessage ="Nie podano rodzaju silnika")]
        public string RodzajSilnika { get; set; }
        [Required(ErrorMessage ="Nie podano numeru rejestracyjnego")]
        public string NrRejestracyjny { get; set; }
        [Required(ErrorMessage ="Nie podano nazwy właściciela")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",ErrorMessage ="Niepoprawna nazwa")]
        public string Wlasciciel { get; set; }

        [HttpGet]
        public String Edit(int? id)
        {
            return "Edycja " + id;
        }
    }
}
