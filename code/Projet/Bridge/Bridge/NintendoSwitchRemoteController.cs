namespace Bridge;

public class NintendoSwitchRemoteController : AbstractRemoteController
{
    public NintendoSwitchRemoteController(GameConsole gameConsole) : base(gameConsole)
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