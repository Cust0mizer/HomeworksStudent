namespace HomeworksStudent.FirstControl
{
    public class ExitAccountComand : IComand
    {
        public string Description => "Выйти из аккаунта";

        public void Run()
        {
            TaskManager.Instance.SetAccount(null);
        }
    }
}