using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bejegyzes> lista1 = new List<Bejegyzes>();
            List<Bejegyzes> lista2 = new List<Bejegyzes>();

            Console.WriteLine("Kérelek adja meg a darabszámot: ");
            int db = Console.Read();
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("adj egy szerzőt: ");
                string szerzo = Console.ReadLine();
                Console.WriteLine("adj egy tartalmat: ");
                string tartalom = Console.ReadLine();
                Bejegyzes b = new Bejegyzes(szerzo, tartalom);
                lista1.Add(b);
            }



            Console.ReadLine();
        }
    }
}
