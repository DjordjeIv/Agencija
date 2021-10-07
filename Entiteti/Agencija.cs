using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Agencija
    {
        
        public virtual int Sifra { get; set; }
        public virtual int Period_trajanja { get; set; }
        public virtual DateTime Datum_potpisa { get; set; }
        public virtual IList<Zaposleni> ZaposlenRadnik { get; set; }
        public virtual IList<Zgrada> Zgrade { get; set; }

        public Agencija()
        {
            ZaposlenRadnik = new List<Zaposleni>();
            Zgrade = new List<Zgrada>();
        }
    }
}
