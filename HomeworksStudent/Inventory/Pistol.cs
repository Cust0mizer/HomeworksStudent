namespace HomeworksStudent.ConsoleGame
{
    public class Pistol(int damage) : IGun
    {
        private int _damage = damage;

        public bool ICanStack => false;

        public void Fire(IDamageble damageble)
        {
            damageble.TryDie(_damage);
        }
    }
}
