namespace HomeworksStudent.FabricMethod.FabricMethodPlayer
{
    public class Base
    {
        private Creator _currentCreator;

        public Base(Creator creator)
        {
            _currentCreator = creator;
        }

        public IUnit CreateNewUnit()
        {
            return _currentCreator.Create();
        }
    }
}