using System;
// Abstract factory design pattern

// Classe mère catalogue abstract
public abstract class Automobile
{
    protected string modele;
    protected string couleur;
    protected int puissance;
    protected double espace;

    protected Automobile(string modele, string couleur, int puissance, double espace)
    {
        this.modele = modele;
        this.couleur = couleur;
        this.puissance = puissance;
        this.espace = espace;
    }

    public abstract void afficherCarac();
}

// Classe fille de Catalogue
public class AutomobileElectrique : Automobile
{
    public AutomobileElectrique(string modele, string couleur, int puissance, double espace) : base(modele, couleur, puissance, espace)
    {
    }

    public override void afficherCarac()
    {
        Console.WriteLine("Automobile éléctrique : ");
        Console.WriteLine("Modèle : " + modele);
        Console.WriteLine("Couleur : " + couleur);
        Console.WriteLine("Puissance : " + puissance);
        Console.WriteLine("Espace : " + espace);
    }
}

// Interface Factory 
public interface FabriqueVehicule
{
    Automobile creerAutomobile(string modele, string couleur, int puissance, double espace);

}

// Classe factory pour creer un véhicule éléctrique
public class FabriqueVehiculeElectique : FabriqueVehicule
{
    public Automobile creerAutomobile(string modele, string couleur, int puissance, double espace)
    {
        return new AutomobileElectrique(modele, couleur, puissance, espace);
    }
}

public class Catalogue
{
    static void Main(string[] args)
    {
        FabriqueVehicule fabrique = new FabriqueVehiculeElectique();
        Console.WriteLine("Hello, World!");
    }
}