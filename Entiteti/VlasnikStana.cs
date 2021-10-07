using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class VlasnikStana : Osoba
    {
        public virtual IList<Stan> Stanovi { get; set; }
        public VlasnikStana()
        {
            Stanovi = new List<Stan>();
        }
    }
}
