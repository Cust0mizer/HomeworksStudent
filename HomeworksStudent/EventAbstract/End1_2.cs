namespace HomeworksStudent.EventAbstract
{
    public class End1_2 : Event
    {
        public override void Run()
        {
            InputHelper.PrintColor("Вы прошли мимо, но вскоре вас догнал ковёр - самолёт и подарил вам лампу джина, ура!", ConsoleColor.Green);
        }
    }
}