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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtUsername.Text;
            string lozinka = txtPassword.Text;
            bool pronadjen = false;
            if (ValidirajUnos())
            {
                
                    foreach (var korisnik in DBinMemory.RegistrovaniKorisnici)
                    {
                        if (korisnickoIme == korisnik.KorisnickoIme && lozinka == korisnik.Lozinka)
                        {
                            MessageBox.Show("Dobro došli " + " " + korisnik);
                            pronadjen = true;
                        }
                    
                    if (!pronadjen)
                        MessageBox.Show("Podaci nisu validni");
                }
            }

        }

        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(txtUsername, err2, Validator.poruka) && Validator.ObaveznoPolje(txtPassword, err2, Validator.poruka);
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registracija registracija = new Registracija();
            // registracija.Show(); omogucava prelazak sa forme na formu
            registracija.ShowDialog(); //kad otvorimo jednu formu, ne mozemo se vratiti na drugu

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelUsername_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
