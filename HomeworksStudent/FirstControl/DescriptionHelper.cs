using System.Text;

namespace HomeworksStudent.FirstControl
{
    public static class DescriptionHelper
    {
        public static StringBuilder GetDescription(IComand[] comands)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Выберите действие!");

            for (int i = 0; i < comands.Length; i++)
            {
                stringBuilder.AppendLine($"{i + 1} - {comands[i].Description}");
            }
            return stringBuilder;
        }
    }
}