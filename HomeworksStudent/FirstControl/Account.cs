namespace HomeworksStudent.FirstControl
{
    public class Account
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        private List<Task> _tasks = new List<Task>();

        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public void PrintInfo()
        {
            Console.Write($"Login - {Login}\tPassword - {Password}");
        }

        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }

        public void RemoveTask(int index)
        {
            _tasks.RemoveAt(index);
        }

        public void ShowInfoTask(int index)
        {
            _tasks[index].ShowTaskInfo();
        }

        public void ShowTaskName()
        {
            for (int i = 0; i < _tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {_tasks[i].Name}");
            }
        }

        public int GetCount()
        {
            return _tasks.Count;
        }
    }
}