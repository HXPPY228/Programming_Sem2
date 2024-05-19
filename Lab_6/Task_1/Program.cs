namespace _353504_Стецурин_6
{
    internal class Program
    {
        static void Main()
        {
            Marine marine1 = new Marine("Иван", true), marine2 = new Marine("Степан", false);
            Medic medic1 = new Medic("Игорь", true);
            Engineer engineer2 = new Engineer("Богдан", false);

            engineer2.UnitAbility(marine2);
            engineer2.UnitAbility(marine1);
            marine2.Attack(marine1);
            marine1.UnitAbility(marine1);
            medic1.Attack(marine2);
            marine1.Attack(marine2);
            medic1.UnitAbility(marine1);
        }
    }
}
