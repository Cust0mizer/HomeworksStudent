namespace HomeworksStudent.ConsoleGame
{
    public class HealthComponent : IDamageble
    {
        public int Health { get; protected set; }

        public HealthComponent(int health)
        {
            Health = health;
        }

        public bool TryDie(int damage)
        {
            if (damage >= Health)
            {
                Die();
                return true;
            }
            else
            {
                Health -= Math.Abs(damage);
                return false;
            }
        }

        private void Die()
        {
            InputHelper.PrintWarning("Die");
        }

        public void ShowHealthInfo()
        {
            InputHelper.PrintWarning($"Текущее состояние {GetType()} = {Health}");
        }
    }
}
