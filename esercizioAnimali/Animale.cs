//public abstract class Animale :IAnimale
//{
//    public abstract void Verso();
//    public abstract void Muoversi();

//    List<IAnimale> animali = new List<IAnimale>();
//}


public class Animale
{
    public virtual void Verso()
    {
        Console.WriteLine("L'animale fa questo verso:");
    }

    public virtual void Muoversi()
    {
        Console.WriteLine("L'animale si muove");
    }
}
