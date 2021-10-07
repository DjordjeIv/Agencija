using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class TeretniLift :Lift
    {
        public virtual string Nosivost { get; set; }
        public TeretniLift()
        {

        }
    }
}
