namespace Bridge;

public class NintendoSwitchGameConsole : GameConsole
{
    public void SwitchOn()
    {
        Console.WriteLine("La Nintendo Switch s'allume");
    }
    public void SwitchOff()
    {
        Console.WriteLine("La Nintendo Switch s'éteint");
    }
    public void SetGame(String nameGame)
    {
        Console.WriteLine("Le jeu choisit est " + nameGame + " sur la Switch");
    }
}