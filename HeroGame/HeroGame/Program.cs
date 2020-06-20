using System;
using static System.Console;

namespace HeroGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Shrek shrek = new Shrek();
            Elf elf = new Elf();
            WriteLine(shrek.Print());
            WriteLine(elf.Print());
            WriteLine(shrek.InflictDamage(elf));

        }
    }
}
