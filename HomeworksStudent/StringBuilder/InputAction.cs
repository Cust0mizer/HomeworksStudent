using System.Collections;
using System.Text;

namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public class InputAction : IAction, IDescription
    {
        public string Description => "Ввод текста";
        private StringBuilderService _inputManager = StringBuilderService.Instance;

        public void Run()
        {
            Console.WriteLine("Введите ваш текст");
            string appendText = Console.ReadLine();

            if (string.IsNullOrEmpty(appendText))
            {
                InputHelper.PrintError("Вы ввели пустой текст!");
                return;
            }
            ChangeApend(appendText);
        }

        private void ChangeApend(string appendText)
        {
            IList list = Enum.GetValues(typeof(LineMode));

            while (true)
            {
                if (EntryStringBuilder.IS_CHANGE_APPEND_ENABLE)
                {
                    if (InputHelper.ChangeInput(GetLineModeDescription(), (int)list[0], (int)list[list.Count - 1], out int inputValue))
                    {
                        _inputManager.AddNewText(appendText, (LineMode)inputValue);
                        break;
                    }
                    else
                    {
                        InputHelper.PrintError("Шото не то");
                    }
                }
                else
                {
                    _inputManager.AddNewText(appendText, LineMode.Line);
                    break;
                }
            }
        }

        private StringBuilder GetLineModeDescription()
        {
            IList list = Enum.GetValues(typeof(LineMode));
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Режим добавления\n");

            for (int i = 0; i < list.Count; i++)
            {
                stringBuilder.Append($"{i + 1} - {list[i]}\n");
            }
            return stringBuilder;
        }
    }
}