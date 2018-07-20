using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoljiSvijetBiblioteka
{
    public class Ruksak
    {
        public string Name { get; set; }

        public List<Dobavljac> Dobavljaci { get; set; }
        public List<Predmet> Predmeti { get; set; }

        /*Ovdje ćemo kreirati novi kontruktor koji će istancirati liste Vendora i proizvoda*/
        public Ruksak()
        {
            Dobavljaci = new List<Dobavljac>();
            Predmeti = new List<Predmet>();
        }
    }
}
