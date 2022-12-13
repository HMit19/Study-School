namespace MyApp;

public class Account
{
    private string username;
    private string password;

    public Account()
    {
    }

    public Account(string username, string password)
    {
        this.username = username;
        this.password = password;
    }
    
    public Account(Account account)
    {
        this.username = account.Username;
        this.password = account.Password;
    }

    public string Username
    {
        get => username;
        set => username = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Password
    {
        get => password;
        set => password = value ?? throw new ArgumentNullException(nameof(value));
    }

    public String toString()
    {
        return "account [username= " + username + ", password= "+ password + "]";
    }
}