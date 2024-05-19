using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_6
{
    public sealed class Medic : Unit
    {
        public Medic(string name, bool team) : base(name, 60, 0, 1, team)
        {

        }
        public override void Attack(Unit enemy)
        {
            Console.WriteLine("Медик не может атаковать.");
        }
        public override void UnitAbility(Unit target)
        {
            if (target.Team != Team)
            {
                Console.WriteLine("Нельзя лечить врагов.");
                return;
            }
            target.Health += 20;
            Console.WriteLine($"{Name} вылечил {target.Name}. Здоровье после лечения – {target.Health}.");
        }
    }
}
