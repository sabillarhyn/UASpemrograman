using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ice ice = new Ice();
            ice.Nama = "Ice Americano";
            ice.HargaIce = 22000;

            Ice ice2 = new Ice();
            ice2.Nama = "Ice Cappuchino";
            ice2.HargaIce = 24000;

            Ice ice3 = new Ice();
            ice3.Nama = "Ice Latte";
            ice3.HargaIce = 24000;

            Ice ice4 = new Ice();
            ice4.Nama = "Ice Long Black";
            ice4.HargaIce = 20000;

            Ice ice5 = new Ice();
            ice5.Nama = "Ice Mochaccino";
            ice5.HargaIce = 26000;

            Ice ice6 = new Ice();
            ice6.Nama = "Ice Affogato";
            ice6.HargaIce = 22000;

            Hot hot = new Hot();
            hot.Nama = "Hot Cappuchino";
            hot.HargaHot = 22000;

            Hot hot2 = new Hot();
            hot2.Nama = "Hot Espresso";
            hot2.HargaHot = 14000;

            Hot hot3 = new Hot();
            hot3.Nama = "Hot Latte";
            hot3.HargaHot = 22000;

            Hot hot4 = new Hot();
            hot4.Nama = "Hot Long Black";
            hot4.HargaHot = 18000;

            Hot hot5 = new Hot();
            hot5.Nama = "Hot Mochaccino";
            hot5.HargaHot = 24000;

            Hot hot6 = new Hot();
            hot6.Nama = "Hot Piccolo";
            hot6.HargaHot = 20000;

            Snack snack = new Snack();
            snack.Nama = "Roti Bakar";
            snack.HargaSnack = 8000;

            Snack snack2 = new Snack();
            snack2.Nama = "Cireng";
            snack2.HargaSnack = 5000;

            Snack snack3 = new Snack();
            snack3.Nama = "French Fries";
            snack3.HargaSnack = 15000;

            Snack snack4 = new Snack();
            snack4.Nama = "Lumpia";
            snack4.HargaSnack = 12000;

            Snack snack5 = new Snack();
            snack5.Nama = "Dimsum";
            snack5.HargaSnack = 15000;

            Snack snack6 = new Snack();
            snack6.Nama = "Chicken Wings";
            snack6.HargaSnack = 22000;

 
            List<Kopi> listKopiIce = new List<Kopi>();
            listKopiIce.Add(ice);
            listKopiIce.Add(ice2);
            listKopiIce.Add(ice3);
            listKopiIce.Add(ice4);
            listKopiIce.Add(ice5);
            listKopiIce.Add(ice5);

            List<Kopi> listKopiHot = new List<Kopi>(); 
            listKopiHot.Add(hot);
            listKopiHot.Add(hot2);
            listKopiHot.Add(hot3);
            listKopiHot.Add(hot4);
            listKopiHot.Add(hot5);
            listKopiHot.Add(hot6);

            List<Snack> lsnacks = new List<Snack>();
            lsnacks.Add(snack);
            lsnacks.Add(snack2);
            lsnacks.Add(snack3);
            lsnacks.Add(snack4);
            lsnacks.Add(snack5);
            lsnacks.Add(snack6);

            Console.WriteLine("=========================================================");
            Console.WriteLine("\n\t\t     COFFEE BENE\n");
            Console.WriteLine("=========================================================");
            Console.WriteLine("\n\t\t\tMenu\n");
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Hot.Menu();
                int noUrut = 1;
                foreach (Kopi kopi in listKopiHot)
                {

                    Console.WriteLine("\t\t{0}.{1} \n \t\t\tIDR : Rp.{2:N0},-\n", noUrut, kopi.Nama, kopi.Harga());

                    noUrut++;
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Ice.Menu();
            int nmr = 1;
            foreach (Kopi kopi in listKopiHot)
            {

                Console.WriteLine("\t\t{0}.{1} \n \t\t\tIDR : Rp.{2:N0},-\n", nmr, kopi.Nama, kopi.Harga());

                nmr++;
            }

            Console.WriteLine("\n");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Snack.Menu();
            int no = 1;
            foreach (Snack kopi in lsnacks)
            {

                Console.WriteLine("\t\t{0}.{1} \n \t\t\tIDR : Rp.{2:N0},-\n", no, kopi.Nama, kopi.Harga());

                no++;
            }
            Console.ReadKey();
        }
    }
}
