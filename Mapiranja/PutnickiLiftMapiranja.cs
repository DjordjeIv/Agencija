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
    public class PutnickiLiftMapiranja : SubclassMap<PutnickiLift>
    {
        public PutnickiLiftMapiranja()
        {
            Table("PUTNICKI_LIFT");
            KeyColumn("SERIJSKI_BROJ");
            Map(x => x.BrojOsoba, "MAX_OSOBA");
        }
        
    }
}
