namespace HomeworksStudent.FirstControl
{
    public class ShowInfoTask : IComand
    {
        public string Description => "Показать информацию о задаче";

        public void Run()
        {
            if (TaskManager.Instance.GetListCount() > 0)
            {
                TaskManager.Instance.ShowTaskName();
                if (InputHelper.ChangeInput("", 1, TaskManager.Instance.GetListCount(), out int inputValue))
                {
                    TaskManager.Instance.ShowTaskInfo(inputValue);
                }
            }
        }
    }
}