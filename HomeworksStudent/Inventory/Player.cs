namespace HomeworksStudent.Inventory
{
    public class Player
    {
        public TakeComponents TakeComponent { get; private set; }

        public Player(TakeComponents takeComponents)
        {
            TakeComponent = takeComponents;
        }

        public void TakeItem(IItem item)
        {
            TakeComponent.Take(item);
        }
    }
}