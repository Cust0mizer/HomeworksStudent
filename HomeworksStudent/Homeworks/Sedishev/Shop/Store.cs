//namespace HomeworksStudent.Homeworks.Sedishev.Shop
//{
//    public class Store
//    {
//        private List<Product> products = new List<Product>();
//        public void AddProduct(Product product)
//        {
//            products.Add(product);
//            Console.WriteLine(product.Name + "добавили в магаз");
//        }
//        public bool Available(ProductName productName)
//        {
//            return products.Exists(p => p.Name == productName);
//        }
//        public void ShowAllProducts()
//        {
//            Console.WriteLine("в магазине остались продукты:");
//            foreach (var product in products)
//            {
//                Console.WriteLine(product.Name + "цена" + product.Price);
//            }
//        }
//        public void BuyProduct(ProductName productName, PaymentMethod paymentMethod)
//        {

//            {
//                Console.WriteLine(product.Name "есть в наличии" + product.Price);
//                paymentMethod.DeleteMoney(product.Price);
//            }
//        else
//            {
//                Console.WriteLine(productName + "нет в наличии");
//            }
//        }
//    }
//}
