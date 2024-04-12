using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Animale cane = new Cane();
        cane.Verso();
        cane.Muoversi();

        Animale gatto = new Gatto();
        gatto.Verso();
        gatto.Muoversi();
    }

    //List<IAnimale> animali = new List<IAnimale>();

    //List<Animale> listaAnimali = new List<Animale>();
}