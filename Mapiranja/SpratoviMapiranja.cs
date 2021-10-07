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
    public class SpratoviMapiranja : ClassMap<Spratovi>
    {
        public SpratoviMapiranja()
        {
            Table("SPRATOVI");
            Id(x => x.Redni_broj, "REDNI_BROJ").GeneratedBy.Assigned();
            Map(x => x.Nivo, "NIVO");
            References(x => x.UZgradi).Column("IDZGRADE").LazyLoad();
        }
        
    }
}
