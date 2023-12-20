using ContactList.Models;
using System.ComponentModel.DataAnnotations;
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

    public void PrintAllContacts(List<Contact> contactslist)
    {
        foreach (var contact in contactslist)
        {
            Console.WriteLine($"{contact.FirstName},{contact.LastName},{contact.PhoneNumber},{contact.Email},{contact.Address}");
        }
    }

    public void RemoveContactFromListByEmail(string Email)
    {
        try
        {
            
            var index = contacts.FindIndex(x => x.Email == Email);
            if (index == -1)
            {
                return;
            }
            
            contacts.RemoveAt(index);
        } catch (ArgumentNullException ex) { return; }


    }
    public void AddList(List<Contact> savedList)
    {
        contacts.AddRange(savedList);

    }

}

