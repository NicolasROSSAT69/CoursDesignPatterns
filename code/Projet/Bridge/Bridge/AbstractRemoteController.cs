namespace Bridge;

public abstract class AbstractRemoteController
{
    protected GameConsole gameConsole;
    protected AbstractRemoteController(GameConsole gameConsole)
    {
        this.gameConsole = gameConsole;
    }
    public abstract void SwitchOn();
    public abstract void SwitchOff();
    public abstract void SetGame(String nameGame);
}