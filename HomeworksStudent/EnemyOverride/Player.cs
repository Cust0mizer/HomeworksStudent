namespace HomeworksStudent.EnemyOverride
{
    public class Player
    {
        private Gun _gun;

        public void TakeGun(Gun gun)
        {
            _gun = gun;
        }

        public void Attack(Enemy enemy)
        {
            if (_gun == null)
            {
                InputHelper.PrintColor("У вас нет оружия", ConsoleColor.Red);
                return;
            }
            _gun.Fire(enemy);
        }
    }
}
