namespace PasswordManager;

public class User
{
    private string Name;
    private Password[] keypass;

    // Constructor
    public User(string name)
    {
        this.Name = name;
        this.keypass = new Password[0];  // not null
    }

    
    // Methods
    public Password getPassword(string name)
    {
        foreach (Password pass in keypass)
        {
            if (pass.getPassword() == name)
                return pass;
        }
        return null!;
    }


    public Password[] getKeypass()
    {
        return this.keypass;
    }

    public void AddPassword(Password pass)
    {
        Password[] newArray  = new Password[keypass.Length + 1];

        for (int i = 0; i < keypass.Length; i++)
        {
            newArray[i] = keypass[i];
        }

        newArray[keypass.Length] = pass;

        keypass = newArray;
    }

}
