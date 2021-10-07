using Agencija.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Mapiranja
{
    public class StanMapiranja : SubclassMap<Stan>
    {
        public StanMapiranja()
        {
            Table("STAN");
            KeyColumn("REDNI_BROJ");
            References(x => x.JMBGStanara).Column("JMBG").LazyLoad();
            HasManyToMany(x => x.Vlasnici)
                .Table("VLASNIK_JE")
                .ParentKeyColumn("REDNI_BROJ")
                .ChildKeyColumn("JMBG")
                .Cascade.All();
        }
    }
}
