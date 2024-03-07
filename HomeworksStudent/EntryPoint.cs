using System.Text;

public class EntryPoint
{
    public static void Main()
    {
        List<IEntryPoint> list = new List<IEntryPoint>();
        // Загрузка всех сборок в текущем домене приложения
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        StringBuilder stringBuilder = new StringBuilder();

        foreach (var assembly in assemblies)
        {
            // Получение всех типов в сборке
            var types = assembly.GetTypes();

            // Фильтрация типов, реализующих интересующий интерфейс
            List<Type> implementingTypes = types.Where(x => x.GetInterfaces().Contains(typeof(IEntryPoint))).ToList();

            for (int i = 0; i < implementingTypes.Count; i++)
            {
                Type type = implementingTypes[i];
                IEntryPoint instance = (IEntryPoint)Activator.CreateInstance(type);
                stringBuilder.AppendLine($"{i + 1} - {type.Name}");
                list.Add(instance);
            }
        }

        while (true)
        {
            if (InputHelper.Input(stringBuilder, 1, list.Count, out int inputValue))
            {
                list[inputValue - 1].Start();
            }
        }
    }
}