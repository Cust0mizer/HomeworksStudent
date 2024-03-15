namespace HomeworksStudent.FabricMethod.FabricMethod2
{
    public class Aboniment_1 : Aboniment
    {
        public override string Description => "Идеальный вариант для начала!";

        public override string Name => "Только зал";

        public Aboniment_1(float price) : base(price)
        { }
    }
}
