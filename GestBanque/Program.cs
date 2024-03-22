namespace GestBanque;
using Models;

public class Program {
    public static void Main(string[] args) {
        Person doeJohn = new Person()
        {
            Name = "Doe",
            FirstName = "John",
            Birthday = new DateTime(1970, 1, 1)
        };

        Current jdAccount = new Current() { 
            Number = "0001",
            MaxCredit = 500,
            Owner = doeJohn
        };

        jdAccount.Deposit(-100);
        Console.WriteLine($"Depot de -100 : {jdAccount.Balance}");
        jdAccount.Deposit(100);
        Console.WriteLine($"Depot de 100 : {jdAccount.Balance}");
        jdAccount.Withdraw(-100);
        Console.WriteLine($"Retrait de -100 : {jdAccount.Balance}");
        jdAccount.Withdraw(100);
        Console.WriteLine($"Retrait de 100 : {jdAccount.Balance}");
        jdAccount.Withdraw(600);
        Console.WriteLine($"Retrait de 600 : {jdAccount.Balance}");
    }
}
