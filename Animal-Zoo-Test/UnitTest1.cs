using System;
using Xunit;
using Animal_Zoo.Classes;

namespace Animal_Zoo_Test
{
    public class UnitTest1
    {
        //Classes inheritating from abstract classes
        Kangaroo kangaroo = new Kangaroo();
        Liger liger = new Liger();
        KomodoDragon komodoDragon = new KomodoDragon();

        //Classes implementing interface
        Anaconda anaconda = new Anaconda();
        Sloth sloth = new Sloth();
        Eagle eagle = new Eagle();
        Penguin penguin = new Penguin();
        Pelican pelican = new Pelican();

        //=============================== Interface ===============================
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
        public void TestInterfaceImplementsMethods3()
        {
            string actual = anaconda.MagicallyIntroduceSelfToHumans("SSSSam", 7);
            string expected = $"SSSSSalutationsss! My name isssss SSSSam, and I am 7 year(sssssss) old. SSSSSee you later.";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInterfaceImplementsMethods4()
        {
            string actual = sloth.DoAnotherRandomThing(60);
            string expected = $"*Farts";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInterfaceImplementsMethods5()
        {
            string actual = penguin.GoSwim(60);
            string expected = $"I am finding Nemo";
            Assert.Equal(expected, actual);
        }

        //=============================== Inheritance ===============================
        [Fact]
        public void TestInheritanceLiger1()
        {
            int actual = liger.AverageWeightLBS;
            int expected = 1000;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInheritanceLiger2()
        {
            string actual = liger.Eat();
            string expected = $"{liger.Hunt()}. *spots a gazelle* {liger.Sound()} *pounce and eats*";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInheritanceKangaroo1()
        {
            string actual = kangaroo.Eat();
            string expected = $"{kangaroo.Sound()}*Pulls flowers out of pouch and start eating*";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInheritanceKangaroo2()
        {
            string actual = kangaroo.Ability();
            string expected = $"Jump!";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInheritanceKomodoDraogon1()
        {
            string actual = komodoDragon.Ability();
            string expected = "*Venomous bite attack!";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInheritanceKomodoDraogon2()
        {
            bool actual = komodoDragon.HasScales;
            Assert.True(actual);
        }
    }
}
