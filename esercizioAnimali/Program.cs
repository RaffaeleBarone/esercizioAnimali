using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Cane cane = new Cane();
        cane.Verso();
        cane.Muoversi();

        Gatto gatto = new Gatto();
        gatto.Verso();
        gatto.Muoversi();
    }
}