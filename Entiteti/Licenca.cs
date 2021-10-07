using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Licenca
    {
        public virtual DateTime DATUM_STICANJA_OBNAVLJANJA { get; set; }
        public virtual int BROJ_LICENCE { get; protected set; }
        public virtual string NAZIV_INSTITUCIJE { get; set; }
        public virtual IList<Upravnici> Upravnici { get; set; }

        public Licenca()
        {
            Upravnici = new List<Upravnici>();
        }
    }
}
