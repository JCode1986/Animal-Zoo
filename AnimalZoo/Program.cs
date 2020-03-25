using Animal_Zoo.Classes;
using Animal_Zoo.Interfaces;
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
            Eagle eagle = new Eagle();
            Pelican pelican = new Pelican();

            //Classes
            /*Console.WriteLine(liger.LigerInfo());
            Console.WriteLine(kangaroo.KangarooInfo());
            Console.WriteLine(komodoDragon.KomodoDragonInfo()); */

            //Interface
            Console.WriteLine(penguin.GoSwim(26));
            Console.WriteLine(sloth.MagicallyIntroduceSelfToHumans("George", 12));
            Console.WriteLine(anaconda.DoAnotherRandomThing(65));

            IFly[] flyers = new IFly[2];

            flyers[0] = eagle;
            flyers[1] = pelican;

            for (int i = 0; i < flyers.Length; i++)
            {
                var flyer = flyers[i];

                if (flyer is Pelican)
                {
                    //casting...
                    //var pel = (Pelican)flyer;
                    Console.WriteLine($"{flyer.Land(421)}");
                }
                else if (flyer is Eagle)
                {
                    var eag = (Eagle)flyer;
                    Console.WriteLine($"{ eag.Land(66)}");
                }
                fly(flyers[i]);
            }
        }
        static void fly(IFly bird)
        {
            Console.WriteLine(bird.WingSpan);
            Console.WriteLine(bird.SpreadWings());
            Console.WriteLine(bird.SpreadWings());
            Console.WriteLine(bird.FlapWings());
            Console.WriteLine(bird.Soar());
            Console.WriteLine();
        }
    }
}
