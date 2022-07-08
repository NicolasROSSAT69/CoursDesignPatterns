namespace Decorator;

/**
 * Computer concret
 */
public class DeskComputer : Computer
{
    
    public void GetType()   
    {   
        Console.WriteLine("Ordinateur de bureau :");
    } 
    
    public void GetPower()   
    {   
        Console.WriteLine("La puissance est de 180/200");
    }   
  
    public void GetCost()   
    {   
        Console.WriteLine("Le prix est de 900 euros");
    }

    public void GetRating()
    {
        Console.WriteLine("La note est de 10/10");
    }
    
}