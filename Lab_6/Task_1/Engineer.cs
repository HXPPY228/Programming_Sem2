using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_6
{
    public sealed class Engineer : Unit
    {
        public Engineer(string name, bool team) : base(name, 60, 4, 1, team)
        {

        }
        public override void UnitAbility(Unit target)
        {
            if (target.Team != Team)
            {
                Console.WriteLine("Нельзя улучшать броню и вооружение врагам.");
                return;
            }
            target.Damage += 5;
            target.Armor += 5;
            Console.WriteLine($"{Name} улучшил броню и вооружение {target.Name}.");
        }
    }
}
