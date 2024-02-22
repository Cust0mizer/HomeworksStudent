namespace HomeworksStudent.Inventory
{
    public class Inventory
    {
        List<IItem> items = new List<IItem>();

        public void AddNewItem(IItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
    }
}