

namespace AddressbookClass.Interfaces;

public interface IFileService
{
    /// <summary>
    /// Save content to a .json file
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="content"></param>
    /// <returns>Return true if the content is successfully saved otherwise false</returns>
    bool SaveContentToFile(string filePath, string content);

    /// <summary>
    /// Get content from a .json file
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns>Returns content from a .json file</returns>
    string GetContentFromFile(string filePath);
}
