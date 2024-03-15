namespace HomeworksStudent.FabricMethod.FabricMethodPlayer
{
    public class Player
    {
        private int _health = 100;

        public void TakeDamage(int damageValue)
        {
            _health -= damageValue;
            Console.WriteLine($"О нет, я получил урон! {damageValue} и теперь у меня {_health}");
        }
    }
}