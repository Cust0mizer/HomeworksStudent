using HomeworksStudent.PersonAbstract.StringBuilders;

namespace HomeworksStudent.GameQuest
{
    public class ProgramGame
    {
        public static void Main1(/*string[] args*/)
        {
            IGameTask[] _gameTasks = {
            new Task1_1 (),
            new Task1_2 (),
        };


            while (true)
            {
                if (InputHelper.Input(ActionHelper.GetDescriptionForAction(_gameTasks), 1, 2, out int inputValue))
                {
                    _gameTasks[inputValue - 1].Run();
                }
            }
        }
    }
}