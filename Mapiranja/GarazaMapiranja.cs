using Agencija.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Mapiranja
{
    class GarazaMapiranja :SubclassMap<Garaza>
    {
        public GarazaMapiranja()
        {
            Table("GARAZA");
            KeyColumn("REDNI_BROJ");
            References(x => x.RezZaVozila).Column("REG_BROJ").LazyLoad();
        }
    }
}
