using Agencija.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Mapiranja
{
    public class UlazMapiranja : ClassMap<Ulaz>
    {
        public UlazMapiranja()
        {
            Table("ULAZ");
            Id(x=> x.Id, "ID").GeneratedBy.Assigned();
            Map(x => x.REDNI_BROJ, "REDNI_BROJ");
            Map(x => x.VREME_OTVOREN, "VREME_OTVOREN");
            Map(x => x.INSTALIRANA_KAMERA, "INSTALIRANA_KAMERA");
            References(x => x.UlazUZgradu).Column("IDZGRADE").LazyLoad();
        }
    }
}
