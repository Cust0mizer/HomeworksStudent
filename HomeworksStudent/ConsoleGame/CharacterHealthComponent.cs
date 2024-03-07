namespace HomeworksStudent.ConsoleGame
{
    public class CharacterHealthComponent : HealthComponent
    {
        public CharacterHealthComponent(int health) : base(health)
        {
        }

        public void Regenerate(int value)
        {
            Health += Math.Abs(value);
        }
    }
}
