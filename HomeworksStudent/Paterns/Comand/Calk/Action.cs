namespace HomeworksStudent.Paterns.Comand.Calk
{
    public abstract class Action
    {
        public abstract string Description { get; }
        public abstract void Run();
    }
}