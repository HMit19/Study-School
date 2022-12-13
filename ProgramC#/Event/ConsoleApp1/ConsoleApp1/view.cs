namespace MyApp;

public delegate Account input();   

public class view
{
    public event input test;
    public static Account account = new Account();

    public Account ee()
    {
        return account;
    }

    public void input()
    {
        Console.WriteLine("Nhap username: ");
        account.Username = Console.ReadLine();
        Console.WriteLine("Nhap password: ");
        account.Password = Console.ReadLine();
        // phat di su kien 
        test?.Invoke();
    }
    public Account accountT { set; get; }
}