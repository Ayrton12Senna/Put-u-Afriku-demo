
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoljiSvijetBiblioteka
{
    public class Dobavljac
    {
        public string NazivTvrtke { get; set; }

        //public string LastName { get; set; }

        //public double Commission { get; set; }
        /* ne želimo svaki put upisivati Commission. Želimo postaviti neku defaultnu vrijednost.
        To ćemo učiniti koristeći kontruktor. 
        Konstruktor je specijalna metoda koja se pokreće svaki put kada se kreira nova istanca ove klase.
        */
        //public decimal PaymentDue { get; set; }

        public string Prikazi
        {
            get
            {
                //      return string.Format("{0} - {1} kn", NazivTvrtke, PaymentDue);
                return string.Format("{0}", NazivTvrtke);
            }
        }
        /*public Dobavljac() //primjetiti da kontruktor nema tip. On se pokreće kad se istancira klasa i ne treba vratiti nikakvu vrijednost (nema čak niti void, to je posebna metoda)
        {
            Commission = .5;
        }
        */
    }
}
