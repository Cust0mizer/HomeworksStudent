namespace HomeworksStudent.FabricMethod.FabricMethodPlayer
{
    public class BarbarianCreator : Creator
    {
        public override IUnit Create()
        {
            return new Barbarian();
        }
    }
}




