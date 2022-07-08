namespace Decorator;

/**
 * decorator concret
 */
public class HybridLaptop : ComputerDecorator
{

 public HybridLaptop(Computer computer) : base(computer)
 {

 }
 
 public override void GetType()   
 {
  Console.WriteLine("Ordinateur Hybride");
 }

 public override void GetCost()   
 {
  Console.WriteLine("Le prix est de 1200 euros");
 }
 
 public override void GetRating()   
 { 
  base.GetRating();
  Console.WriteLine("La note est de 10/10 en utilisation tablette");
 }

}