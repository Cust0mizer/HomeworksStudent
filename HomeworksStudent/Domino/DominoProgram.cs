namespace HomeworksStudent.Domino
{
    public class DominoProgram
    {
        public static void Main1(string[] args)
        {
            DominoManager dominoManager = new DominoManager();
            dominoManager.CreateDomino();
            while (true)
            {
                if (InputHelper.Input("1 - Взять домино", 1, 1, out int inputValue))
                {
                    dominoManager.TakeDomino();
                }
            }
        }
    }
}