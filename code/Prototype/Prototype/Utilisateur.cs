using System;
using Prototype;

public class Utilisateur
{
  static void Main(string[] args)
  {
    LiasseVierge liasseVierge = LiasseVierge.Instance();
    liasseVierge.ajoute(new BonDeCommande());
    liasseVierge.ajoute(new CertificatCession());
    liasseVierge.ajoute(new DemandeImmatriculation());
    // création d'une nouvelle liasse pour deux clients
    LiasseClient liasseClient1 = new LiasseClient(
      "Martin");
    LiasseClient liasseClient2 = new LiasseClient(
      "Durant");
    liasseClient1.affiche();
    liasseClient2.affiche();
    
    Vendeur vendeur1 = Vendeur.getInstance();
    vendeur1.nom = "ROSSAT";
    vendeur1.prenom = "Nicolas";
    
    Console.WriteLine("Nom : " + vendeur1.nom);
    Console.WriteLine("Prenom : " + vendeur1.prenom);
    
    Vendeur vendeur2 = Vendeur.getInstance();
    vendeur2.nom = "RORO";
    vendeur2.prenom = "Nico";
    
    Console.WriteLine("Vendeur 1 : ");
    Console.WriteLine("Nom : " + vendeur1.nom);
    Console.WriteLine("Prenom : " + vendeur1.prenom);
    
    Console.WriteLine("Vendeur 2 : ");
    Console.WriteLine("Nom : " + vendeur2.nom);
    Console.WriteLine("Prenom : " + vendeur2.prenom);
    
  }
}
