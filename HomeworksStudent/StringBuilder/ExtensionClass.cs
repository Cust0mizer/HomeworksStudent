using HomeworksStudent.InstallComand;
using System.Collections;
using System.Numerics;
using System.Text;

public static class ExtensionClass
{
    public static void NewLine(this StringBuilder stringBuilder, string text)
    {
        stringBuilder.Append($"\n{text}");
    }

    public static void GetDescriptionForEnum<T>(this StringBuilder stringBuilder, string startText) where T : Enum
    {
        IList list = Enum.GetValues(typeof(T));
        stringBuilder.AppendLine(startText);

        for (var i = 0; i < list.Count; i++)
        {
            stringBuilder.AppendLine($"{i + 1} - {list[i]}");
        }
    }

    public static void GetDescriptionForNames<T>(this StringBuilder stringBuilder, List<T> list) where T : IContainsName
    {
        for (var i = 0; i < list.Count; i++)
        {
            stringBuilder.AppendLine($"{i + 1} - {list[i].Name}");
        }
    }

    //public static void AddOrPlus<T1, T2>(this Dictionary<T1, T2> keyValuePairs, T1 key, T2 value)
    //{
    //    if (!keyValuePairs.TryAdd(key, value))
    //    {
    //        keyValuePairs[key] += value;
    //    }
    //}

    public static long ToMb(this long value)
    {
        return value / 1000000;
    }

    public static long ToGb(this long value)
    {
        return value / 1000000000;
    }

    public static long ToTB(this long value)
    {
        return value / 1000000000000;
    }

    public static void PrintXY(this char[,] array)
    {
        for (int width = 0; width < array.GetLength(1); width++)
        {
            for (int height = 0; height < array.GetLength(0); height++)
            {
                Console.Write(array[height, width]);
            }

            Console.Write("\n");
        }
    }
}

public interface IContainsName
{
    public string Name { get; }
}

//Написать метод расширения для 
//DateTime, который выводи
//Разницу между текущей датой
//И той, у которой мы вызвали метод

//Создать приложение "Распорядок дня"
//МОжно добавить задачу
//Удалить задачу
//Получить информацию о всех задачах
//При выводе, выводить время добавления задачи