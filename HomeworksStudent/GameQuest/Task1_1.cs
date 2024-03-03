namespace HomeworksStudent.GameQuest
{
    public class Task1_1 : IGameTask, IDescription
    {
        List<IGameTask> _gameTasks = new List<IGameTask>();
        public string Description => "Лев";

        public Task1_1()
        {
            _gameTasks.Add(new Task1_1_1());
            _gameTasks.Add(new Task1_1_2());
        }

        public void Run()
        {

        }
    }
}