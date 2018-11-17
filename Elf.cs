using System;
namespace InterfacesDemo
{
    public class Elf : Monster, IAttacker
    {
        public Elf(string name, int level) : base(name, level)
        {
            this.Health = level * 0.8;
            this.Armour = 3;
        }

        public double Attack(int armour)
        {
            return 10.5;
        }

        public void TakeDamage(double soa)
        {
            double modDamage = soa - this.Armour;
            this.Health = this.Health - modDamage;
        }
    }
}
