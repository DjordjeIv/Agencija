using Agencija.Entiteti;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Mapiranja
{
    public class LokalMapiranja : SubclassMap<Lokal>
    {
        public LokalMapiranja()
        {
            Table("LOKAL");
            KeyColumn("REDNI_BROJ");
            Map(x => x.Ime_firme, "IME_FIRME");
        }
        
    }
}
