namespace HomeworksStudent.FirstControl
{
    public interface IComand
    {
        public string Description { get; }
        public void Run();
    }
}