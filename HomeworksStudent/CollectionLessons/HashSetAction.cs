using HomeworksStudent.PersonAbstract.StringBuilders;
using System.Text;

namespace HomeworksStudent.CollectionLessons
{
    public class HashSetAction : IAction
    {
        public string Description => "Хеш сет";

        public void Run()
        {
            HashSet<int> ints = new HashSet<int>();
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }
    }
}
