namespace HomeworksStudent.ConsoleGame
{
    public class Enemy : IDamageble
    {
        private HealthComponent _healthComponent;

        public Enemy(EnemyStats enemyStats)
        {
            _healthComponent = new HealthComponent(enemyStats.Health);
        }

        public bool TryDie(int damage)
        {
            if (_healthComponent.TryDie(damage))
            {
                return true;
            }
            Console.WriteLine($"Получил урон {damage}");
            return false;
        }
    }
}
