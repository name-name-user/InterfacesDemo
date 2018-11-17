using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Elf Fingon = new Elf("Fingon", 15);
            Orc Ugluk = new Orc("Ugluk", 25);
            Console.WriteLine($"Elf.Health = {Fingon.Health}, Orc.Health = {Ugluk.Health}");
            while (Fingon.Health>0 && Ugluk.Health>0)
            {
                Ugluk.TakeDamage(Fingon.Attack(Ugluk.Armour));
                Fingon.TakeDamage(Ugluk.Attack(Fingon.Armour));
                Console.WriteLine($"Elf.Health = {Fingon.Health}, Orc.Health = {Ugluk.Health}");

            }
        }
    }
}
