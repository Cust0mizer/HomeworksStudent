namespace ProductShopAndMenu {
    public interface IMenuItemFactory {
        public List<IButton> GetButtons<T>(Action<T> action) where T :struct, Enum;
    }
}