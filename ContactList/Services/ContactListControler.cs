using ContactList.Models;
using System.ComponentModel.Design;

namespace ContactList.Services;

public class ContactListControler
{

    private List<Contact> contacts =[];


    public void AddContactToList(Contact contact)
    {
        foreach (var item in contacts)
        {
            if (item.Email == contact.Email)
            {
                Console.WriteLine("Contact already exist");
                return;
            }
    
        }
        contacts.Add(contact);
        
    }

    public List<Contact> GetAllContact()
    {
        return contacts;
    }

    public void PrintAllContacts()
    {
        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.FirstName}//{contact.LastName}//{contact.PhoneNumber}//{contact.Email}//{contact.Address}");
        }
    }

}

