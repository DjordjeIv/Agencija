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
    public class ZaposleniMapiranje : SubclassMap<Zaposleni>
    {
        public ZaposleniMapiranje()
        {
            Table("ZAPOSLENI");
            KeyColumn("JMBG");
            References(x => x.Sifra).Column("SIFRA").LazyLoad();
        }
    }
}
