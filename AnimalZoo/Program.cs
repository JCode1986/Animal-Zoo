using Animal_Zoo.Classes;
using System;

namespace Animal_Zoo.Classes
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
            Penguin penguin = new Penguin();


            //Classes
            /*Console.WriteLine(liger.LigerInfo());
            Console.WriteLine(kangaroo.KangarooInfo());
            Console.WriteLine(komodoDragon.KomodoDragonInfo()); */

            //Interface
            Console.WriteLine(penguin.GoSwim(26));
            Console.WriteLine(sloth.MagicallyIntroduceSelfToHumans("George", 12));
            Console.WriteLine(anaconda.DoAnotherRandomThing(65));
        }
    }
}
