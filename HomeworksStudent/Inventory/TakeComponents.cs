namespace HomeworksStudent.Inventory
{
    public class TakeComponents : PlayerComponent
    {
        private Inventory _inventory;

        public TakeComponents()
        {
            _inventory = new Inventory();
        }

        public void Take(IItem item)
        {
            _inventory.AddNewItem(item);
        }
    }
}