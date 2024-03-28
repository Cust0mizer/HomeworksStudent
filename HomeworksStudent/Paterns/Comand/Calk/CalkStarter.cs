using System.Runtime.InteropServices;
using System.Text;

namespace HomeworksStudent.Paterns.Comand.Calk {
    public class CalkStarter : IEntryPoint {
        public void Start() {
            Action[] actions = CreateAndGetActions();

            while (true) {
                if (InputHelper.ChangeInput(GetDescriptinoForActions(actions), min: 1, max: actions.Length, out var inputValue)) {
                    actions[inputValue - 1].Run();
                }
            }
        }

        private static string GetDescriptinoForActions(Action[] actions) {
            StringBuilder stringBuilder = new StringBuilder();

            for (var i = 0; i < actions.Length; i++) {
                stringBuilder.AppendLine($"{i + 1} - {actions[i].Description}");
            }
            return stringBuilder.ToString();
        }

        private static Action[] CreateAndGetActions() {
            Action[] actions = {
                new ActionSum(),
                new ActionMinus(),
                new ActionDivide(),
                new ActionMultiply(),
                new CosAction(),
                new SinAction(),
                new ActionLogO(),
                new ActionConsoleClear(),
            };
            return actions;
        }
    }

    public class VectorSum : Action {
        public override string Description => "Сложение векторов";

        public override void Run() {
            if (InputHelper.FloatInputField("Введите последовательно, через пробел первый вектор, к примеру 12 32", out float inputValue)) {

            }
        }
    }

    public struct Vector2 {
        private readonly float _x;
        private readonly float _y;

        public Vector2(float x, float y) {
            _x = x;
            _y = y;
        }

        public override string ToString() {
            return $"{_x} {_y}";
        }
    }
}

