using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Osoba
    {
        public virtual Int64 JMBG { get; protected set; }
        public virtual string Ime_rod { get;  set; }
        public virtual string Prezime { get;  set; }
        public virtual string Licno_ime { get;  set; }
        public virtual DateTime Dat_rodj { get;  set; }
        public virtual string Adresa { get;  set; }
        public virtual int Broj_telefona { get;  set; }
        public virtual int Broj_licne_karte { get;  set; }
        public virtual string Mesto_izdavanja { get; set; }

        public virtual IList<Vozilo> VlasnikVozila { get; set; }

        public Osoba()
        {
            VlasnikVozila = new List<Vozilo>();
        }
    }
}
