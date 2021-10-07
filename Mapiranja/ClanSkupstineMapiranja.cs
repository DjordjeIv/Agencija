using Agencija.Entiteti;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Mapiranja
{
    class ClanSkupstineMapiranja : SubclassMap<ClanSkupstine>
    {
        public ClanSkupstineMapiranja()
        {
            Table("CLAN_SKUPSTINE");
            KeyColumn("JMBG");
            Map(x => x.Tip, "TIP_CLANA");
        }
    }
}
