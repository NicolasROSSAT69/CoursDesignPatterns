namespace Singleton;

/**
 * Singleton scanner
 * Un seul scanner peut exister
 */
public class Scanner
{
    
    private static Scanner _instance = null;
    
    private Scanner(){}
    
    public static Scanner getInstance()
    {
        
        if (_instance == null)
        {
            _instance = new Scanner();
        }
        return _instance;
        
    }

    public void scan(String paper)
    {
        
        Console.WriteLine("Votre document est scanné avec succès !");
        Console.WriteLine("Votre document est : ");
        Console.WriteLine(paper);
        Console.WriteLine("Votre document vous a été envoyé par mail ! ");

    }

}