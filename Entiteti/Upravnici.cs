using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Upravnici : Zaposleni
    {
        
        public virtual string INSTITUCIJA { get;  set; }
        public virtual string ZVANJE { get; set; }
        public virtual DateTime DIPLOMIRAO { get; set; }
        public virtual IList<Zgrada> Zgrade { get; set; }
        public virtual IList<Licenca> Licence { get; set; }

        public Upravnici()
        {
            Zgrade = new List<Zgrada>();
            Licence = new List<Licenca>();
        }
    }
}
