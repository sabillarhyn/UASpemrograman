using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopi
{
    public class Snack : Kopi
    {
        public double HargaSnack { get; set; }
        public override double Harga()
        {
            return HargaSnack;
        }
        public static void Menu()
        {
            Console.WriteLine("\n\t\t  ~*Menu Snack*~\n");
        }
    }
}
