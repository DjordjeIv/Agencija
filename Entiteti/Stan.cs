using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Stan : Spratovi
    {
        public virtual Stanar JMBGStanara { get; set; }
        public virtual IList<VlasnikStana> Vlasnici { get; set; }

        public Stan()
        {
            Vlasnici = new List<VlasnikStana>();
        }
    }
}
