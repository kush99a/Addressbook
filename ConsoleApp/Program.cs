using AddressbookClass.Interfaces;
using AddressbookClass.Models;
using AddressbookClass.Service;
using ConsoleApp.Services;
public class Program
{
    private static void Main(string[] args)
    {


        Console.WriteLine("Välkommen till vår adressbok!");
        Console.WriteLine("Vänligen välj alternativ nedan: \n");
        bool active = true;
        while (active)
        {
            Console.WriteLine("1. Registrera som kund \n");
            Console.WriteLine("2. Visa alla kunder \n");
            Console.WriteLine("3. Ta bort kund");
            Console.WriteLine("4. Avsluta \n");

            string result = Console.ReadLine()!;
            switch (result)
            {
                case "1":
                    MenuServices.AddPrivateMenu();
                    Console.Clear();
                    break;
                case "2":
                    MenuServices.showallcustomers();
                    break;
                case "3":
                    MenuServices.removecustomer();
                    Console.Clear();
                    break;
                case "4":
                    active = false;
                    break;
                default:
                    Console.Clear();
                    break;

            }
        }
            
    }
}