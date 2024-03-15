using HomeworksStudent.SmartHome;
using System.Text;

namespace HomeworksStudent.DayTaskAndUserAccount
{
    public class DayTaskAndUserAccountStarter : IEntryPoint
    {
        public void Start()
        {
            List<IComandd> listComand = [new InputComand(), new CreateUserComand()];

            while (true)
            {
                if (InputHelper.ChangeInput(GetDescription(listComand), 1, listComand.Count, out int inputValue))
                {
                    listComand[inputValue - 1].Run();
                }
            }
        }

        private StringBuilder GetDescription(List<IComandd> comandds)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (var i = 0; i < comandds.Count; i++)
            {
                stringBuilder.AppendLine($"{i + 1} - {comandds[i].Description}");
            }

            return stringBuilder;
        }
    }
}