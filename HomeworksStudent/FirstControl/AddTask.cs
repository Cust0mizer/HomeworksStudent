namespace HomeworksStudent.FirstControl
{
    public class AddTask : IComand
    {
        public string Description => "Добавить новую задачу";

        public void Run()
        {
            Console.WriteLine("Введить имя задачи");
            string taskName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(taskName))
            {
                Console.WriteLine("Введить описание задачи");
                string taskDescriprion = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(taskDescriprion))
                {
                    TaskManager.Instance.AddTask(new Task(taskName, taskDescriprion));
                }
            }
        }
    }
}