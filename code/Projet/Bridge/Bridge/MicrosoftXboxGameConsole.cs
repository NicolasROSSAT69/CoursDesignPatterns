namespace Bridge;

public class MicrosoftXboxGameConsole : GameConsole
{
    public void SwitchOn()
    {
        Console.WriteLine("La Xbox s'allume");
    }
    public void SwitchOff()
    {
        Console.WriteLine("La Xbox s'éteint");
    }
    public void SetGame(String nameGame)
    {
        Console.WriteLine("Le jeu choisit est " + nameGame + " sur la Xbox");
    }
}