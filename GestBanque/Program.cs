namespace GestBanque;
using Models;

public class Program {
    public static void Main(string[] args) {
        Bank bank = new Bank()
        {
            Name = "RottenCorp"
        };
        Person doeJohn = new Person()
        {
            Name = "Doe",
            FirstName = "John",
            Birthday = new DateTime(1970, 1, 1)
        };

        Current jdAccount = new Current()
        {
            Number = "0001",
            MaxCredit = 500,
            Owner = doeJohn
        };
        bank.Add(jdAccount);

        bank["0001"].Deposit(-100);
        Console.WriteLine($"Depot de -100 : {bank["0001"].Balance}");
        bank["0001"].Deposit(100);
        Console.WriteLine($"Depot de 100 : {bank["0001"].Balance}");
        bank["0001"].Withdraw(-100);
        Console.WriteLine($"Retrait de -100 : {bank["0001"].Balance}");
        bank["0001"].Withdraw(100);
        Console.WriteLine($"Retrait de 100 : {bank["0001"].Balance}");
        bank["0001"].Withdraw(600);
        Console.WriteLine($"Retrait de 600 : {bank["0001"].Balance}");

        bank.Remove("0001");
        Console.WriteLine($"Compte 0001 supprimé : {bank["0001"] is null}");
    }
}
