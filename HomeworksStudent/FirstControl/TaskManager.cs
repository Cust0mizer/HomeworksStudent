namespace HomeworksStudent.FirstControl
{
    public class TaskManager
    {
        #region Singletone
        public readonly static TaskManager Instance;

        static TaskManager()
        {
            Instance = new TaskManager();
        }
        private TaskManager() { }
        #endregion

        public Account CurrentAccount { get; private set; }

        public void SetAccount(Account account)
        {
            CurrentAccount = account;
        }

        public void AddTask(Task task)
        {
            CurrentAccount.AddTask(task);
        }

        public void RemoveTask(int index)
        {
            CurrentAccount.RemoveTask(index);
        }

        public void ShowTaskInfo(int index)
        {
            CurrentAccount.ShowInfoTask(index);
        }

        public void ShowTaskName()
        {
            CurrentAccount.ShowTaskName();
        }

        public int GetListCount()
        {
            return CurrentAccount.GetCount();
        }
    }
}