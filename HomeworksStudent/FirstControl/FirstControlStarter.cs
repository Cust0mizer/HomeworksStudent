namespace HomeworksStudent.FirstControl
{
    public class FirstControlStarter : IEntryPoint
    {
        public void Start()
        {
            //Main
            IComand[] createAcounts =
            {
                new CreateAcount(),
                new ShowInfoAcount(),
                new LoginAcount()
            };

            while (true)
            {
                if (InputHelper.ChangeInput(DescriptionHelper.GetDescription(createAcounts), 1, createAcounts.Length, out int inputValue))
                {
                    createAcounts[inputValue - 1].Run();
                }
            }
        }
    }
}