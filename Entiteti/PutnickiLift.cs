using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class PutnickiLift : Lift
    {
        public virtual string BrojOsoba { get; set; }
        public PutnickiLift()
        {

        }
    }
}
