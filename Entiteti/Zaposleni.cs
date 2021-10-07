using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Zaposleni : Osoba
    {
        public virtual Agencija Sifra { get; set; }

        public Zaposleni()
        {
        }
    }
}
