

using AddressbookClass.Interfaces;
using AddressbookClass.Service;

namespace Addressbook.Tests;

public class FileService_Tests
{
    [Fact]

    public void SaveToFileShould_SaveContentToFile_ThenReturnTrue()
    {
        //Arrange
        IFileService fileservice = new FileService();
        string filePath = @"c:\Projects\tests.json";
        string content = "Test ConsoleApp";

        //Act
        var result = fileservice.SaveContentToFile(filePath, content);

        //Assert
        Assert.True(result);
    }

   
}
