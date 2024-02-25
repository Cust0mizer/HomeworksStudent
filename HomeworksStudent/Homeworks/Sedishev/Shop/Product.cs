namespace HomeworksStudent.Homeworks.Sedishev.Shop
{
    public class Product
    {
        public ProductName Name { get; set; }
        public decimal Price { get; set; }
    }
    public enum ProductName
    {
        Apple,
        Banana,
        Orange,
        Grape,
        Pineapple
    }
}
