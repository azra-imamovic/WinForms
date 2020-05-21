using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class DBinMemory
    {
        public static List<Korisnik> RegistrovaniKorisnici { get; set; }
        public static List<string> Spolovi { get; set; }
        public static List<Predmet> Predmeti { get; set; }
        static DBinMemory()
        /*Statički konstruktor je posebna vrsta konstruktora koji se automatski poziva. On je 
          zadužen da obavi sve pripreme za statičke članove. Nije public i ne može imati
          parametre*/
        {
            RegistrovaniKorisnici = new List<Korisnik>();
            Spolovi = new List<string>();
            Predmeti = new List<Predmet>();
            DodajPodrazumijevaneKorisnike();
            DodajPredmete();
            DodajSpolove();
        }

        private static void DodajPredmete()
        {
            for(int i=1;i<20;i++)
            {
                Predmeti.Add(new Predmet { ID = i, Naziv = "Predmet " + i });
            }
        }

        private static void DodajSpolove()
        {
            string muski = "Male";
            string zenski = "Female";
            string ostalo = "****";
            Spolovi.Add(muski);
            Spolovi.Add(zenski);
            Spolovi.Add(ostalo);
        }

        private static void DodajPodrazumijevaneKorisnike()
        {
            Korisnik k1 = new Korisnik() { Id = 1, Ime = "Denis", Prezime = "Music", KorisnickoIme = "denis", Lozinka = "denis" };
            k1.Spol = new Spolovi() { Naziv = "Muski" };
            Korisnik k2 = new Korisnik() { Id = 2, Ime = "Jasmin", Prezime = "Azemovic", KorisnickoIme = "jasmin", Lozinka = "jasmin" };
            k2.Spol = new Spolovi() { Naziv = "Muski" };
            RegistrovaniKorisnici.Add(k1);
            RegistrovaniKorisnici.Add(k2);
        }
    }
}

