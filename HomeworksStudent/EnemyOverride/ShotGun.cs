namespace HomeworksStudent.EnemyOverride
{
    public class ShotGun : Gun
    {
        private int _fractionCount;

        public ShotGun(float caliber, float damage, int fractionCount) : base(caliber, damage)
        {
            _fractionCount = fractionCount;
        }

        public override void Fire(Enemy enemy)
        {
            enemy.TakeDamage(Damage * _fractionCount);
            base.Fire(enemy);
        }
    }
}