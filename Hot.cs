using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopi
{
    public class Hot : Kopi
    {
        public double HargaHot { get; set; }
        public override double Harga()
        {
            return HargaHot;
        }
        public static void Menu()
        {
            Console.WriteLine("\n\t\t ~*Menu Hot Coffee*~\n");
        }
    }
}
