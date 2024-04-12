using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cane : Animale
{
    public override void Verso()
    {
        Console.WriteLine("Il cane abbaia");
    }

    public override void Muoversi()
    {
        Console.WriteLine("Il cane sta correndo");
    }
}