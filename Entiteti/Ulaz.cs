using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Ulaz
    {
        public virtual int Id { get; set; }
        public virtual int REDNI_BROJ { get; set; }
        public virtual int VREME_OTVOREN { get; set; }
        public virtual string INSTALIRANA_KAMERA { get; set; }
        public virtual Zgrada UlazUZgradu { get; set; }
        public Ulaz()
        {

        }
    }
}
