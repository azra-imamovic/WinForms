using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Višenitnost : Form
    {
        public Višenitnost()
        {
            InitializeComponent();
        }

        string zaIspis;
        private void BtnPokreni_Click(object sender, EventArgs e)
        {

            //Thread t1 = new Thread(ProvjeriBazu);
            //Thread t2 = new Thread(ProvjeriKonekciju);
            //Thread t3 = new Thread(ProvjeriPrivilegije);
            //t1.Start();
            //t2.Start();
            //t3.Start();
            async void metoda(){

               await Task.Run(ProvjeriBazu);
               await Task.Run(ProvjeriKonekciju);
               await Task.Run(ProvjeriPrivilegije);

            }
            metoda();

        }

        private void ProvjeriPrivilegije()
        {
            Thread.Sleep(1000);
            Action action=()=> txtIspis.Text += "Privilegije OK..." + Environment.NewLine;
            BeginInvoke(action);
        }

        private void ProvjeriKonekciju()
        {
            Thread.Sleep(1000);
            Action action = () => txtIspis.Text += "Konekcija OK..." + Environment.NewLine;
            BeginInvoke(action);
            
        }

        private void ProvjeriBazu()
        {
            Thread.Sleep(100);
            Action action = () => txtIspis.Text += "Baza OK..." + Environment.NewLine;
            BeginInvoke(action);
            
        }

        private void Višenitnost_Load(object sender, EventArgs e)
        {

        }
    }
}
