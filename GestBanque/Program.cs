﻿namespace GestBanque;
using Models;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program {
    public static void Main(string[] args) {
        Bank bank = new Bank("RottenCorp");
        Person doeJohn = new Person("Doe", "John", new DateTime(1970, 1, 1));

        Person doeJane = new Person("Doe", "Jane", new DateTime(1970, 1, 1));

        Person doeJonhy = new Person("Doe", "John", new DateTime(1970, 1, 1));

        Current? jdAccount1 = TryCreateCurrent(500, doeJohn, "0001");
        Current? jdAccount2 = TryCreateCurrent(500, doeJohn, "0002");
        Current? jdAccount3 = TryCreateCurrent(500, doeJohn, "0003");
        Current? jdAccount4 = TryCreateCurrent(500, doeJohn, "0004");
        Current? jdAccount5 = TryCreateCurrent(500, doeJonhy, "0005");
        Current? jdAccount6 = TryCreateCurrent(500, doeJane, "0006");
        bank.Add(jdAccount1);
        bank.Add(jdAccount2);
        bank.Add(jdAccount3);
        bank.Add(jdAccount4);
        bank.Add(jdAccount5);
        bank.Add(jdAccount6);

        for (int i = 1; i <= 6; i++) {
            try {
                string number = "000" + i;
                bank[number].Deposit(100);
                Console.WriteLine($"100 déposée dans le compte {number}, solde = {bank[number].Balance}");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        try {
            bank["0003"].Withdraw(300);
            Console.WriteLine($"300 retiré dans le compte 0003, solde = {bank["0003"].Balance}");
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        bank.Remove("0001");
        Console.WriteLine($"Compte 0001 supprimé : {bank["0001"] is null}");

        Console.WriteLine($"Jonh possède {bank.TotalAssets(doeJohn)} en avoirs");
    }

    private static Current? TryCreateCurrent(double maxCredit, Person owner, string number) {
        try {
            return new Current(maxCredit, owner, number);
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            return null;
        }
    }


}
