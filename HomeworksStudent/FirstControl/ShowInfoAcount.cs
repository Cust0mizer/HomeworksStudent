namespace HomeworksStudent.FirstControl
{
    public class ShowInfoAcount : IComand
    {
        public string Description => "Показать информацию о аккаунтах";

        public void Run()
        {
            AccountManager.Instance.ShowAccountInfo();
        }
    }
}