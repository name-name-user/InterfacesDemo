using System;
namespace InterfacesDemo
{
    public class Orc : Monster, IAttacker
    {
        public Orc(string name, int level) : base(name, level)
        {
            this.Health = level * 1.5;
            this.Armour = 5;
        }

        public double Attack(int armour)
        {
            return 10.0;
        }

        public void TakeDamage(double soa)
        {
            double modDamage = soa - this.Armour;
            this.Health = this.Health - modDamage;
        }
    }
}
