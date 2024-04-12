using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Gatto : Animale
{
    public override void Verso()
    {
        Console.WriteLine("Il gatto miagola");
    }

    public override void Muoversi()
    {
        Console.WriteLine("Il gatto salta");
    }
}