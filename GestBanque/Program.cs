namespace GestBanque;
using Models;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        Person doeJane = new Person()
        {
            Name = "Doe",
            FirstName = "Jane",
            Birthday = new DateTime(1970, 1, 1)
        };

        Person doeJonhy = new Person()
        {
            Name = "Doe",
            FirstName = "John",
            Birthday = new DateTime(1970, 1, 1)
        };

        Current jdAccount1 = new Current()
        {
            Number = "0001",
            MaxCredit = 500,
            Owner = doeJohn
        };
        Current jdAccount2 = new Current()
        {
            Number = "0002",
            MaxCredit = 500,
            Owner = doeJohn
        };
        Current jdAccount3 = new Current()
        {
            Number = "0003",
            MaxCredit = 500,
            Owner = doeJohn
        };
        Current jdAccount4 = new Current()
        {
            Number = "0004",
            MaxCredit = 500,
            Owner = doeJohn
        };
        Current jdAccount5 = new Current()
        {
            Number = "0005",
            MaxCredit = 500,
            Owner = doeJonhy
        };
        Current jdAccount6 = new Current()
        {
            Number = "0006",
            MaxCredit = 500,
            Owner = doeJane
        };
        bank.Add(jdAccount1);
        bank.Add(jdAccount2);
        bank.Add(jdAccount3);
        bank.Add(jdAccount4);
        bank.Add(jdAccount5);
        bank.Add(jdAccount6);

        for(int i = 1; i <= 6; i++) {
            string number = "000" + i;
            bank[number].Deposit(100);
            Console.WriteLine($"100 déposée dans le compte {number}, solde = {bank[number].Balance}");
        }
        bank["0003"].Withdraw(300);
        Console.WriteLine($"300 retiré dans le compte 0003, solde = {bank["0003"].Balance}");

        bank.Remove("0001");
        Console.WriteLine($"Compte 0001 supprimé : {bank["0001"] is null}");

        Console.WriteLine($"Jonh possède {bank.TotalAssets(doeJohn)} en avoirs");
    }
}
