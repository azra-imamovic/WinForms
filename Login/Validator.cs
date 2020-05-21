using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    class Validator
    {
        
        public const string poruka = "Obavezna vrijednost";
        public static bool ObaveznoPolje(Control control,ErrorProvider err, string Poruka)
        {
            if (control is TextBox && (control as TextBox).Text == "")
            {
                err.SetError(control, Poruka);
                return false;
            }
            else if (control is ComboBox && (control as ComboBox).SelectedIndex == -1)
            {                 // ako je selectedIndeks=-1, to znaci da je korsinik unio neku vrijednost
                //koja ne postoji u nasoj listi
                err.SetError(control, Poruka);
                return false;
            }
            else if (control is PictureBox && (control as PictureBox).Image == null)
            {
                err.SetError(control, Poruka);
                return false;
            }
         
                err.Clear();
                return true;
            
           
        }

    }
}
