using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_6
{
    public abstract class Unit
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;
        private bool _teammate;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public bool Team
        {
            get { return _teammate; }
            set { _teammate = value; }
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public int Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }
        public Unit(string name, int hp, int dmg, int armor, bool team) 
        { 
            Name = name;
            Health = hp;
            Damage = dmg;
            Armor = armor;
            Team = team;
        }
        public virtual void Attack(Unit enemy)
        {
            int dmg = Damage - enemy.Armor;
            if (dmg < 0) 
            { 
                dmg = 0;
            }
            enemy.Health -= dmg;
            Console.WriteLine($"{Name} атаковал {enemy.Name} ({enemy.Armor} брони) и нанёс {dmg} урона. Здоровье после атаки - {enemy.Health}.");
        }
        public abstract void UnitAbility(Unit target);
    }
}
