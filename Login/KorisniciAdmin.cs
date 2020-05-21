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
    
    public partial class KorisniciAdmin : Form
    {
        KonekcijaNaBazu konekcija = DLWMS.DB;
        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnDodajKorisnika_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
            LoadData();
                      
        }

       
        private void LoadData(List<Korisnik>korisnici=null)
        {
            //dgvKorisnici.DataSource = null;
            //dgvKorisnici.DataSource = korisnici ?? DBinMemory.RegistrovaniKorisnici;
            try
            {
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici ?? konekcija.Korisnici.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska-> " + ex.Message + " " + ex.InnerException?.Message);
            }
           
        }

        private void TxtPretraga_TextChanged(object sender, EventArgs e) // KORISTECI LINQ PRISTUP
        {
            
            string filter = txtPretraga.Text.ToLower();
            if (string.IsNullOrEmpty(filter))
            {
                LoadData();
            }
            else
            {
                List<Korisnik> rezultat = konekcija.Korisnici.Where
                (korisnik => korisnik.Ime.ToLower().Contains(filter) || korisnik.Prezime.ToLower().Contains(filter)).ToList();
                LoadData(rezultat);
            }
           
        }
        //private void TxtPretraga_TextChanged(object sender, EventArgs e) ->KORISTECI KLASICNI PRISTUP
        //{
        //    string filter = txtPretraga.Text.ToLower();
        //    List<Korisnik> rezultat = new List<Korisnik>();
        //    foreach (var korisnik in DBinMemory.RegistrovaniKorisnici)
        //    {
        //        if (korisnik.Ime.ToLower().Contains(filter) || korisnik.Prezime.ToLower().Contains(filter))
        //            rezultat.Add(korisnik);

        //    }
        //    LoadData(rezultat);

        //}
        //private void DgvKorisnici_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (dgvKorisnici.SelectedRows.Count > 0)
        //    {
        //        Korisnik korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
        //        if (korisnik != null)
        //        {
        //            Registracija reg = new Registracija(korisnik);
        //            reg.ShowDialog();
        //            LoadData();
        //        }
        //    }
        //}
        private void DgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Korisnik korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
           if (korisnik != null)
            {
                if (e.ColumnIndex == 5)
                {
                    PolozeniPredmeti forma = new PolozeniPredmeti(korisnik);
                    forma.ShowDialog();
                }
                else if (e.ColumnIndex == 6)
                {
                    Task.Run(() =>
                    {
                        Izvještaj forma = new Izvještaj(korisnik);
                        forma.ShowDialog();
                    });

                }
                else
                {
                    Registracija reg = new Registracija(korisnik);
                    reg.ShowDialog();
                    LoadData();
                }
            }
        }
    }
}
