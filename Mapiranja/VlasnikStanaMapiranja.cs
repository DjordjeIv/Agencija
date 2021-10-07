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
    public class VlasnikStanaMapiranja : SubclassMap<VlasnikStana>
    {
        public VlasnikStanaMapiranja()
        {
            Table("VLASNIK_STANA");
            KeyColumn("JMBG");
            HasManyToMany(x => x.Stanovi)
                .Table("VLASNIK_JE")
                .ParentKeyColumn("JMBG")
                .ChildKeyColumn("REDNI_BROJ")
                .Cascade.All().Inverse();
        }
    }
}
