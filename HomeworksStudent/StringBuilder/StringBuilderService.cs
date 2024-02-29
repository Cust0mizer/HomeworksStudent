using System.Text;

namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class StringBuilderService
    {
        private StringBuilder _stringBuilder = new StringBuilder();
        public readonly static StringBuilderService Instance;

        static StringBuilderService()
        {
            Instance = new StringBuilderService();
        }













        public void AddNewText(string text, LineMode lineMode)
        {
            switch (lineMode)
            {
                case LineMode.Line:
                _stringBuilder.Append(text);
                break;
                case LineMode.NewLine:
                _stringBuilder.Append($"\n{text}");
                break;
            }
        }

        public void ReplaceText(string firstText, string secondText)
        {
            _stringBuilder.Replace(firstText, secondText);
        }

        public void PrintAll()
        {
            InputHelper.PrintGoodMessage(_stringBuilder.ToString());
        }

        public void Clear()
        {
            _stringBuilder.Clear();
        }

        public bool ContainsInfo()
        {
            return _stringBuilder.Length > 0;
        }
    }
}