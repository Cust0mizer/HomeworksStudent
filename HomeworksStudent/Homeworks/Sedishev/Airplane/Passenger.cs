namespace HomeworksStudent.Homeworks.Sedishev.Airplane
{
    public class Passenger
    {
        public SettClass SettClass { get; private set; }
        public string Name { get; private set; }
        public int SettNumber { get; private set; }
        public Passenger(SettClass settClass, string name, int settNumber)
        {
            SettClass = settClass;
            Name = name;
            SettNumber = settNumber;
        }
    }
    public enum SettClass
    {
        Economy,
        Business,
        VIP
    }
}
