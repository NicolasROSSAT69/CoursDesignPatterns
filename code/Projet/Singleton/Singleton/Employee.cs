namespace Singleton;

public class Employee
{
    public String name { get; set; }
    public String lastName { get; set; }
    public String email { get; set; }
    
    public String paper { get; set; }

    public Employee(string name, string lastName, string email, string paper)
    {
        this.name = name;
        this.lastName = lastName;
        this.email = email;
        this.paper = paper;
    }

    public void scanPaper()
    {
        Scanner scanner = Scanner.getInstance();
        scanner.scan("Document : " + paper + " Scanné par : " + lastName + ", " + name + " Email pour envoie : " + email);
    }
}