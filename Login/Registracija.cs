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
    public partial class Registracija : Form
    {
        private Korisnik korisnik;
        bool edit;
        KonekcijaNaBazu konekcija = DLWMS.DB;

        public Registracija()
        {
            InitializeComponent();
            txtLozinka.Text = GenerisiLozinku(10);
            try
            {
                cmbSpol.DataSource = konekcija.Spolovi.ToList();
                cmbSpol.DisplayMember = "Naziv";
                cmbSpol.ValueMember = "Id";
            }
            catch (Exception err)
            {

                MessageBox.Show("Greska-> "+err.Message+" "+err.InnerException?.Message);
            }   
            korisnik = new Korisnik();
        }

       public Registracija(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;            
            UcitajPodatkeOKorisniku();
            edit = true;
            
        }

        private void UcitajPodatkeOKorisniku()
        {
            try
            {
                txtName.Text = korisnik.Ime;
                txtLastName.Text = korisnik.Prezime;
                txtLozinka.Text = korisnik.Lozinka;
                txtUsername.Text = korisnik.KorisnickoIme;
                pbDodajSliku.Image = ImageHelper.FromByteToImage(korisnik.Slika);
                cmbSpol.SelectedValue = korisnik.Spol.Id;
                cbAdmin.Checked = korisnik.Admin;
            }
            catch(Exception err)
            {
                MessageBox.Show("Greska-> "+err.Message);
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {               
                korisnik.Ime = txtName.Text;
                korisnik.Prezime = txtLastName.Text;
                korisnik.KorisnickoIme = txtUsername.Text;
                korisnik.Lozinka = txtLozinka.Text;
                korisnik.Slika = ImageHelper.FromImageToByte(pbDodajSliku.Image);
                korisnik.Admin = cbAdmin.Checked;
                korisnik.Spol = cmbSpol.SelectedItem as Spolovi;

                if (!edit)
                {
                    //korisnik.ID = DBinMemory.RegistrovaniKorisnici.Count + 1;
                    //DBinMemory.RegistrovaniKorisnici.Add(korisnik);
                    konekcija.Korisnici.Add(korisnik);
                    konekcija.SaveChanges();
                    MessageBox.Show("Registracija uspjesno zavrsena");
                }
                else
                {
                    konekcija.Entry(korisnik).State = System.Data.Entity.EntityState.Modified;
                    konekcija.SaveChanges();
                    MessageBox.Show("Edit uspjesno zavrsen");
                }
                DialogResult = DialogResult.OK;
                Close();
            }
                
        }
      
        private bool ValidirajUnos()
        {

            return Validator.ObaveznoPolje(txtName, err, Validator.poruka) &&
                Validator.ObaveznoPolje(txtLastName, err, Validator.poruka) &&
                Validator.ObaveznoPolje(pbDodajSliku, err, Validator.poruka) &&
                Validator.ObaveznoPolje(cmbSpol, err, Validator.poruka);
        }

        private string GenerisiLozinku(int brojZnakova)
        {
            string novaLozinka = "";
            string dozvoljeniZnakovi = "dsk6p5l47&94#@djalsj3x1";
            Random random = new Random();
            for (int i = 0; i < brojZnakova; i++)
            {
                novaLozinka += dozvoljeniZnakovi[random.Next(0, dozvoljeniZnakovi.Length)];
            }
            return novaLozinka;
        }
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = $"{txtName.Text}.{txtLastName.Text}".ToLower();
        }

        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = $"{txtName.Text}.{txtLastName.Text}".ToLower();
        }

        private void Registracija_Load(object sender, EventArgs e)// cim se otvori forma da se generise lozinka
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            char prazan = new char();
            if (txtLozinka.PasswordChar == prazan)
                txtLozinka.PasswordChar = '*';
            else txtLozinka.PasswordChar = prazan;
        }

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdUcitajSliku.ShowDialog() == DialogResult.OK)
                {
                    string putanjaDoSlike = ofdUcitajSliku.FileName;
                    Image slika = Image.FromFile(putanjaDoSlike);
                    pbDodajSliku.Image = slika;
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Greska-> "+err.Message);
            }
        }

        private void PbDodajSliku_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {

        }

        private void TxtLozinka_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void CmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
