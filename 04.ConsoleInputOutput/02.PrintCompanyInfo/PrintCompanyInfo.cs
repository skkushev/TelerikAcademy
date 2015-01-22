/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
Example input:

program	user
Company name:	Telerik Academy
Company address:	31 Al. Malinov, Sofia
Phone number:	+359 888 55 55 555
Fax number:	2
Web site:	http://telerikacademy.com/
Manager first name:	Nikolay
Manager last name:	Kostov
Manager age:	25
Manager phone:	+359 2 981 981
Example output:

Telerik Academy
Address: 231 Al. Malinov, Sofia
Tel. +359 888 55 55 555
Fax: (no fax)
Web site: http://telerikacademy.com/
Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  */

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Enter Company Name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number (0876543210): ");
        long phoneNumber = long.Parse(Console.ReadLine());
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager information (Name, age, phone number): ");
        string managerInfo = Console.ReadLine();
        Console.WriteLine();
        
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. {0:(+359) # ## ## ##}", phoneNumber);
        Console.WriteLine("Fax: " + faxNumber);
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: " + managerInfo);
    }
}