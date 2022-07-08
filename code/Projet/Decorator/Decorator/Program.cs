using Decorator;

/**
 * Ce projet est un exemple de design pattern Decorator
 * Le but de ce programme est de donner le prix, la note et la puissance des
 * différents ordinateurs (pc portable, pc fixe et pc hybride tablette/pc).
 * Pour le pc hybride la note est différente des autres car il y a la note d'utilisation pc,
 * la note d'utilisation tablette et le nom qui change ce n'est plus un pc portable mais
 * un pc hybride.
 */
public class Program
{

    static void Main(string[] args)
    {

        Computer laptop = new LaptopComputer();
        laptop.GetType();
        laptop.GetCost();
        laptop.GetPower();
        laptop.GetRating();

        Computer deskComputer = new DeskComputer();
        deskComputer.GetType();
        deskComputer.GetCost();
        deskComputer.GetPower();
        deskComputer.GetRating();

        Computer hybridComputer = new LaptopComputer();
        ComputerDecorator computerDecorator = new HybridLaptop(hybridComputer);
        computerDecorator.GetType();
        computerDecorator.GetCost();
        computerDecorator.GetPower();
        computerDecorator.GetRating();

    }

}