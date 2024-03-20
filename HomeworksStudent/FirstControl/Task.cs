namespace HomeworksStudent.FirstControl
{
    public class Task
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime DateTime { get; private set; }

        public Task(string name, string description)
        {
            Description = description;
            DateTime = DateTime.Now;
            Name = name;
        }

        public void ShowTaskInfo()
        {
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Description {Description}");
            Console.WriteLine($"DateTime {DateTime}");
        }
    }
}