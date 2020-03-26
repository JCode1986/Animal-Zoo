using Animal_Zoo.Classes;
using Animal_Zoo.Interfaces;
using System;

namespace Animal_Zoo.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();


            Anaconda anaconda = new Anaconda();

        }

        static void Start()
        {
            try
            {
                string input = "";
                Console.WriteLine("\nHi! Welcome the Animal Zoo!");
                Console.WriteLine("Here are the animals available!");
                Console.WriteLine("'1' - Kangaroo");
                Console.WriteLine("'2' - Liger");
                Console.WriteLine("'3' - Komodo Dragon");
                Console.WriteLine("'4' - Penguin");
                Console.WriteLine("'5' - Sloth");
                Console.WriteLine("'6' - Anaconda");
                Console.WriteLine("'7' - Look at the flying animals");
                Console.Write("Which animal would you like to look at?: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Kangaroo kangaroo = new Kangaroo();
                        string kangarooResponse = AnimalMenu();
                        AnimalInfo(kangarooResponse, kangaroo);
                        break;

                    case "2":
                        Liger liger = new Liger();
                        string ligerresponse = AnimalMenu();
                        AnimalInfo(ligerresponse, liger);
                        break;

                    case "3":
                        KomodoDragon komodoDragon = new KomodoDragon();
                        string komodoDragonResponse = AnimalMenu();
                        AnimalInfo(komodoDragonResponse, komodoDragon);
                        break;

                    case "4":
                        Penguin penguin = new Penguin();
                        Console.Write("'1' Go underwater? or '2' Go swim?: ");
                        string penguinReponse = Console.ReadLine();
                        if (penguinReponse == "1") Console.WriteLine(penguin.GoDiveUnderWater());
                        if (penguinReponse == "2")
                        {
                            Console.Write("How fast (mph) would you like the penguin to swim?: ");
                            Console.WriteLine();
                            int speed = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(penguin.GoSwim(speed));
                        }
                        break;

                    case "5":
                        Sloth sloth = new Sloth();

                        Console.WriteLine("The sloth can do these things:");
                        Console.WriteLine("'1' - Do a random thing");
                        Console.WriteLine("'2' - Do another random thing based on irritation level out of a 100");
                        Console.WriteLine("'3' - Magically introduce self after given a name and age");
                        Console.Write("What would you like the sloth to do?");

                        string slothResponse = Console.ReadLine();

                        if (slothResponse == "1") Console.WriteLine(sloth.DoRandomThing());
                        if (slothResponse == "2")
                        {
                            Console.WriteLine("Enter a number out of 100: ");
                            int randomInput = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(sloth.DoAnotherRandomThing(randomInput));
                        }
                        if (slothResponse == "3")
                        {
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Age: ");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(sloth.MagicallyIntroduceSelfToHumans(name, age));
                        }

                        break;

                    case "7":
                        Console.WriteLine(FlyingAnimals());
                        break;

                    default:
                        Console.WriteLine("Enter a valid number");
                        break;
                }
                Start();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static string AnimalMenu()
        {
            Console.Clear();
            Console.WriteLine("'1' - Average Weight");
            Console.WriteLine("'2' - Average Speed");
            Console.WriteLine("'3' - Average Length");
            Console.WriteLine("'4' - Diet");
            Console.WriteLine("'5' - Ability");
            Console.WriteLine("'5' - Sound");
            Console.WriteLine("'6' - Eat");
            Console.WriteLine("'7' - Information");
            string input = Console.ReadLine();
            Console.WriteLine();
            return input;
        }

        static void AnimalInfo(string input, Animal animal)
        {
            if (input == "1") Console.WriteLine(animal.AverageWeightLBS);
            if (input == "2") Console.WriteLine(animal.AverageMaxSpeedMPH);
            if (input == "3") Console.WriteLine(animal.AverageLength);
            if (input == "4") Console.WriteLine(animal.Diet);
            if (input == "5") Console.WriteLine(animal.Ability());
            if (input == "6") Console.WriteLine(animal.Eat());
            if (input == "7") Console.WriteLine(animal.AnimalInfo());
        }

        static string FlyingAnimals()
        {
            Eagle eagle = new Eagle();
            Pelican pelican = new Pelican();

            IFly[] flyers = new IFly[2];

            flyers[0] = eagle;
            flyers[1] = pelican;

            for (int i = 0; i < flyers.Length; i++)
            {
                var flyer = flyers[i];

                if (flyer is Pelican)
                {
                    var pel = (Pelican)flyer;
                    Console.WriteLine($"Pelican has a wingspan of {pel.WingSpan}");
                }
                else if (flyer is Eagle)
                {
                    var eag = (Eagle)flyer;
                    Console.WriteLine($"Eagle has a wingspan of {eagle.WingSpan}");
                }
                fly(flyers[i]);
            }
            return "";
        }
        static string fly(IFly bird)
        {
            Console.WriteLine(bird.SpreadWings());
            Console.WriteLine(bird.FlapWings());
            Console.WriteLine(bird.Soar());
            Console.WriteLine(bird.Land(60));
            Console.WriteLine();
            return "";
        }
    }
}
