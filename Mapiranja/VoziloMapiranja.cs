using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencija.Entiteti;
using FluentNHibernate.Mapping;


namespace Agencija.Mapiranja
{
    public class VoziloMapiranja : ClassMap<Vozilo>
    {
        public VoziloMapiranja()
        {
            Table("VOZILO");
            Id(x => x.REG_BROJ, "REG_BROJ").GeneratedBy.Assigned();
            HasMany(x => x.RezUGaraze).KeyColumn("REG_BROJ").Cascade.All().Inverse();
            References(x => x.JMBGOsobe).Column("JMBG1").LazyLoad();
        }
            
    }
}
