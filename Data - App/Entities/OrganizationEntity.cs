using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data___App.Entities
{
    public class OrganizationEntity
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Region { get; set; }
        public string Nip { get; set; }
        public Address? Address { get; set; }
        public ISet<CarEntity> Cars { get; set; }

    }
}
