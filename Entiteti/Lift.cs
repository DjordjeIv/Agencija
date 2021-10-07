using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class Lift
    {
        public virtual int SB { get;  set; }
        public virtual string PROIZVODJAC { get; set; }
        public virtual DateTime SERVISIRAN { get; set; }
        public virtual DateTime DAT_KVARA { get; set; }
        public virtual int VAN_UP { get; set; }

        public virtual IList<Zgrada> Ins { get; set; }

        public Lift()
        {
            Ins = new List<Zgrada>();
        }
    }
}
