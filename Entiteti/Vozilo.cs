using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Vozilo
    {
        public virtual int REG_BROJ { get;  set; }
        public virtual Osoba JMBGOsobe { get; set; }
        public virtual IList<Garaza> RezUGaraze { get; set; }

        public Vozilo()
        {
            RezUGaraze = new List<Garaza>();
        }
    }
}
