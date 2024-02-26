namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public interface IAction
    {
        public string Description { get; }
        public void Run();
    }
}