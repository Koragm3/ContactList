using ContactList.Models;

namespace ContactList.Interface;

public interface IFileService
{
    void SaveContactAsJson(List<Contact> contacts);
    List<Contact> GetContact();
}