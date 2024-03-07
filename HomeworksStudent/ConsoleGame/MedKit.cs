namespace HomeworksStudent.ConsoleGame
{
    public class MedKit(int health) : IHealing
    {
        public int HealthValue => _health;

        public bool ICanStack => true;

        private int _health = health;
    }
}
