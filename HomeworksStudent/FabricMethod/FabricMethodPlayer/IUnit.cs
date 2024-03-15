namespace HomeworksStudent.FabricMethod.FabricMethodPlayer
{
    public interface IUnit
    {
        public int Damage { get; }
        public int Healht { get; }

        public void Attack(Player player);
    }
}