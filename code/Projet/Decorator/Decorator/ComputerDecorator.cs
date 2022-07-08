namespace Decorator;

/**
 * Decorator abstrait
 */
public abstract class ComputerDecorator : Computer
{

    private Computer computer;

    protected ComputerDecorator(Computer computer)
    {
        this.computer = computer;
    }
    
    public virtual void GetType()   
    {   
        this.computer.GetType();
    } 
    
    public virtual void GetPower()   
    {   
        this.computer.GetPower();   
    }
    
    public virtual void GetCost()   
    {   
        this.computer.GetCost();   
    }
    
    public virtual void GetRating()   
    {   
        this.computer.GetRating();   
    }
    
}