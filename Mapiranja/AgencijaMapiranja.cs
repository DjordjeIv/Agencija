using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Agencija.Mapiranja
{
    public class AgencijaMapiranja : ClassMap<Agencija.Entiteti.Agencija>
    {
        public AgencijaMapiranja()
        {
            Table("AGENCIJA");
            Id(x => x.Sifra, "SIFRA").GeneratedBy.Assigned();
            Map(x => x.Period_trajanja, "PERIOD_TRAJANJA");
            Map(x => x.Datum_potpisa, "DATUM_POTPISA");
            HasMany(x => x.ZaposlenRadnik).KeyColumn("SIFRA").Cascade.All().Inverse();
            HasMany(x => x.Zgrade).KeyColumn("SIFRA").Cascade.All().Inverse();

        }
    }
}
