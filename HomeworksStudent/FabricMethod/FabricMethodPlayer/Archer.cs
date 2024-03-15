namespace HomeworksStudent.FabricMethod.FabricMethodPlayer
{
    public class Archer : IUnit
    {
        public int Damage => 20;

        public int Healht => 10;

        public void Attack(Player player)
        {
            player.TakeDamage(Damage);
            Console.WriteLine("Стрелы пиу пиу!");
        }
    }
}




