namespace Bridge;

public class MicrosoftXboxRemoteController : AbstractRemoteController
{
    public MicrosoftXboxRemoteController(GameConsole gameConsole) : base(gameConsole)
    {
    }
    public override void SwitchOn()
    {
        gameConsole.SwitchOn();
    }
    public override void SwitchOff()
    {
        gameConsole.SwitchOff();
    }
    public override void SetGame(String nameGame)
    {
        gameConsole.SetGame(nameGame);
    }
}