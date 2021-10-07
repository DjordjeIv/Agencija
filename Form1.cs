using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Agencija.Entiteti;

namespace Agencija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agencija.Entiteti.Osoba o = s.Load<Agencija.Entiteti.Osoba>(123456789101114165);
                MessageBox.Show(o.Licno_ime);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Osoba o = new Entiteti.Osoba();

                o.Ime_rod = "Karla";
                o.Prezime = "Vodami";
                o.Licno_ime = "Rolf";
                o.Dat_rodj = new DateTime(2008, 12, 1);
                o.Adresa = "Pikadili-Wheel";
                o.Broj_telefona = 5595774;
                o.Broj_licne_karte = 666666666;

                s.Save(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdManytoOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo z = s.Load<Vozilo>(33333321);
                MessageBox.Show(z.JMBGOsobe.Licno_ime);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agencija.Entiteti.Osoba o = s.Load<Agencija.Entiteti.Osoba>(123456789101114175);
                foreach (Vozilo v in o.VlasnikVozila)
                {
                    MessageBox.Show(v.REG_BROJ.ToString());
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Osoba o = new Entiteti.Osoba()
                {
                    Ime_rod = "Viki",
                    Prezime = "Vodami",
                    Licno_ime = "Karl",
                    Dat_rodj = new DateTime(2008, 12, 1),
                    Adresa = "Pikadili-Wheel",
                    Broj_telefona = 5595773,
                    Broj_licne_karte = 666666665
                };

                Vozilo v = new Vozilo()
                { 
                    REG_BROJ = 33223321
                };

                Vozilo v1 = new Vozilo()
                {
                    REG_BROJ = 33223322
                };

                v.JMBGOsobe = o;
                v1.JMBGOsobe = o;
                o.VlasnikVozila.Add(v);
                o.VlasnikVozila.Add(v1);
                s.Save(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdManyToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Lift l = s.Load<Entiteti.Lift>(333);
                foreach (Zgrada z2 in l.Ins)
                {
                    MessageBox.Show(z2.IDZgrade.ToString());
                }

                Zgrada z1 = s.Load<Zgrada>(1);
                foreach (Entiteti.Lift l1 in z1.ILift)
                {
                    MessageBox.Show(l1.PROIZVODJAC);
                }

                
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdInstall_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.TeretniLift tl = new Entiteti.TeretniLift()
                {
                    SB = 7003,
                    PROIZVODJAC = "Elevated",
                    SERVISIRAN = new DateTime(2008, 8, 1),
                    DAT_KVARA = new DateTime(2008, 12, 1),
                    VAN_UP = 4,
                    Nosivost = "5t"
                };
                s.Save(tl);

                Entiteti.PutnickiLift pl = new Entiteti.PutnickiLift()
                {
                    SB = 2003,
                    PROIZVODJAC = "Elevated",
                    SERVISIRAN = new DateTime(2008, 8, 1),
                    DAT_KVARA = new DateTime(2008, 12, 1),
                    VAN_UP = 4,
                    BrojOsoba = "800kg-10 Osoba"
                };
                s.Save(pl);

                Zgrada z = s.Load<Entiteti.Zgrada>(4);

                Lift l1 = s.Load<Entiteti.Lift>(7003);
                Lift l2 = s.Load<Entiteti.Lift>(2003);


                l1.Ins.Add(z);
                z.ILift.Add(l1);
                l2.Ins.Add(z);
                z.ILift.Add(l2);
                s.Save(z);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Osoba> Osobe = s.QueryOver<Osoba>().Where(p => p.JMBG == 123456789101114176).List<Osoba>();
                Zaposleni z = (Zaposleni) Osobe[0];
                MessageBox.Show(z.Licno_ime);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdZaposli_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = new Zaposleni();

                z.Ime_rod = "Miki";
                z.Prezime = "Karlson";
                z.Licno_ime = "Cathrin";
                z.Dat_rodj = new DateTime(1908, 12, 1);
                z.Adresa = "Pikadili-Wheel";
                z.Broj_telefona = 8888881;
                z.Broj_licne_karte = 666666669;
                s.Save(z);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziStanara_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Osoba> Osobe = s.QueryOver<Osoba>().Where(p => p.JMBG == 123456789101114177).List<Osoba>();
                Stanar st = (Stanar)Osobe[0];
                MessageBox.Show(st.Licno_ime);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajStanara_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Stanar st = new Stanar();

                st.Ime_rod = "Samus";
                st.Prezime = "Shemus";
                st.Licno_ime = "Samus";
                st.Dat_rodj = new DateTime(1928, 12, 1);
                st.Adresa = "Pikadili-Wheel";
                st.Broj_telefona = 8888881;
                st.Broj_licne_karte = 666666669;
                s.Save(st);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziUpravnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Osoba> o = s.QueryOver<Osoba>().Where(p => p.JMBG == 123456789101114179).List<Osoba>();
                Zaposleni z = (Zaposleni)o[0];
                Upravnici u = (Upravnici)z;
                MessageBox.Show(u.Licno_ime);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajUpravnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Upravnici u = new Entiteti.Upravnici()
                {

                    Ime_rod = "Samus",
                    Prezime = "Shemus",
                    Licno_ime = "Samus",
                    Dat_rodj = new DateTime(1928, 12, 1),
                    Adresa = "Pikadili-Wheel",
                    Broj_telefona = 8888881,
                    Broj_licne_karte = 666666669,
                    INSTITUCIJA = "Montekarlo",
                    ZVANJE = "Mm",
                    DIPLOMIRAO = new DateTime(1998, 12, 1)
                };

                Licenca l = new Licenca()
                {
                    NAZIV_INSTITUCIJE = "Voldertort",
                    DATUM_STICANJA_OBNAVLJANJA = new DateTime(1928, 12, 1)
                };


                l.Upravnici.Add(u);
                u.Licence.Add(l);
                s.Save(l);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdVidiLiftove_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Agencija.Entiteti.TeretniLift tl = s.Load<Agencija.Entiteti.TeretniLift>(333);
                MessageBox.Show(tl.PROIZVODJAC);
                Agencija.Entiteti.PutnickiLift pl = s.Load<Agencija.Entiteti.PutnickiLift>(334);
                MessageBox.Show(pl.PROIZVODJAC);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agencija.Entiteti.Vozilo v = s.Load<Agencija.Entiteti.Vozilo>(33223322);
                MessageBox.Show(v.REG_BROJ.ToString()+ " " + v.JMBGOsobe.Licno_ime);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziLicencu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agencija.Entiteti.Licenca l = s.Load<Agencija.Entiteti.Licenca>(22);
                MessageBox.Show(l.NAZIV_INSTITUCIJE + " " + l.DATUM_STICANJA_OBNAVLJANJA.ToString());
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajLicencu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Licenca l = new Licenca();

                l.NAZIV_INSTITUCIJE = "Voldertort";
                l.DATUM_STICANJA_OBNAVLJANJA = new DateTime(1928, 12, 1);
                s.Save(l);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdManyToManyUIL_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Licenca l = s.Load<Entiteti.Licenca>(3);
                foreach (Upravnici u in l.Upravnici)
                {
                    MessageBox.Show(u.Licno_ime);
                }

                Upravnici u1 = s.Load<Upravnici>(123456789101114180);
                foreach (Entiteti.Licenca l1 in u1.Licence)
                {
                    MessageBox.Show(l1.NAZIV_INSTITUCIJE);
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPokaziVlasnikaStana_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Osoba> Osobe = s.QueryOver<Osoba>().Where(p => p.JMBG == 123456789101114181).List<Osoba>();
                VlasnikStana v = (VlasnikStana)Osobe[0];
                MessageBox.Show(v.Licno_ime);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajVlasnikaStana_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ClanSkupstine c = new ClanSkupstine();
                c.Ime_rod = "Ciki";
                c.Prezime = "Briki";
                c.Licno_ime = "Brownky";
                c.Dat_rodj = new DateTime(1978, 12, 1);
                c.Adresa = "Pikadili-Wheel";
                c.Broj_telefona = 2153897;
                c.Broj_licne_karte = 292929292;
                c.Tip = "TBD";
                s.Save(c);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziClanaSkupstine_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Osoba> Osobe = s.QueryOver<Osoba>().Where(p => p.JMBG == 123456789101114182).List<Osoba>();
                ClanSkupstine c = (ClanSkupstine)Osobe[0];
                MessageBox.Show(c.Licno_ime);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajClanaSkupstine_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ClanSkupstine c = new ClanSkupstine();
                c.Ime_rod = "Oki";
                c.Prezime = "Doki";
                c.Licno_ime = "Moki";
                c.Dat_rodj = new DateTime(1958, 12, 1);
                c.Adresa = "Pikadili-Wheel";
                c.Broj_telefona = 2153897;
                c.Broj_licne_karte = 292929292;
                c.Tip = "Opsti clan";

                s.Save(c);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdVidiAgenciju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agencija.Entiteti.Agencija a = s.Load<Agencija.Entiteti.Agencija>(10);
                MessageBox.Show(a.Sifra.ToString() + " " + a.Period_trajanja.ToString());
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajUgovor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Agencija a = new Entiteti.Agencija();

                a.Sifra = 333;
                a.Period_trajanja = 3;
                a.Datum_potpisa = new DateTime(2011, 02, 12);

                s.Save(a);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziUSaZap_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(123456789101114180);
                MessageBox.Show(z.Licno_ime + " " + z.Prezime);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziUZManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zgrada z = s.Load<Zgrada>(3);
                MessageBox.Show(z.IDZgrade.ToString());
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziUSaZgadama_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zgrada z = s.Load<Zgrada>(3);
                MessageBox.Show(z.IDZgrade.ToString());
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziBrOsoba_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PutnickiLift p = s.Load<PutnickiLift>(334);
                MessageBox.Show(p.BrojOsoba + " " + p.SERVISIRAN);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziTerNos_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TeretniLift t = s.Load<TeretniLift>(333);
                MessageBox.Show(t.Nosivost + " " + t.SERVISIRAN);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziZgrade_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agencija.Entiteti.Zgrada z = s.Load<Agencija.Entiteti.Zgrada>(4);
                MessageBox.Show(z.Sifra.Sifra.ToString() + " " + z.JMBG.Licno_ime);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajZgradu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Zgrada z = new Entiteti.Zgrada();

                z.IDZgrade = 4;

                Entiteti.Upravnici u = new Entiteti.Upravnici()
                {
                    Ime_rod = "Mona",
                    Prezime = "Wao",
                    Licno_ime = "Lisa",
                    Dat_rodj = new DateTime(2001, 02, 11),
                    Adresa = "Seeufall",
                    Broj_telefona = 7721237,
                    Broj_licne_karte = 999999999,
                    INSTITUCIJA = "Montekarlo",
                    ZVANJE = "Dm",
                    DIPLOMIRAO = new DateTime(1998, 12, 1)
                };

                Entiteti.Agencija a = new Entiteti.Agencija();

                a.Sifra = 1003;
                a.Period_trajanja = 3;
                a.Datum_potpisa = new DateTime(2014, 01, 12);

                z.Sifra = a;
                z.JMBG = u;
                u.Zgrade.Add(z);
                u.Sifra = a;
                a.Zgrade.Add(z);
                a.ZaposlenRadnik.Add(u);
                s.Save(a);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdVidiSprat_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agencija.Entiteti.Spratovi sp = s.Load<Agencija.Entiteti.Spratovi>(1);
                MessageBox.Show(sp.Redni_broj + " " + sp.Nivo.ToString() + " " + sp.UZgradi.IDZgrade.ToString());
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajSprat_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Spratovi sp = new Entiteti.Spratovi();

                sp.Redni_broj = 1;
                sp.Nivo = "Prizemlje - 0";

                Zgrada z = s.Load<Entiteti.Zgrada>(4);


                sp.UZgradi = z;
                z.BrSpratova.Add(sp);

                s.Save(sp);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdVidiSpratove_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agencija.Entiteti.Lokal l = s.Load<Agencija.Entiteti.Lokal>(3);
                MessageBox.Show(l.Redni_broj.ToString() + " " + l.UZgradi.IDZgrade.ToString());
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajLokal_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Lokal l = new Entiteti.Lokal();

                l.Nivo = "1 Sprat";
                l.Redni_broj = 3;
                l.Ime_firme = "Exquisite";
                s.Save(l);

                Zgrada z = s.Load<Entiteti.Zgrada>(4);

                Spratovi s1 = s.Load<Entiteti.Spratovi>(3);



                s1.UZgradi = z;
                z.BrSpratova.Add(s1);
                s.Save(z);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajUlaz_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Ulaz u = new Entiteti.Ulaz();
                u.Id = 1;
                u.REDNI_BROJ = 1;
                u.VREME_OTVOREN = 24;
                u.INSTALIRANA_KAMERA = "Ne";

                Zgrada z = s.Load<Zgrada>(4);

                u.UlazUZgradu = z;
                z.Ulazi.Add(u);
                s.Save(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziUlaz_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agencija.Entiteti.Ulaz u = s.Load<Agencija.Entiteti.Ulaz>(1);
                MessageBox.Show(u.VREME_OTVOREN.ToString() + " " + u.UlazUZgradu.IDZgrade.ToString());
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajGarazu_Click(object sender, EventArgs e)
        {
            try 
            { 
                ISession s = DataLayer.GetSession();

                Entiteti.Osoba o = s.Load<Osoba>(123456789101114175);

                Vozilo v = new Vozilo()
                {
                    REG_BROJ = 33223325
                };

                Vozilo v1 = new Vozilo()
                {
                    REG_BROJ = 33223327
                };
                Zgrada z = s.Load<Zgrada>(4);

                Garaza g = new Garaza();
                g.Nivo = "Podzemni";
                g.Redni_broj = -1;
                g.UZgradi = z;

                v.JMBGOsobe = o;
                v1.JMBGOsobe = o;
                o.VlasnikVozila.Add(v);
                o.VlasnikVozila.Add(v1);
                g.RezZaVozila = v;
                v.RezUGaraze.Add(g);
                s.Save(g);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziGarazu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agencija.Entiteti.Garaza g = s.Load<Agencija.Entiteti.Garaza>(-1);
                MessageBox.Show(g.RezZaVozila.REG_BROJ.ToString() + " " + g.RezZaVozila.JMBGOsobe.Licno_ime + " " + g.Redni_broj.ToString());
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodajStan_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Stanar st = new Entiteti.Stanar()
                {
                    Ime_rod = "Vort",
                    Prezime = "Bort",
                    Licno_ime = "Kort",
                    Dat_rodj = new DateTime(2002, 3, 21),
                    Adresa = "Wokemi",
                    Broj_telefona = 1234534,
                    Broj_licne_karte = 123456789
                };
                VlasnikStana st1 = new VlasnikStana()
                {
                    Ime_rod = "Vort",
                    Prezime = "Bort",
                    Licno_ime = "Kort",
                    Dat_rodj = new DateTime(2002, 3, 21),
                    Adresa = "Wokemi",
                    Broj_telefona = 1234534,
                    Broj_licne_karte = 123456789
                };
                Zgrada z = s.Load<Zgrada>(4);

                Stan sa = new Stan()
                {
                    Redni_broj = 7,
                    Nivo = "Stanovi",
                    UZgradi = z
                };
                s.Save(sa);
                Spratovi sp = s.Load<Spratovi>(7);

                z.BrSpratova.Add(sp);

                sa.JMBGStanara = st;
                st.Stanuje.Add(sa);
                st1.Stanovi.Add(sa);
                sa.Vlasnici.Add(st1);
                s.Save(st);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPrikaziStan_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agencija.Entiteti.Stan st = s.Load<Agencija.Entiteti.Stan>(6);
                MessageBox.Show(st.JMBGStanara.Licno_ime + " " + st.Nivo);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdVezaVlasnikIStan_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Stan st = s.Load<Entiteti.Stan>(7);
                foreach (VlasnikStana v in st.Vlasnici)
                {
                    MessageBox.Show(v.Licno_ime);
                }

                VlasnikStana v1 = s.Load<VlasnikStana>(123456789101114200);
                foreach (Stan s1 in v1.Stanovi)
                {
                    MessageBox.Show(s1.UZgradi.IDZgrade.ToString());
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
