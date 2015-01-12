/*Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/

using System;

class BankAccountData
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Welcome to Poor Bulgarian BANK (PBB) 1.0v | {0}", date);
        Console.WriteLine("----------------------------------------");
        Console.Write("Please enter your username:");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, {0} !", userName);
        Console.WriteLine("----------------------------------------");
        string holderNames = "Tsvetan Radoev Vasilev";
        float amoutOfMoney = 5.0f;
        int lastTransaction = 206000000;
        string bankName = "PBB";
        string iBan = "BG 43 BNBG 9661 3300 1484 02";
        long creditCard1 = 4012888888881881;
        long creditCard2 = 3782822463100053;
        long creditCard3 = 4844264826820130;
        Console.WriteLine("Holder name - {0}, available amount: {1} BGN at '{2}' BANK", holderNames, amoutOfMoney, bankName);
        Console.WriteLine("IBAN:{0} \nHolder credit card numbers: \nVisa - {1} \nVisa Electron - {2} \nAmerican Express - {3}", iBan, creditCard1, creditCard2, creditCard3);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Your last outgoing transaction is {0} million BGN", lastTransaction);
    }
}
