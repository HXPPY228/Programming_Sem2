using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_6
{
    public sealed class Marine : Unit
    {
        public Marine(string name, bool team): base(name, 45, 7, 0, team)
        {

        }
        public override void UnitAbility(Unit target)
        {
            if (target.Team != Team)
            {
                Console.WriteLine("Нельзя использовать Стим-пак на врагов.");
                return;
            }
            target.Health -= 10;
            target.Damage += 5;
            Console.WriteLine($"{Name} использовал Стим-пак на {target.Name}.");
        }
    }
}
