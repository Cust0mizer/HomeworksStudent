namespace HomeworksStudent.FabricMethod.FabricMethod2
{
    public class AbonimetnCreator_2 : IAbonimetnCreator
    {
        public Aboniment CreateAbonimetn(float value)
        {
            return new Aboniment_2(value);
        }
    }
}
