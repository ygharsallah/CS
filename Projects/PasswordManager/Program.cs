namespace PasswordManager;

public class Program
{
    public static void Main(string[] args)
    {
        Password Pass = new Password("Yonesistcool76");
        
        User Yones = new User("Yones");
        Yones.AddPassword(Pass);
        
        foreach (Password p in Yones.getKeypass())
        {
            Console.WriteLine(p);
        }

        Pass.regenerateRecoveryCodes();
        
        foreach (Password p in Yones.getKeypass())
        {
            Console.WriteLine(p);
        }

    }
}
