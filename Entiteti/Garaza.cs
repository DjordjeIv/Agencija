using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Garaza : Spratovi
    {
        public virtual Vozilo RezZaVozila { get; set; }
        public Garaza()
        {

        }
    }
}
