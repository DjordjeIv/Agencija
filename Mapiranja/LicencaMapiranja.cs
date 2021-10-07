using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agencija.Entiteti;
using FluentNHibernate.Mapping;

namespace Agencija.Mapiranja
{
    public class LicencaMapiranja :ClassMap<Licenca>
    {
        public LicencaMapiranja()
        {
            Table("LICENCA");
            Id(x => x.BROJ_LICENCE, "BROJ_LICENCE").GeneratedBy.TriggerIdentity();
            Map(x => x.DATUM_STICANJA_OBNAVLJANJA, "DATUM_STICANJA_OBNAVLJANJA");
            Map(x => x.NAZIV_INSTITUCIJE, "NAZIV_INSTITUCIJE");
            HasManyToMany(x => x.Upravnici)
                .Table("POSEDUJE")
                .ParentKeyColumn("BROJ_LICENCE0")
                .ChildKeyColumn("JMBG1")
                .Cascade.All().Inverse();
        }
    }
}
