using ContactList.Interface;

namespace ContactList.Models;

public class Contact : IContact
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int PhoneNumber { get; set; }
    public string Email { get; set; } = null!;
    public string Address { get; set; } = null!;



    public Contact CreateContact()
    {
        Contact contact = new Contact();
        Console.WriteLine("Please enter your name: ");
        contact.FirstName = Console.ReadLine()!;
        Console.WriteLine("Please enter your lastname: ");
        contact.LastName = Console.ReadLine()!;
        Console.WriteLine("Please enter your phonenumber: ");
        contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter your email: ");
        contact.Email = Console.ReadLine()!;
        Console.WriteLine("Please enter your adress: ");
        contact.Address = Console.ReadLine()!;
        return contact;
    }
}

