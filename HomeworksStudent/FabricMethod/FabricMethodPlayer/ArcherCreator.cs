namespace HomeworksStudent.FabricMethod.FabricMethodPlayer
{
    public class ArcherCreator : Creator
    {
        public override IUnit Create()
        {
            return new Archer();
        }
    }
}




