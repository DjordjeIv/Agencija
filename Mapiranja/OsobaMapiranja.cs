using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Agencija.Entiteti;

namespace Agencija.Mapiranja
{
    public class OsobaMapiranja: ClassMap<Agencija.Entiteti.Osoba>
    {
        public OsobaMapiranja()
        {
            Table("OSOBA");
            Id(x => x.JMBG, "JMBG").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime_rod, "IME_ROD");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Licno_ime, "LICNO_IME");
            Map(x => x.Dat_rodj, "DAT_RODJ");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Broj_telefona, "BROJTELEFONA");
            Map(x => x.Broj_licne_karte, "BRLICNEKARTE");
            Map(x => x.Mesto_izdavanja, "MESTOIZDAVANJA");

            HasMany(x => x.VlasnikVozila).KeyColumn("JMBG1").Cascade.All().Inverse();


        }
    }
}
