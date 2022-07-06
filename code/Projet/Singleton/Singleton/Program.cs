using Singleton;

/**
 * Ce projet est un exemple de design pattern Singleton
 * Le but de l'application est de gérer des utilisateurs
 * et un seul scanner.
 * Comme si une entreprise ne disposait que d'un seul scanner pour tous ces employés.
 */
public class Program
{
 static void Main(string[] args)
 {
  
  Console.WriteLine("Pour utiliser le scanner il faut renseigner vos information !");
  Console.WriteLine("Nom : ");
  string lastName = Console.ReadLine();
  Console.WriteLine("Prénom : ");
  string name = Console.ReadLine();
  Console.WriteLine("Email pour envoi du scan : ");
  string email = Console.ReadLine();
  Console.WriteLine("Inserer votre document (taper une phrase pour exemple): ");
  string paper = Console.ReadLine();

  Employee user = new Employee(name, lastName, email, paper);
  
  Console.WriteLine("/////////////////////////////////////////////////////////////////////");
  user.scanPaper();
  Console.WriteLine("/////////////////////////////////////////////////////////////////////");
  
  Console.WriteLine("Pour utiliser le scanner il faut renseigner vos informations !");
  Console.WriteLine("Nom : ");
  string lastName2 = Console.ReadLine();
  Console.WriteLine("Prénom : ");
  string name2 = Console.ReadLine();
  Console.WriteLine("Email pour envoi du scan : ");
  string email2 = Console.ReadLine();
  Console.WriteLine("Inserer votre document (taper une phrase pour exemple): ");
  string paper2 = Console.ReadLine();

  Employee user2 = new Employee(name, lastName, email, paper);
  
  Console.WriteLine("/////////////////////////////////////////////////////////////////////");
  user2.scanPaper();
  Console.WriteLine("/////////////////////////////////////////////////////////////////////");
  
  Console.WriteLine("/////////////////////////////////////////////////////////////////////");
  Console.WriteLine("Historique de la journée : ");
  Console.WriteLine("Deux utilisateurs on scannés des document : ");
  Console.WriteLine(user.lastName + " et " + user2.lastName);
  Console.WriteLine("/////////////////////////////////////////////////////////////////////");
  
 }
}
