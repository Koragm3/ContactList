using ContactList.Models;
using ContactList.Services;
using System.Text.Json.Serialization;


ContactListControler contactList = new ContactListControler();
FileService fileService = new FileService();

while (true)
{
    Contact contact = new Contact();
    contact = contact.CreateContact();
    contactList.AddContactToList(contact);
    Console.WriteLine("Do you want to add more contacts (Y/N) : ");

    string input = Console.ReadLine();

    if (input.ToLower() == "y")
    {
        
        continue;

    }else
    {
        break;
    }
        
}

contactList.PrintAllContacts();
fileService.SaveContactAsJson(contactList.GetAllContact());


Console.ReadKey();


