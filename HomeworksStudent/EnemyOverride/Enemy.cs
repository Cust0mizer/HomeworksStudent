namespace HomeworksStudent.EnemyOverride
{
    public class Enemy
    {
        private float _health;

        public Enemy(float health)
        {
            _health = health;
        }

        public void TakeDamage(float damage)
        {
            if (damage < 0)
            {
                return;
            }
            if (damage > _health)
            {
                _health = 0;
                Die();
            }
            else
            {
                _health -= damage;
                InputHelper.PrintColor($"Вы нанесли урон {damage}, у противника осталось {_health} здоровья", ConsoleColor.Green);
            }
        }

        private void Die()
        {
            InputHelper.PrintColor("Противник умер", ConsoleColor.Red);
        }
    }
}
