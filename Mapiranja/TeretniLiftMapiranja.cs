using Agencija.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Mapiranja
{
    public class TeretniLiftMapiranja :SubclassMap<TeretniLift>
    {
        public TeretniLiftMapiranja()
        {
            Table("TERETNI_LIFT");
            KeyColumn("SERIJSKI_BROJ");
            Map(x => x.Nosivost, "MAX_NOSIVOST");
        }
    }
}
