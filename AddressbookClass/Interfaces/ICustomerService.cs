

namespace AddressbookClass.Interfaces;

public interface ICustomerService
{
    /// <summary>
    /// Add a customer to a list
    /// </summary>
    /// <param name="customer"></param>
    /// <returns>true if a customer gets successfully added and false if not</returns>
    bool AddCustomerTolist(ICustomer customer);
    /// <summary>
    /// Get customers from a list
    /// </summary>
    /// <returns>A iterable list of all customers</returns>
    IEnumerable<ICustomer> GetCustomersFromList();
    /// <summary>
    /// Get a customer from a list with email
    /// </summary>
    /// <param name="email"></param>
    /// <returns>Customer from specified email</returns>
    ICustomer GetCustomerFromList(string email);
    /// <summary>
    /// Remove a customer from list
    /// </summary>
    /// <param name="email"></param>
    /// <returns>True if customer is succcessfully removed, otherwise false</returns>
    bool RemoveCustomer(string email);
}
