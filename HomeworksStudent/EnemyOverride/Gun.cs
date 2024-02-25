namespace HomeworksStudent.EnemyOverride
{
    public class Gun
    {
        private float _caliber;
        protected float Damage { get; private set; }

        public Gun(float caliber, float damage)
        {
            _caliber = caliber;
            Damage = damage;
        }

        public virtual void Fire(Enemy enemy)
        {
            enemy.TakeDamage(Damage);
        }
    }
}
