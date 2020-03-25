using System;
using Xunit;
using Animal_Zoo.Classes;

namespace Animal_Zoo_Test
{
    public class UnitTest1
    {
        Kangaroo kangaroo = new Kangaroo();
        Sloth sloth = new Sloth();
        Liger liger = new Liger();
        KomodoDragon komodoDragon = new KomodoDragon();
        Anaconda anaconda = new Anaconda();
        Penguin penguin = new Penguin();
        Eagle eagle = new Eagle();
        Pelican pelican = new Pelican();

        [Fact]
        public void TestInterfaceImplementsMethods1()
        {
            string actual = eagle.Soar();
            string expected = "just looking for some prey";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInterfaceImplementsMethods2()
        {
            string actual = pelican.SpreadWings();
            string expected = "Pelican spreads wings";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInheritance()
        {
            int actual = liger.AverageWeightLBS;
            int expected = 1000;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInheritance2()
        {
            string actual = kangaroo.Eat();
            string expected = $"{kangaroo.Sound()}*Pulls flowers out of pouch and start eating*";
            Assert.Equal(expected, actual);
        }
    }
}
