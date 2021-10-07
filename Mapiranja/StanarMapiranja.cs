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
    public class StanarMapiranja : SubclassMap<Stanar>
    {
        public StanarMapiranja()
        {
            Table("STANAR");
            KeyColumn("JMBG");
            HasMany(x => x.Stanuje).KeyColumn("JMBG").Cascade.All().Inverse();
        }
    }
}
