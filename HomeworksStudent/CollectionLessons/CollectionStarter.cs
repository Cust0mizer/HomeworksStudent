using HomeworksStudent.PersonAbstract.StringBuilders;

namespace HomeworksStudent.CollectionLessons
{
    public class CollectionStarter : IEntryPoint
    {
        public void Start()
        {
            IAction[] list = {
                new DictionaryAction(),
                new HashSetAction()
            };
            list[1].Run();
        }
    }
}