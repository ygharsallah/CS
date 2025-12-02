using System.Collections.Specialized;

namespace PasswordManager;


public class Password
{
    private int[] createRecoveryCodes()
    {
        Random random = new Random();
        int[] codes = new int[10];
        
        for (int i = 0; i < codes.Length; i++)
        {
            codes[i] = random.Next(1000);
        }
        
        return codes;
    }
    
    private string password;
    private int[] recoveryCodes;

    // Constructor
    public Password(string password)
    {
        this.password = password;
        this.recoveryCodes = createRecoveryCodes() ;
    }
    
    // Methods
    public string getPassword()
    {
        return this.password;
    }
    
    public int[] getRecoveryCodes()
    {
        return this.recoveryCodes;
    }

    public int[] regenerateRecoveryCodes()
    {
        return this.recoveryCodes = createRecoveryCodes();
    }

    public void changePassword(string newPassword)
    {
        this.password = newPassword;
    }

    public override string ToString()
    {
        return $"{password} , [{string.Join(", ", recoveryCodes)}]";
    }


    
}
