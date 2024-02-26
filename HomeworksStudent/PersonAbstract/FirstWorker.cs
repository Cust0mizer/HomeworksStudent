namespace HomeworksStudent.PersonAbstract
{
    public class FirstWorker : ICanWork
    {
        public void Work()
        {
            Console.WriteLine("Я первый работник и я работаю");
        }

        public void SuperWork()
        {
            Console.WriteLine("Делаю очень сложное действие!");
        }
    }
}