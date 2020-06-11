using System;
using static System.Console;

namespace HeroGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Shrek shrek = new Shrek();
            Elf osel = new Elf();
            WriteLine(shrek.Print());
            WriteLine(osel.Print());
            shrek.InflictDamage(osel);
            WriteLine(shrek.Print());
            WriteLine(osel.Print());
            Gendalf gendalf = new Gendalf();
            WriteLine(shrek.Print());
            WriteLine(gendalf.Print());
            gendalf.InflictMagicDamage(shrek);
            WriteLine(shrek.Print());
            WriteLine(gendalf.Print());
        }
    }
}
