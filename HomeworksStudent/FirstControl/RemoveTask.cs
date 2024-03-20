namespace HomeworksStudent.FirstControl
{
    public class RemoveTask : IComand
    {
        public string Description => "Удалить задачу";

        public void Run()
        {
            if (TaskManager.Instance.GetListCount() > 0)
            {
                TaskManager.Instance.ShowTaskName();
                if (InputHelper.ChangeInput("", 1, TaskManager.Instance.GetListCount(), out int inputValue))
                {
                    TaskManager.Instance.RemoveTask(inputValue - 1);
                }
            }
        }
    }
}