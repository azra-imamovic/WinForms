using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class PolozeniPredmeti : Form
    {
        private Korisnik korisnik;
        KonekcijaNaBazu konekcija = DLWMS.DB;

        public PolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        public PolozeniPredmeti(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }

        private void PolozeniPredmeti_Load(object sender, EventArgs e)
        {

            UcitajPredmete();
            UcitajPolozenePredmete();
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = konekcija.Predmeti.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = korisnik.Polozeni.ToList();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Predmeti odabraniPredmet = cmbPredmeti.SelectedItem as Predmeti;
                ProvjeriDaLiPredmetPostoji(odabraniPredmet);
                KorisniciPredmeti polozeniPredmet = new KorisniciPredmeti();
                //polozeniPredmet.Id = korisnik.Polozeni.Count + 1;
                polozeniPredmet.Predmet = odabraniPredmet;
                polozeniPredmet.Ocjena = int.Parse(txtOcjena.Text);
                polozeniPredmet.Datum = dtpDatum.Value.ToString("dd.MM.yyyy");
                korisnik.Polozeni.Add(polozeniPredmet);
                konekcija.SaveChanges();
                UcitajPolozenePredmete();

                //p = cmbPredmeti.SelectedItem as Predmeti;
                // p.Ocjena = int.Parse(txtOcjena.Text);
                // p.DatumPolaganja = dtpDatum.Value.ToString();
                // korisnik.Polozeni.
                // UcitajPolozenePredmete();
            }
            catch(Exception err)
            {
                MboxHelper.PrikaziGresku(err);
            }
            

        }
        private void ProvjeriDaLiPredmetPostoji(Predmeti odabraniPredmet)
        {
            if (korisnik.Polozeni.Where(x => x.Predmet.Id == odabraniPredmet.Id).Count() > 0)
                throw new Exception($"Predmet {odabraniPredmet} je vec evidentiran korisniku {korisnik}");
        }
    }
}
