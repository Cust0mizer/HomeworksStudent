using HomeworksStudent.Homeworks.Sedishev.Shop;
using HomeworksStudent.PersonAbstract.StringBuilders;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace HomeworksStudent.PersonAbstract.StringBuilders
{
    public partial class StringBuilderProgram
    {
        public const bool IS_CHANGE_APPEND_ENABLE = true;

        public static void Main(string[] args)
        {
            //IAction[] actions = {
            //new InputAction(),
            //    new OutputAction(),
            //    new ClearTextAction(),
            //    new ReplaceAction(),
            //    new ClearConsoleAction(),
            //};

            //while (true)
            //{
            //    if (InputHelper.Input(ActionHelper.GetDescriptionForAction(actions), 1, actions.Length, out int inputUserValue))
            //    {
            //        actions[inputUserValue - 1].Run();
            //    }
            //}
            byte value = 123;
            Sum(1f, value);
        }

        public static T Sum<T>(T value1, T value2) where T : INumber<T>
        {
            return value1 + value2;
        }
    }

    public enum LineMode
    {
        Line = 1,
        NewLine
    }
}














namespace GameTest
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

    public interface IDescription
    {
        public string Description { get; }
    }

    public interface IGameTask
    {
        public void Run();
    }

    public class Task1_1 : IGameTask, IDescription
    {
        public string Description => "Лев";
        List<IGameTask> _gameTasks = new List<IGameTask>();

        public Task1_1()
        {
            _gameTasks.Add(new Task1_1_1());
            _gameTasks.Add(new Task1_1_2());
        }

        public void Run()
        {

        }
    }

    public class Task1_2 : IGameTask, IDescription
    {
        public string Description => "Прав";

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class Task1_1_1 : IGameTask, IDescription
    {
        public string Description => "Прав два";

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class Task1_1_2 : IGameTask, IDescription
    {
        public string Description => "Лев два";

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}