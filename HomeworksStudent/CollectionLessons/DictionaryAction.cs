using HomeworksStudent.PersonAbstract.StringBuilders;

namespace HomeworksStudent.CollectionLessons
{
    public class DictionaryAction : IAction
    {
        public string Description => "Словарь";

        public void Run()
        {
            Dictionary<DayOfWeek, int> keyValuePairs = new();
            Random random = new Random();

            foreach (DayOfWeek item in Enum.GetValues(typeof(DayOfWeek)))
            {
                if (!keyValuePairs.TryAdd(item, 123))
                {
                    InputHelper.PrintError("ОШИБКА!!!");
                }
            }

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                Console.WriteLine();
            }
        }
    }
}
