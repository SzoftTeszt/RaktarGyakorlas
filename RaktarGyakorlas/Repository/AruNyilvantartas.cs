using RaktarGyakorlas.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktarGyakorlas.Repository
{
    public class AruNyilvantartas
    {
        private List<Aru> aruLista;

        public AruNyilvantartas()
        {
            aruLista = new List<Aru>();
            Seeder();
        }

        public void Seeder() { 
         var sorok = File.ReadAllLines(@"c:\adat\ekszerek.csv");
            foreach (var sor in sorok)
            {
                aruLista.Add(new Aru(sor));
            }
        }
        public List<Aru> OsszesAruLekerdez() { 
            return aruLista;
        }
    }
}
