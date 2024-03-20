namespace HomeworksStudent.FirstControl
{
    public class ProgramScreen
    {
        public void Start()
        {
            IComand[] createAcounts =
            {
                    new AddTask(),
                    new RemoveTask(),
                    new ShowInfoAcount(),
                    new ExitAccountComand(),
                };

            while (TaskManager.Instance.CurrentAccount != null)
            {
                if (InputHelper.ChangeInput(DescriptionHelper.GetDescription(createAcounts), 1, createAcounts.Length, out int inputValue))
                {
                    createAcounts[inputValue - 1].Run();
                }
            }
        }
    }
}