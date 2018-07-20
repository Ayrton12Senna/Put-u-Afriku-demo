using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoljiSvijetBiblioteka
{
    public class Predmet
    {
        public string Naziv { get; set; }

        public string OpisProizvoda { get; set; }

        public decimal Cijena { get; set; }

        public bool Prodano  { get; set; }

       // public bool PaymentDistrbuted { get; set; }

        public Dobavljac dobavljacProizvoda { get; set; }
        
        public string Prikazi
        {
            get
            {
                return string.Format("{0} - {1} kn", Naziv, Cijena);
            }
        }
    }
}
