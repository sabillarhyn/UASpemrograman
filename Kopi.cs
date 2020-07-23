using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopi
{
    public abstract class Kopi
    {
        public string Nama { get; set; }
        public abstract double Harga();
       
    }
}
