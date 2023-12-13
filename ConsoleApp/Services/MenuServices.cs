

using AddressbookClass.Interfaces;
using AddressbookClass.Models;
using AddressbookClass.Service;

namespace ConsoleApp.Services;

internal class MenuServices
{
    private static readonly ICustomerService _customerservice = new CustomerService();

    public static void AddPrivateMenu()
    {
        IPrivateCustomer customer = new PrivateCustomer();
        Console.Clear();

        Console.WriteLine(" Förnamn: ");
        customer.FirstName = Console.ReadLine()!;

        Console.WriteLine(" Efternamn: ");
        customer.LastName = Console.ReadLine()!;

        Console.WriteLine(" Email: ");
        customer.Email = Console.ReadLine()!;

        Console.WriteLine(" Telefonnumer: ");
        customer.PhoneNumber = Console.ReadLine()!;

        Console.WriteLine(" Adress: ");
        customer.Address = Console.ReadLine()!;

        _customerservice.AddCustomerTolist(customer);
    }

    public static void showallcustomers()
    {
        var customers = _customerservice.GetCustomersFromList();
        Console.Clear();
        foreach (IPrivateCustomer customer in customers)
        {
            Console.WriteLine($"""
            Förnamn: {customer.FirstName} 
            Efternamn: {customer.LastName} 
            Mail: {customer.Email} 
            Telefonnummer: {customer.PhoneNumber} 
            Adress: {customer.Address}
            -----------------------------------------
            """);
            
        }
        Console.WriteLine("Välj ett nytt alternativ: \n");
    }

    public static void GetCustomer()
    {
        Console.WriteLine("Email:");
        var customer = (IPrivateCustomer) _customerservice.GetCustomerFromList(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"""
            Förnamn: {customer.FirstName} 
            Efternamn: {customer.LastName} 
            Mail: {customer.Email} 
            Telefonnummer: {customer.PhoneNumber} 
            Adress: {customer.Address}
            -----------------------------------------
            Välj ett nytt alternativ:

            """);
      
    }

    public static void removecustomer()
    {
        Console.WriteLine("Email: ");
        _customerservice.RemoveCustomer(Console.ReadLine());
    }
}
