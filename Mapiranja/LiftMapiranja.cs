using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencija.Entiteti;
using FluentNHibernate.Mapping;

namespace Agencija.Mapiranja
{
    public class LiftMapiranja : ClassMap<Lift>
    {
        public LiftMapiranja()
        {
            Table("LIFT");
            Id(x => x.SB, "SB").GeneratedBy.Assigned();
            Map(x => x.PROIZVODJAC, "PROIZVODJAC");
            Map(x => x.SERVISIRAN, "SERVISIRAN");
            Map(x => x.DAT_KVARA, "DAT_KVARA");
            Map(x => x.VAN_UP, "VAN_UP");
            HasManyToMany(x => x.Ins)
                .Table("INSTALIRAN")
                .ParentKeyColumn("SB")
                .ChildKeyColumn("IDZ")
                .Cascade.All();
        
        }
    }
}
