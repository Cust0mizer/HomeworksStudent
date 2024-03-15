namespace HomeworksStudent.FabricMethod.FabricMethod2
{
    public class AbonimetnCreator_3 : IAbonimetnCreator
    {
        public Aboniment CreateAbonimetn(float value)
        {
            return new Aboniment_3(value);
        }
    }
}
