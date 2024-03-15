namespace HomeworksStudent.ConsoleGame
{
    public class Armor : IIetem
    {
        public HealthComponent HealthComponent { get; }

        public bool ICanStack => false;

        public Armor(int startDefence)
        {
            HealthComponent = new HealthComponent(startDefence);
        }
    }
}
