namespace HomeworksStudent.Homeworks.Sedishev.Shop
{
    public class PaymentMethod
    {
        public decimal Money { get; set; }
        public void DeleteMoney(decimal amount)
        {
            if (amount <= Money)
            {
                Money -= amount;
                Console.WriteLine(amount + "минус" + "остаток" + Money);
            }
            else
            {
                Console.WriteLine("нету денег");
            }
        }
    }
}
