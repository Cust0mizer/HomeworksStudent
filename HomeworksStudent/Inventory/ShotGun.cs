namespace HomeworksStudent.ConsoleGame
{
    public class ShotGun(int damage) : IGun
    {
        private int _damage = damage;

        public bool ICanStack => false;

        public void Fire(IDamageble damageble)
        {
            damageble.TryDie(_damage);
        }
    }
}
