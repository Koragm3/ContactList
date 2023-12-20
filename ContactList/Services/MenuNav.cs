using ContactList.Models;
using System.Threading.Channels;

namespace ContactList.Services;

public class MenuNav()
{

    public void MenuOptions()
    {
        ContactListControler contactList = new ContactListControler();
        FileService fileService = new FileService();

        while (true) {
            
            
            Console.WriteLine("######################MainMenu######################\n\n\n");
            Console.WriteLine("Select A Number To Start:");
            Console.WriteLine($"{"1_",-3} Add New Contact To The List");
            Console.WriteLine($"{"2_",-3} Show All Contacts In The List");
            Console.WriteLine($"{"3_",-3} Remove A Contact From The List");
            Console.WriteLine($"{"4_",-3} Exit App");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    MainMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Here Is All Your Saved Contacts:");                  
                    var jsonlist = fileService.GetContact();
                    contactList.AddList(jsonlist);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Please Enter The email Of The Contact That You Want To Remove:");
                    var EmailToDelete = Console.ReadLine();
                    contactList.RemoveContactFromListByEmail(EmailToDelete);
                    fileService.SaveContactAsJson(contactList.GetAllContact());
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("invaild number");
                    break;

            }
        }
        
    }



    
    public void MainMenu()
    {
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

            }
            else
            {
                break;
            }

        }

        //contactList.PrintAllContacts();
        fileService.SaveContactAsJson(contactList.GetAllContact());
        fileService.GetContact();


        Console.ReadKey();


    }

}
