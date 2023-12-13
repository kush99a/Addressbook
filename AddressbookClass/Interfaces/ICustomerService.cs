

namespace AddressbookClass.Interfaces;

public interface ICustomerService
{
    bool AddCustomerTolist(ICustomer customer);
    IEnumerable<ICustomer> GetCustomersFromList();
    ICustomer GetCustomerFromList(string email);
    public bool RemoveCustomer(string email);
}
