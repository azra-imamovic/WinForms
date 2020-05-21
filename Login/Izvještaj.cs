using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Login
{
    public partial class Izvještaj : Form
    {
        private Korisnik korisnik;

        public Izvještaj()
        {
            InitializeComponent();
        }

        public Izvještaj(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }

        private void Izvještaj_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();//kada imamo više parametara u izvještaju koristimo ovaj tip objekta
            rpc.Add(new ReportParameter("ImePrezime", korisnik.Ime+" "+korisnik.Prezime)); //ime parametra(iz reporta) i vrijednost parametra
            rpc.Add(new ReportParameter("Indeks", korisnik.KorisnickoIme));

                       
            //DSKorisnici.tblPolozeniDataTable tbl = new DSKorisnici.tblPolozeniDataTable();
            int i = 1;
            List <object> lista= new List<object>();
            foreach (var korisnik in korisnik.Polozeni)
            {
                lista.Add(new
                {
                    Rb = i++,
                    Naziv = korisnik.Predmet.Naziv,
                    Ocjena = korisnik.Ocjena,
                    Datum = korisnik.Datum,


                });

                //DSKorisnici.tblPolozeniRow red = tbl.NewtblPolozeniRow();
                //red.Rb = i++;
                //red.Naziv = korisnik.Predmet.Naziv;
                //red.Ocjena = korisnik.Ocjena;
                //red.Datum = korisnik.Datum;
                //tbl.Rows.Add(red);
            }
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DLWMS";
            rds.Value = lista;
            rptvIzvjestaj.LocalReport.SetParameters(rpc);
            rptvIzvjestaj.LocalReport.DataSources.Add(rds);
            this.rptvIzvjestaj.RefreshReport();
            
        }
    }
}
