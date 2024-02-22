using HomeworksStudent.Inventory;

namespace HomeworksStudent.Inventory
{
    public interface IItem
    {
        public void ShowInfo();
    }
}

public class Apple : IItem
{
    public void ShowInfo()
    {
        throw new NotImplementedException();
    }
}