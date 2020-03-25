using System;
using Zoo.Classes;

namespace Animal_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Kangaroo kangaroo = new Kangaroo();
            Sloth sloth = new Sloth();
            Liger liger = new Liger();
            KomodoDragon komodoDragon = new KomodoDragon();
            Anaconda anaconda = new Anaconda();

            Console.WriteLine(liger.LigerInfo());
            Console.WriteLine(sloth.SlothInfo());
            Console.WriteLine(kangaroo.KangarooInfo());
            Console.WriteLine(komodoDragon.KomodoDragonInfo());
            Console.WriteLine(anaconda.AnacondaInfo());
        }
    }
}
