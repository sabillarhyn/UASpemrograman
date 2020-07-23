using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopi
{
    public class Ice : Kopi
    {
        public double HargaIce { get; set; }
        public override double Harga()
        {
            return HargaIce;
        }
        public static void Menu()
        {
            Console.WriteLine("\n\t\t ~*Menu Ice Coffee*~\n");
        }
    }
}
