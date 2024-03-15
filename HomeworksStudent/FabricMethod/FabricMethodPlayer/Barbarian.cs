namespace HomeworksStudent.FabricMethod.FabricMethodPlayer
{
    public class Barbarian : IUnit
    {
        public int Damage => 10;

        public int Healht => 30;

        public void Attack(Player player)
        {
            player.TakeDamage(Damage);
            Console.WriteLine("Варвар атакует мечём!");
        }
    }
}




