using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Zgrada
    {
        public virtual int IDZgrade { get; set; }
        public virtual Upravnici JMBG { get; set; }
        public virtual Agencija Sifra { get; set; }
        public virtual IList<Lift> ILift { get; set; }
        public virtual IList<Spratovi> BrSpratova { get; set; }
        public virtual IList<Ulaz> Ulazi { get; set; }
        public Zgrada()
        {
            Ulazi = new List<Ulaz>();
            BrSpratova = new List<Spratovi>();
            ILift = new List<Lift>();
        }
    }
}
