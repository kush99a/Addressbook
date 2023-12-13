

using AddressbookClass.Interfaces;
using AddressbookClass.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace AddressbookClass.Service;

public class CustomerService : ICustomerService
{
    private readonly IFileService _fileservice = new FileService();
    private List<ICustomer> _customers = [];
    private readonly string _filepath = @"c:\projects\contacts.json";
    

    public bool AddCustomerTolist(ICustomer customer)
    {
        try
        {
            if (! _customers.Any(x => x.Email == customer.Email)) 
            {
                _customers.Add(customer);

                string json = JsonConvert.SerializeObject(_customers, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });


                var result = _fileservice.SaveContentToFile(_filepath, json);
                return result; 

            }


        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }

    public bool RemoveCustomer(string email)
    {
        try
        {
            GetCustomersFromList();

            foreach (var customer in _customers)
            {
                if (customer.Email == email)
                {
                    _customers.Remove(customer);
                    string json = JsonConvert.SerializeObject(_customers, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
                    File.WriteAllText(_filepath, json);
                    return true;
                }
            }
        }
        catch (Exception e) { Debug.WriteLine(e.Message); }
        Console.WriteLine("Kunden existerar inte");
        return false;
    }

    public ICustomer GetCustomerFromList(string email)
    {
        try
        {
            GetCustomersFromList();

            var customer = _customers.FirstOrDefault(x => x.Email == email);
            return customer ??= null!;

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public IEnumerable<ICustomer> GetCustomersFromList()
    {
        try
        {
            var content = _fileservice.GetContentFromFile(_filepath);
            if (!string.IsNullOrEmpty(content)) 
            {
                _customers = JsonConvert.DeserializeObject<List<ICustomer>>(content, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All })!;
                return _customers;
            }

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
}
