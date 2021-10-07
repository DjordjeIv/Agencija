namespace Agencija
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdPrikazi = new System.Windows.Forms.Button();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.cmdManytoOne = new System.Windows.Forms.Button();
            this.cmdOneToMany = new System.Windows.Forms.Button();
            this.cmdDodajVozilo = new System.Windows.Forms.Button();
            this.cmdManyToMany = new System.Windows.Forms.Button();
            this.cmdInstall = new System.Windows.Forms.Button();
            this.cmdPrikaziZaposlenog = new System.Windows.Forms.Button();
            this.cmdZaposli = new System.Windows.Forms.Button();
            this.cmdPrikaziStanara = new System.Windows.Forms.Button();
            this.cmdDodajStanara = new System.Windows.Forms.Button();
            this.cmdPrikaziUpravnika = new System.Windows.Forms.Button();
            this.cmdDodajUpravnika = new System.Windows.Forms.Button();
            this.cmdVidiLiftove = new System.Windows.Forms.Button();
            this.cmdPrikaziVozilo = new System.Windows.Forms.Button();
            this.cmdPrikaziLicencu = new System.Windows.Forms.Button();
            this.cmdDodajLicencu = new System.Windows.Forms.Button();
            this.cmdManyToManyUIL = new System.Windows.Forms.Button();
            this.cmdPokaziVlasnikaStana = new System.Windows.Forms.Button();
            this.cmdDodajVlasnikaStana = new System.Windows.Forms.Button();
            this.cmdPrikaziClanaSkupstine = new System.Windows.Forms.Button();
            this.cmdDodajClanaSkupstine = new System.Windows.Forms.Button();
            this.cmdVidiAgenciju = new System.Windows.Forms.Button();
            this.cmdDodajUgovor = new System.Windows.Forms.Button();
            this.cmdPrikaziUSaZap = new System.Windows.Forms.Button();
            this.cmdPrikaziUZManyToOne = new System.Windows.Forms.Button();
            this.cmdPrikaziUSaZgadama = new System.Windows.Forms.Button();
            this.cmdPrikaziBrOsoba = new System.Windows.Forms.Button();
            this.cmdPrikaziTerNos = new System.Windows.Forms.Button();
            this.cmdPrikaziZgrade = new System.Windows.Forms.Button();
            this.cmdDodajZgradu = new System.Windows.Forms.Button();
            this.cmdVidiSprat = new System.Windows.Forms.Button();
            this.cmdDodajSprat = new System.Windows.Forms.Button();
            this.cmdVidiSpratove = new System.Windows.Forms.Button();
            this.cmdDodajLokal = new System.Windows.Forms.Button();
            this.cmdPrikaziUlaz = new System.Windows.Forms.Button();
            this.cmdDodajUlaz = new System.Windows.Forms.Button();
            this.cmdPrikaziGarazu = new System.Windows.Forms.Button();
            this.cmdDodajGarazu = new System.Windows.Forms.Button();
            this.cmdPrikaziStan = new System.Windows.Forms.Button();
            this.cmdDodajStan = new System.Windows.Forms.Button();
            this.cmdVezaVlasnikIStan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdPrikazi
            // 
            this.cmdPrikazi.Location = new System.Drawing.Point(13, 13);
            this.cmdPrikazi.Name = "cmdPrikazi";
            this.cmdPrikazi.Size = new System.Drawing.Size(190, 23);
            this.cmdPrikazi.TabIndex = 0;
            this.cmdPrikazi.Text = "Prikazi Osobu";
            this.cmdPrikazi.UseVisualStyleBackColor = true;
            this.cmdPrikazi.Click += new System.EventHandler(this.cmdPrikazi_Click);
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.Location = new System.Drawing.Point(13, 43);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(190, 23);
            this.cmdDodaj.TabIndex = 1;
            this.cmdDodaj.Text = "Dodaj Osobu";
            this.cmdDodaj.UseVisualStyleBackColor = true;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // cmdManytoOne
            // 
            this.cmdManytoOne.Location = new System.Drawing.Point(13, 73);
            this.cmdManytoOne.Name = "cmdManytoOne";
            this.cmdManytoOne.Size = new System.Drawing.Size(190, 23);
            this.cmdManytoOne.TabIndex = 2;
            this.cmdManytoOne.Text = "Prikazi Vozila (many-one)";
            this.cmdManytoOne.UseVisualStyleBackColor = true;
            this.cmdManytoOne.Click += new System.EventHandler(this.cmdManytoOne_Click);
            // 
            // cmdOneToMany
            // 
            this.cmdOneToMany.Location = new System.Drawing.Point(210, 73);
            this.cmdOneToMany.Name = "cmdOneToMany";
            this.cmdOneToMany.Size = new System.Drawing.Size(190, 23);
            this.cmdOneToMany.TabIndex = 3;
            this.cmdOneToMany.Text = "Prikazi one-many";
            this.cmdOneToMany.UseVisualStyleBackColor = true;
            this.cmdOneToMany.Click += new System.EventHandler(this.cmdOneToMany_Click);
            // 
            // cmdDodajVozilo
            // 
            this.cmdDodajVozilo.Location = new System.Drawing.Point(209, 43);
            this.cmdDodajVozilo.Name = "cmdDodajVozilo";
            this.cmdDodajVozilo.Size = new System.Drawing.Size(190, 23);
            this.cmdDodajVozilo.TabIndex = 4;
            this.cmdDodajVozilo.Text = "Dodaj vozilo";
            this.cmdDodajVozilo.UseVisualStyleBackColor = true;
            this.cmdDodajVozilo.Click += new System.EventHandler(this.cmdDodajVozilo_Click);
            // 
            // cmdManyToMany
            // 
            this.cmdManyToMany.Location = new System.Drawing.Point(406, 73);
            this.cmdManyToMany.Name = "cmdManyToMany";
            this.cmdManyToMany.Size = new System.Drawing.Size(190, 23);
            this.cmdManyToMany.TabIndex = 5;
            this.cmdManyToMany.Text = "Prikazi many-many";
            this.cmdManyToMany.UseVisualStyleBackColor = true;
            this.cmdManyToMany.Click += new System.EventHandler(this.cmdManyToMany_Click);
            // 
            // cmdInstall
            // 
            this.cmdInstall.Location = new System.Drawing.Point(405, 43);
            this.cmdInstall.Name = "cmdInstall";
            this.cmdInstall.Size = new System.Drawing.Size(190, 23);
            this.cmdInstall.TabIndex = 6;
            this.cmdInstall.Text = "Instaliraj Lift";
            this.cmdInstall.UseVisualStyleBackColor = true;
            this.cmdInstall.Click += new System.EventHandler(this.cmdInstall_Click);
            // 
            // cmdPrikaziZaposlenog
            // 
            this.cmdPrikaziZaposlenog.Location = new System.Drawing.Point(211, 335);
            this.cmdPrikaziZaposlenog.Name = "cmdPrikaziZaposlenog";
            this.cmdPrikaziZaposlenog.Size = new System.Drawing.Size(190, 23);
            this.cmdPrikaziZaposlenog.TabIndex = 7;
            this.cmdPrikaziZaposlenog.Text = "Prikazi zaposlenog";
            this.cmdPrikaziZaposlenog.UseVisualStyleBackColor = true;
            this.cmdPrikaziZaposlenog.Click += new System.EventHandler(this.cmdPrikaziZaposlenog_Click);
            // 
            // cmdZaposli
            // 
            this.cmdZaposli.Location = new System.Drawing.Point(212, 364);
            this.cmdZaposli.Name = "cmdZaposli";
            this.cmdZaposli.Size = new System.Drawing.Size(190, 23);
            this.cmdZaposli.TabIndex = 8;
            this.cmdZaposli.Text = "Zaposli";
            this.cmdZaposli.UseVisualStyleBackColor = true;
            this.cmdZaposli.Click += new System.EventHandler(this.cmdZaposli_Click);
            // 
            // cmdPrikaziStanara
            // 
            this.cmdPrikaziStanara.Location = new System.Drawing.Point(403, 162);
            this.cmdPrikaziStanara.Name = "cmdPrikaziStanara";
            this.cmdPrikaziStanara.Size = new System.Drawing.Size(190, 23);
            this.cmdPrikaziStanara.TabIndex = 9;
            this.cmdPrikaziStanara.Text = "Prikazi stanara";
            this.cmdPrikaziStanara.UseVisualStyleBackColor = true;
            this.cmdPrikaziStanara.Click += new System.EventHandler(this.cmdPrikaziStanara_Click);
            // 
            // cmdDodajStanara
            // 
            this.cmdDodajStanara.Location = new System.Drawing.Point(403, 191);
            this.cmdDodajStanara.Name = "cmdDodajStanara";
            this.cmdDodajStanara.Size = new System.Drawing.Size(190, 23);
            this.cmdDodajStanara.TabIndex = 10;
            this.cmdDodajStanara.Text = "Dodaj Stanara";
            this.cmdDodajStanara.UseVisualStyleBackColor = true;
            this.cmdDodajStanara.Click += new System.EventHandler(this.cmdDodajStanara_Click);
            // 
            // cmdPrikaziUpravnika
            // 
            this.cmdPrikaziUpravnika.Location = new System.Drawing.Point(406, 219);
            this.cmdPrikaziUpravnika.Name = "cmdPrikaziUpravnika";
            this.cmdPrikaziUpravnika.Size = new System.Drawing.Size(190, 23);
            this.cmdPrikaziUpravnika.TabIndex = 11;
            this.cmdPrikaziUpravnika.Text = "Prikazi Upravnika";
            this.cmdPrikaziUpravnika.UseVisualStyleBackColor = true;
            this.cmdPrikaziUpravnika.Click += new System.EventHandler(this.cmdPrikaziUpravnika_Click);
            // 
            // cmdDodajUpravnika
            // 
            this.cmdDodajUpravnika.Location = new System.Drawing.Point(404, 248);
            this.cmdDodajUpravnika.Name = "cmdDodajUpravnika";
            this.cmdDodajUpravnika.Size = new System.Drawing.Size(190, 23);
            this.cmdDodajUpravnika.TabIndex = 12;
            this.cmdDodajUpravnika.Text = "Dodaj upravnika";
            this.cmdDodajUpravnika.UseVisualStyleBackColor = true;
            this.cmdDodajUpravnika.Click += new System.EventHandler(this.cmdDodajUpravnika_Click);
            // 
            // cmdVidiLiftove
            // 
            this.cmdVidiLiftove.Location = new System.Drawing.Point(405, 13);
            this.cmdVidiLiftove.Name = "cmdVidiLiftove";
            this.cmdVidiLiftove.Size = new System.Drawing.Size(190, 23);
            this.cmdVidiLiftove.TabIndex = 13;
            this.cmdVidiLiftove.Text = "Vidi Lifrove";
            this.cmdVidiLiftove.UseVisualStyleBackColor = true;
            this.cmdVidiLiftove.Click += new System.EventHandler(this.cmdVidiLiftove_Click);
            // 
            // cmdPrikaziVozilo
            // 
            this.cmdPrikaziVozilo.Location = new System.Drawing.Point(210, 13);
            this.cmdPrikaziVozilo.Name = "cmdPrikaziVozilo";
            this.cmdPrikaziVozilo.Size = new System.Drawing.Size(189, 23);
            this.cmdPrikaziVozilo.TabIndex = 14;
            this.cmdPrikaziVozilo.Text = "Prikazi Vozilo";
            this.cmdPrikaziVozilo.UseVisualStyleBackColor = true;
            this.cmdPrikaziVozilo.Click += new System.EventHandler(this.cmdPrikaziVozilo_Click);
            // 
            // cmdPrikaziLicencu
            // 
            this.cmdPrikaziLicencu.Location = new System.Drawing.Point(13, 103);
            this.cmdPrikaziLicencu.Name = "cmdPrikaziLicencu";
            this.cmdPrikaziLicencu.Size = new System.Drawing.Size(190, 23);
            this.cmdPrikaziLicencu.TabIndex = 15;
            this.cmdPrikaziLicencu.Text = "Prikazi Licencu";
            this.cmdPrikaziLicencu.UseVisualStyleBackColor = true;
            this.cmdPrikaziLicencu.Click += new System.EventHandler(this.cmdPrikaziLicencu_Click);
            // 
            // cmdDodajLicencu
            // 
            this.cmdDodajLicencu.Location = new System.Drawing.Point(13, 133);
            this.cmdDodajLicencu.Name = "cmdDodajLicencu";
            this.cmdDodajLicencu.Size = new System.Drawing.Size(190, 23);
            this.cmdDodajLicencu.TabIndex = 16;
            this.cmdDodajLicencu.Text = "Dodaj Licencu";
            this.cmdDodajLicencu.UseVisualStyleBackColor = true;
            this.cmdDodajLicencu.Click += new System.EventHandler(this.cmdDodajLicencu_Click);
            // 
            // cmdManyToManyUIL
            // 
            this.cmdManyToManyUIL.Location = new System.Drawing.Point(405, 277);
            this.cmdManyToManyUIL.Name = "cmdManyToManyUIL";
            this.cmdManyToManyUIL.Size = new System.Drawing.Size(190, 49);
            this.cmdManyToManyUIL.TabIndex = 17;
            this.cmdManyToManyUIL.Text = "Prikazi many-many upravnika i licence";
            this.cmdManyToManyUIL.UseVisualStyleBackColor = true;
            this.cmdManyToManyUIL.Click += new System.EventHandler(this.cmdManyToManyUIL_Click);
            // 
            // cmdPokaziVlasnikaStana
            // 
            this.cmdPokaziVlasnikaStana.Location = new System.Drawing.Point(14, 162);
            this.cmdPokaziVlasnikaStana.Name = "cmdPokaziVlasnikaStana";
            this.cmdPokaziVlasnikaStana.Size = new System.Drawing.Size(189, 23);
            this.cmdPokaziVlasnikaStana.TabIndex = 18;
            this.cmdPokaziVlasnikaStana.Text = "Pokazi vlasnika stana";
            this.cmdPokaziVlasnikaStana.UseVisualStyleBackColor = true;
            this.cmdPokaziVlasnikaStana.Click += new System.EventHandler(this.cmdPokaziVlasnikaStana_Click);
            // 
            // cmdDodajVlasnikaStana
            // 
            this.cmdDodajVlasnikaStana.Location = new System.Drawing.Point(14, 191);
            this.cmdDodajVlasnikaStana.Name = "cmdDodajVlasnikaStana";
            this.cmdDodajVlasnikaStana.Size = new System.Drawing.Size(189, 23);
            this.cmdDodajVlasnikaStana.TabIndex = 19;
            this.cmdDodajVlasnikaStana.Text = "Dodaj vlasnika stana";
            this.cmdDodajVlasnikaStana.UseVisualStyleBackColor = true;
            this.cmdDodajVlasnikaStana.Click += new System.EventHandler(this.cmdDodajVlasnikaStana_Click);
            // 
            // cmdPrikaziClanaSkupstine
            // 
            this.cmdPrikaziClanaSkupstine.Location = new System.Drawing.Point(15, 335);
            this.cmdPrikaziClanaSkupstine.Name = "cmdPrikaziClanaSkupstine";
            this.cmdPrikaziClanaSkupstine.Size = new System.Drawing.Size(189, 23);
            this.cmdPrikaziClanaSkupstine.TabIndex = 20;
            this.cmdPrikaziClanaSkupstine.Text = "Prikazi clana skupstine";
            this.cmdPrikaziClanaSkupstine.UseVisualStyleBackColor = true;
            this.cmdPrikaziClanaSkupstine.Click += new System.EventHandler(this.cmdPrikaziClanaSkupstine_Click);
            // 
            // cmdDodajClanaSkupstine
            // 
            this.cmdDodajClanaSkupstine.Location = new System.Drawing.Point(15, 364);
            this.cmdDodajClanaSkupstine.Name = "cmdDodajClanaSkupstine";
            this.cmdDodajClanaSkupstine.Size = new System.Drawing.Size(189, 23);
            this.cmdDodajClanaSkupstine.TabIndex = 21;
            this.cmdDodajClanaSkupstine.Text = "Dodaj clana skupstine";
            this.cmdDodajClanaSkupstine.UseVisualStyleBackColor = true;
            this.cmdDodajClanaSkupstine.Click += new System.EventHandler(this.cmdDodajClanaSkupstine_Click);
            // 
            // cmdVidiAgenciju
            // 
            this.cmdVidiAgenciju.Location = new System.Drawing.Point(209, 103);
            this.cmdVidiAgenciju.Name = "cmdVidiAgenciju";
            this.cmdVidiAgenciju.Size = new System.Drawing.Size(189, 23);
            this.cmdVidiAgenciju.TabIndex = 22;
            this.cmdVidiAgenciju.Text = "Prikazi Ugovore Agencije";
            this.cmdVidiAgenciju.UseVisualStyleBackColor = true;
            this.cmdVidiAgenciju.Click += new System.EventHandler(this.cmdVidiAgenciju_Click);
            // 
            // cmdDodajUgovor
            // 
            this.cmdDodajUgovor.Location = new System.Drawing.Point(211, 132);
            this.cmdDodajUgovor.Name = "cmdDodajUgovor";
            this.cmdDodajUgovor.Size = new System.Drawing.Size(189, 23);
            this.cmdDodajUgovor.TabIndex = 23;
            this.cmdDodajUgovor.Text = "Dodaj Novi Ugovor";
            this.cmdDodajUgovor.UseVisualStyleBackColor = true;
            this.cmdDodajUgovor.Click += new System.EventHandler(this.cmdDodajUgovor_Click);
            // 
            // cmdPrikaziUSaZap
            // 
            this.cmdPrikaziUSaZap.Location = new System.Drawing.Point(208, 162);
            this.cmdPrikaziUSaZap.Name = "cmdPrikaziUSaZap";
            this.cmdPrikaziUSaZap.Size = new System.Drawing.Size(189, 52);
            this.cmdPrikaziUSaZap.TabIndex = 24;
            this.cmdPrikaziUSaZap.Text = "Prikazi Ugovore sa Zaposlenima";
            this.cmdPrikaziUSaZap.UseVisualStyleBackColor = true;
            this.cmdPrikaziUSaZap.Click += new System.EventHandler(this.cmdPrikaziUSaZap_Click);
            // 
            // cmdPrikaziUZManyToOne
            // 
            this.cmdPrikaziUZManyToOne.Location = new System.Drawing.Point(405, 332);
            this.cmdPrikaziUZManyToOne.Name = "cmdPrikaziUZManyToOne";
            this.cmdPrikaziUZManyToOne.Size = new System.Drawing.Size(190, 55);
            this.cmdPrikaziUZManyToOne.TabIndex = 25;
            this.cmdPrikaziUZManyToOne.Text = "Prikazi Upravljene zgrade (many-one)";
            this.cmdPrikaziUZManyToOne.UseVisualStyleBackColor = true;
            this.cmdPrikaziUZManyToOne.Click += new System.EventHandler(this.cmdPrikaziUZManyToOne_Click);
            // 
            // cmdPrikaziUSaZgadama
            // 
            this.cmdPrikaziUSaZgadama.Location = new System.Drawing.Point(209, 219);
            this.cmdPrikaziUSaZgadama.Name = "cmdPrikaziUSaZgadama";
            this.cmdPrikaziUSaZgadama.Size = new System.Drawing.Size(189, 50);
            this.cmdPrikaziUSaZgadama.TabIndex = 26;
            this.cmdPrikaziUSaZgadama.Text = "Prikazi Ugovore sa Zgradama";
            this.cmdPrikaziUSaZgadama.UseVisualStyleBackColor = true;
            this.cmdPrikaziUSaZgadama.Click += new System.EventHandler(this.cmdPrikaziUSaZgadama_Click);
            // 
            // cmdPrikaziBrOsoba
            // 
            this.cmdPrikaziBrOsoba.Location = new System.Drawing.Point(404, 103);
            this.cmdPrikaziBrOsoba.Name = "cmdPrikaziBrOsoba";
            this.cmdPrikaziBrOsoba.Size = new System.Drawing.Size(190, 23);
            this.cmdPrikaziBrOsoba.TabIndex = 27;
            this.cmdPrikaziBrOsoba.Text = "Prikazi Broj Osoba";
            this.cmdPrikaziBrOsoba.UseVisualStyleBackColor = true;
            this.cmdPrikaziBrOsoba.Click += new System.EventHandler(this.cmdPrikaziBrOsoba_Click);
            // 
            // cmdPrikaziTerNos
            // 
            this.cmdPrikaziTerNos.Location = new System.Drawing.Point(404, 133);
            this.cmdPrikaziTerNos.Name = "cmdPrikaziTerNos";
            this.cmdPrikaziTerNos.Size = new System.Drawing.Size(190, 23);
            this.cmdPrikaziTerNos.TabIndex = 28;
            this.cmdPrikaziTerNos.Text = "Prikazi Teretnu nosivost";
            this.cmdPrikaziTerNos.UseVisualStyleBackColor = true;
            this.cmdPrikaziTerNos.Click += new System.EventHandler(this.cmdPrikaziTerNos_Click);
            // 
            // cmdPrikaziZgrade
            // 
            this.cmdPrikaziZgrade.Location = new System.Drawing.Point(208, 277);
            this.cmdPrikaziZgrade.Name = "cmdPrikaziZgrade";
            this.cmdPrikaziZgrade.Size = new System.Drawing.Size(190, 23);
            this.cmdPrikaziZgrade.TabIndex = 29;
            this.cmdPrikaziZgrade.Text = "Prikazi Zgrade";
            this.cmdPrikaziZgrade.UseVisualStyleBackColor = true;
            this.cmdPrikaziZgrade.Click += new System.EventHandler(this.cmdPrikaziZgrade_Click);
            // 
            // cmdDodajZgradu
            // 
            this.cmdDodajZgradu.Location = new System.Drawing.Point(211, 306);
            this.cmdDodajZgradu.Name = "cmdDodajZgradu";
            this.cmdDodajZgradu.Size = new System.Drawing.Size(190, 23);
            this.cmdDodajZgradu.TabIndex = 30;
            this.cmdDodajZgradu.Text = "Dodaj Zgradu";
            this.cmdDodajZgradu.UseVisualStyleBackColor = true;
            this.cmdDodajZgradu.Click += new System.EventHandler(this.cmdDodajZgradu_Click);
            // 
            // cmdVidiSprat
            // 
            this.cmdVidiSprat.Location = new System.Drawing.Point(601, 13);
            this.cmdVidiSprat.Name = "cmdVidiSprat";
            this.cmdVidiSprat.Size = new System.Drawing.Size(189, 23);
            this.cmdVidiSprat.TabIndex = 31;
            this.cmdVidiSprat.Text = "VidiSprat";
            this.cmdVidiSprat.UseVisualStyleBackColor = true;
            this.cmdVidiSprat.Click += new System.EventHandler(this.cmdVidiSprat_Click);
            // 
            // cmdDodajSprat
            // 
            this.cmdDodajSprat.Location = new System.Drawing.Point(601, 43);
            this.cmdDodajSprat.Name = "cmdDodajSprat";
            this.cmdDodajSprat.Size = new System.Drawing.Size(189, 23);
            this.cmdDodajSprat.TabIndex = 32;
            this.cmdDodajSprat.Text = "Dodaj Sprat";
            this.cmdDodajSprat.UseVisualStyleBackColor = true;
            this.cmdDodajSprat.Click += new System.EventHandler(this.cmdDodajSprat_Click);
            // 
            // cmdVidiSpratove
            // 
            this.cmdVidiSpratove.Location = new System.Drawing.Point(14, 219);
            this.cmdVidiSpratove.Name = "cmdVidiSpratove";
            this.cmdVidiSpratove.Size = new System.Drawing.Size(190, 23);
            this.cmdVidiSpratove.TabIndex = 33;
            this.cmdVidiSpratove.Text = "Prikazi Lokal";
            this.cmdVidiSpratove.UseVisualStyleBackColor = true;
            this.cmdVidiSpratove.Click += new System.EventHandler(this.cmdVidiSpratove_Click);
            // 
            // cmdDodajLokal
            // 
            this.cmdDodajLokal.Location = new System.Drawing.Point(14, 248);
            this.cmdDodajLokal.Name = "cmdDodajLokal";
            this.cmdDodajLokal.Size = new System.Drawing.Size(190, 23);
            this.cmdDodajLokal.TabIndex = 34;
            this.cmdDodajLokal.Text = "Dodaj Lokal";
            this.cmdDodajLokal.UseVisualStyleBackColor = true;
            this.cmdDodajLokal.Click += new System.EventHandler(this.cmdDodajLokal_Click);
            // 
            // cmdPrikaziUlaz
            // 
            this.cmdPrikaziUlaz.Location = new System.Drawing.Point(14, 277);
            this.cmdPrikaziUlaz.Name = "cmdPrikaziUlaz";
            this.cmdPrikaziUlaz.Size = new System.Drawing.Size(190, 23);
            this.cmdPrikaziUlaz.TabIndex = 35;
            this.cmdPrikaziUlaz.Text = "Prikazi Ulaz";
            this.cmdPrikaziUlaz.UseVisualStyleBackColor = true;
            this.cmdPrikaziUlaz.Click += new System.EventHandler(this.cmdPrikaziUlaz_Click);
            // 
            // cmdDodajUlaz
            // 
            this.cmdDodajUlaz.Location = new System.Drawing.Point(14, 306);
            this.cmdDodajUlaz.Name = "cmdDodajUlaz";
            this.cmdDodajUlaz.Size = new System.Drawing.Size(190, 23);
            this.cmdDodajUlaz.TabIndex = 36;
            this.cmdDodajUlaz.Text = "Dodaj Ulaz";
            this.cmdDodajUlaz.UseVisualStyleBackColor = true;
            this.cmdDodajUlaz.Click += new System.EventHandler(this.cmdDodajUlaz_Click);
            // 
            // cmdPrikaziGarazu
            // 
            this.cmdPrikaziGarazu.Location = new System.Drawing.Point(602, 72);
            this.cmdPrikaziGarazu.Name = "cmdPrikaziGarazu";
            this.cmdPrikaziGarazu.Size = new System.Drawing.Size(188, 23);
            this.cmdPrikaziGarazu.TabIndex = 37;
            this.cmdPrikaziGarazu.Text = "Prikazi Garazu";
            this.cmdPrikaziGarazu.UseVisualStyleBackColor = true;
            this.cmdPrikaziGarazu.Click += new System.EventHandler(this.cmdPrikaziGarazu_Click);
            // 
            // cmdDodajGarazu
            // 
            this.cmdDodajGarazu.Location = new System.Drawing.Point(602, 101);
            this.cmdDodajGarazu.Name = "cmdDodajGarazu";
            this.cmdDodajGarazu.Size = new System.Drawing.Size(188, 23);
            this.cmdDodajGarazu.TabIndex = 38;
            this.cmdDodajGarazu.Text = "Dodaj Garazu";
            this.cmdDodajGarazu.UseVisualStyleBackColor = true;
            this.cmdDodajGarazu.Click += new System.EventHandler(this.cmdDodajGarazu_Click);
            // 
            // cmdPrikaziStan
            // 
            this.cmdPrikaziStan.Location = new System.Drawing.Point(601, 130);
            this.cmdPrikaziStan.Name = "cmdPrikaziStan";
            this.cmdPrikaziStan.Size = new System.Drawing.Size(188, 23);
            this.cmdPrikaziStan.TabIndex = 39;
            this.cmdPrikaziStan.Text = "Prikazi Stan";
            this.cmdPrikaziStan.UseVisualStyleBackColor = true;
            this.cmdPrikaziStan.Click += new System.EventHandler(this.cmdPrikaziStan_Click);
            // 
            // cmdDodajStan
            // 
            this.cmdDodajStan.Location = new System.Drawing.Point(602, 159);
            this.cmdDodajStan.Name = "cmdDodajStan";
            this.cmdDodajStan.Size = new System.Drawing.Size(188, 23);
            this.cmdDodajStan.TabIndex = 40;
            this.cmdDodajStan.Text = "Dodaj Stan";
            this.cmdDodajStan.UseVisualStyleBackColor = true;
            this.cmdDodajStan.Click += new System.EventHandler(this.cmdDodajStan_Click);
            // 
            // cmdVezaVlasnikIStan
            // 
            this.cmdVezaVlasnikIStan.Location = new System.Drawing.Point(602, 191);
            this.cmdVezaVlasnikIStan.Name = "cmdVezaVlasnikIStan";
            this.cmdVezaVlasnikIStan.Size = new System.Drawing.Size(188, 51);
            this.cmdVezaVlasnikIStan.TabIndex = 42;
            this.cmdVezaVlasnikIStan.Text = "Veza Vlasnik i stan (many-many)";
            this.cmdVezaVlasnikIStan.UseVisualStyleBackColor = true;
            this.cmdVezaVlasnikIStan.Click += new System.EventHandler(this.cmdVezaVlasnikIStan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 450);
            this.Controls.Add(this.cmdVezaVlasnikIStan);
            this.Controls.Add(this.cmdDodajStan);
            this.Controls.Add(this.cmdPrikaziStan);
            this.Controls.Add(this.cmdDodajGarazu);
            this.Controls.Add(this.cmdPrikaziGarazu);
            this.Controls.Add(this.cmdDodajUlaz);
            this.Controls.Add(this.cmdPrikaziUlaz);
            this.Controls.Add(this.cmdDodajLokal);
            this.Controls.Add(this.cmdVidiSpratove);
            this.Controls.Add(this.cmdDodajSprat);
            this.Controls.Add(this.cmdVidiSprat);
            this.Controls.Add(this.cmdDodajZgradu);
            this.Controls.Add(this.cmdPrikaziZgrade);
            this.Controls.Add(this.cmdPrikaziTerNos);
            this.Controls.Add(this.cmdPrikaziBrOsoba);
            this.Controls.Add(this.cmdPrikaziUSaZgadama);
            this.Controls.Add(this.cmdPrikaziUZManyToOne);
            this.Controls.Add(this.cmdPrikaziUSaZap);
            this.Controls.Add(this.cmdDodajUgovor);
            this.Controls.Add(this.cmdVidiAgenciju);
            this.Controls.Add(this.cmdDodajClanaSkupstine);
            this.Controls.Add(this.cmdPrikaziClanaSkupstine);
            this.Controls.Add(this.cmdDodajVlasnikaStana);
            this.Controls.Add(this.cmdPokaziVlasnikaStana);
            this.Controls.Add(this.cmdManyToManyUIL);
            this.Controls.Add(this.cmdDodajLicencu);
            this.Controls.Add(this.cmdPrikaziLicencu);
            this.Controls.Add(this.cmdPrikaziVozilo);
            this.Controls.Add(this.cmdVidiLiftove);
            this.Controls.Add(this.cmdDodajUpravnika);
            this.Controls.Add(this.cmdPrikaziUpravnika);
            this.Controls.Add(this.cmdDodajStanara);
            this.Controls.Add(this.cmdPrikaziStanara);
            this.Controls.Add(this.cmdZaposli);
            this.Controls.Add(this.cmdPrikaziZaposlenog);
            this.Controls.Add(this.cmdInstall);
            this.Controls.Add(this.cmdManyToMany);
            this.Controls.Add(this.cmdDodajVozilo);
            this.Controls.Add(this.cmdOneToMany);
            this.Controls.Add(this.cmdManytoOne);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.cmdPrikazi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdPrikazi;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.Button cmdManytoOne;
        private System.Windows.Forms.Button cmdOneToMany;
        private System.Windows.Forms.Button cmdDodajVozilo;
        private System.Windows.Forms.Button cmdManyToMany;
        private System.Windows.Forms.Button cmdInstall;
        private System.Windows.Forms.Button cmdPrikaziZaposlenog;
        private System.Windows.Forms.Button cmdZaposli;
        private System.Windows.Forms.Button cmdPrikaziStanara;
        private System.Windows.Forms.Button cmdDodajStanara;
        private System.Windows.Forms.Button cmdPrikaziUpravnika;
        private System.Windows.Forms.Button cmdDodajUpravnika;
        private System.Windows.Forms.Button cmdVidiLiftove;
        private System.Windows.Forms.Button cmdPrikaziVozilo;
        private System.Windows.Forms.Button cmdPrikaziLicencu;
        private System.Windows.Forms.Button cmdDodajLicencu;
        private System.Windows.Forms.Button cmdManyToManyUIL;
        private System.Windows.Forms.Button cmdPokaziVlasnikaStana;
        private System.Windows.Forms.Button cmdDodajVlasnikaStana;
        private System.Windows.Forms.Button cmdPrikaziClanaSkupstine;
        private System.Windows.Forms.Button cmdDodajClanaSkupstine;
        private System.Windows.Forms.Button cmdVidiAgenciju;
        private System.Windows.Forms.Button cmdDodajUgovor;
        private System.Windows.Forms.Button cmdPrikaziUSaZap;
        private System.Windows.Forms.Button cmdPrikaziUZManyToOne;
        private System.Windows.Forms.Button cmdPrikaziUSaZgadama;
        private System.Windows.Forms.Button cmdPrikaziBrOsoba;
        private System.Windows.Forms.Button cmdPrikaziTerNos;
        private System.Windows.Forms.Button cmdPrikaziZgrade;
        private System.Windows.Forms.Button cmdDodajZgradu;
        private System.Windows.Forms.Button cmdVidiSprat;
        private System.Windows.Forms.Button cmdDodajSprat;
        private System.Windows.Forms.Button cmdVidiSpratove;
        private System.Windows.Forms.Button cmdDodajLokal;
        private System.Windows.Forms.Button cmdPrikaziUlaz;
        private System.Windows.Forms.Button cmdDodajUlaz;
        private System.Windows.Forms.Button cmdPrikaziGarazu;
        private System.Windows.Forms.Button cmdDodajGarazu;
        private System.Windows.Forms.Button cmdPrikaziStan;
        private System.Windows.Forms.Button cmdDodajStan;
        private System.Windows.Forms.Button cmdVezaVlasnikIStan;
    }
}

