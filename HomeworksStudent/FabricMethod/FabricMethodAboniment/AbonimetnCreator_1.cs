namespace HomeworksStudent.FabricMethod.FabricMethod2
{
    public class AbonimetnCreator_1 : IAbonimetnCreator
    {
        public Aboniment CreateAbonimetn(float value)
        {
            return new Aboniment_1(value);
        }
    }
}
