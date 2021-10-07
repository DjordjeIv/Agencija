using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencija.Entiteti;
using FluentNHibernate.Mapping;

namespace Agencija.Mapiranja
{
    public class ZgradaMapiranja : ClassMap<Zgrada>
    {
        public ZgradaMapiranja()
        {
            Table("ZGRADA");
            Id(x => x.IDZgrade, "IDZGRADE").GeneratedBy.Assigned();
            References(x => x.JMBG).Column("JMBG").LazyLoad();
            References(x => x.Sifra).Column("SIFRA").LazyLoad();
            HasMany(x => x.BrSpratova).KeyColumn("IDZGRADE").Cascade.All().Inverse();
            HasMany(x => x.Ulazi).KeyColumn("IDZGRADE").Cascade.All().Inverse();
            HasManyToMany(x => x.ILift)
                .Table("INSTALIRAN")
                .ParentKeyColumn("IDZ")
                .ChildKeyColumn("SB")
                .Cascade.All().Inverse();
        }
    }
}
