using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data___App.Entities
{
    [Table("cars")]
    public class CarEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(75)]
        public string Model { get; set; }

        [Required]
        [MaxLength(75)]
        public string Producent { get; set; }

        [Required]
        public decimal PojemnoscSilnika { get; set; }

        [Required]
        public int Moc { get; set; }

        [Required]
        [MaxLength(75)]
        public string RodzajSilnika { get; set; }

        [Required]
        [MaxLength(75)]
        public string NrRejestracyjny { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        [MaxLength(75)]
        public string Wlasciciel { get; set; }

        public byte Priorytet { get; set; }


        public int OrganizationId { get; set; }
        public OrganizationEntity? Organization { get; set; }
    }
}
