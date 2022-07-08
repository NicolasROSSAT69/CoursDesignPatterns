namespace Decorator;

/**
 * Computer concret
 */
public class LaptopComputer : Computer
{
 
 public void GetType()   
 {   
  Console.WriteLine("Ordinateur Portable :");
 } 
 
 public void GetPower()   
 {   
  Console.WriteLine("La puissance est de 100/200");
 }   
  
 public void GetCost()   
 {   
  Console.WriteLine("Le prix est de 1000 euros");
 }

 public void GetRating()
 {
  Console.WriteLine("La note est de 7/10");
 }
 
}