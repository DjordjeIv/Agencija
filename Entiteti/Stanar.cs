using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Stanar : Osoba
    {
        public virtual IList<Stan> Stanuje { get; set; }
        public Stanar()
        {
            Stanuje = new List<Stan>();
        }
    }
}
