

using AddressbookClass.Interfaces;
using AddressbookClass.Models;
using AddressbookClass.Service;

namespace Addressbook.Tests;

public class CustomerService_Tests
{
    [Fact]
    public void AddToList_AddACustomerToCustomerList_ThenReturnTrue()
    {
        //Arrange
        ICustomer customer = new PrivateCustomer { FirstName = "", LastName = "", Address = "", PhoneNumber = "", Email = "", };
        ICustomerService customerService = new CustomerService();
        //Act
        bool result = customerService.AddCustomerTolist(customer);
        //Assert
        Assert.True(result);
    }

    [Fact]
    public void GetCustomersFromList_ShouldGetCustomersInCustomerList_ThenReturnListOfCustomer()
    {
        //Arrange
        ICustomer customer = new PrivateCustomer { Email = "", };
        ICustomerService customerService = new CustomerService();
        customerService.AddCustomerTolist(customer);

        //Act
        IEnumerable<ICustomer> result = customerService.GetCustomersFromList();
        //Assert
        Assert.NotNull(result);
        Assert.True(result.Any());
    }

    
}
