using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Entiteti
{
    public class ClanSkupstine : VlasnikStana
    {
        public virtual string Tip { get; set; }
        public ClanSkupstine()
        {
            
        }
    }
}
