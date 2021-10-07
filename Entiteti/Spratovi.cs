using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Spratovi
    {
        public virtual string Nivo { get; set; }
        public virtual int Redni_broj { get; set; }
        public virtual Zgrada UZgradi { get; set; }
        public Spratovi()
        {

        }
    }
}
