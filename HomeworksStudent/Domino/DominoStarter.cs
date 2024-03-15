namespace HomeworksStudent.Domino
{
    public class DominoStarter : IEntryPoint
    {
        public void Start()
        {
            DominoManager dominoManager = new DominoManager();
            dominoManager.CreateDomino();

            while (true)
            {
                if (InputHelper.ChangeInput("1 - Взять домино", 1, 1, out int inputValue))
                {
                    dominoManager.TakeDomino();
                }
            }
        }
    }
}