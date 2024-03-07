using System.Collections;

namespace HomeworksStudent.EnumLesson
{
    public class EnumStarter : IEntryPoint
    {
        public void Start()
        {
            ParceEnumToInt();
        }

        public static void ParceIntToEnum()
        {
            for (int i = 0; i < 100; i++)
            {
                if (Enum.IsDefined(typeof(EnumLessonType), i))
                {
                    Console.WriteLine($"{i} - {(EnumLessonType)i}");
                }
            }
        }

        public static void ParceEnumToInt()
        {
            foreach (var item in GetValues(typeof(ConsoleKey)))
            {
                Console.WriteLine($"{(int)item} - {item}");
            }
        }

        public static void ParceStringToEnum(string enumValue)
        {
            if (Enum.TryParse(enumValue, out DayOfWeek value))
            {
                Console.WriteLine(value.GetType());
            }
            else
            {
                InputHelper.PrintError("Такого нет!");
            }
        }

        public static IList GetValues(Type type)
        {
            return Enum.GetValues(type);
        }
    }

    public enum EnumLessonType
    {
        First = 10,
        Second = 35,
        Third = 86
    }
}