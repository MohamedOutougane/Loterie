using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    internal class Partie
    {
        public int idPartie { get; set; }
        public string resultatTirage { get; set; }
        public int Cagnotte { get; set; }
        public DateTime Date { get; set; }
    }
}
