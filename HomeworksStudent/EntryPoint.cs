using System.Text;

public class EntryPoint
{
    public static void Main()
    {
        List<IEntryPoint> list = new List<IEntryPoint>();
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        StringBuilder stringBuilder = new StringBuilder();

        foreach (var assembly in assemblies)
        {
            var types = assembly.GetTypes();
            List<Type> implementingTypes = new List<Type>();

            foreach (var type in types)
            {
                if (type.GetInterfaces().Contains(typeof(IEntryPoint)))
                {
                    implementingTypes.Add(type);
                }
            }

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
            if (InputHelper.ChangeInput(stringBuilder, 1, list.Count, out int inputValue))
            {
                list[inputValue - 1].Start();
            }
        }
    }
}
