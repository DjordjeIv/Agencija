using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencija.Entiteti;
using FluentNHibernate.Mapping;

namespace Agencija.Mapiranja
{
    class UpravniciMapiranja :SubclassMap<Upravnici>
    {
        public UpravniciMapiranja()
        {
            Table("UPRAVNICI");
            KeyColumn("JMBG");
            Map(x => x.INSTITUCIJA, "INSTITUCIJA");
            Map(x => x.ZVANJE, "ZVANJE");
            Map(x => x.DIPLOMIRAO, "DIPLOMIRAO");
            HasMany(x => x.Zgrade).KeyColumn("JMBG").Cascade.All().Inverse();
            HasManyToMany(x => x.Licence)
                .Table("POSEDUJE")
                .ParentKeyColumn("JMBG1")
                .ChildKeyColumn("BROJ_LICENCE0")
                .Cascade.All();
        }
    }
}
