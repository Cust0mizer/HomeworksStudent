namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class OutputAction : IAction
    {
        public string Description => "Вывод текста";

        public void Run()
        {
            InputManager.Instance.Print();
        }
    }
}