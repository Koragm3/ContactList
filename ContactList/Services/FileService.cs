using System.Diagnostics;
using System.Text.Json;
using ContactList.Interface;
using ContactList.Models;



namespace ContactList.Services;

public class FileService : IFileService
{
    private readonly string _filePath = @"C:\Projects\content.txt";
    private ContactListControler contactListControler = new ContactListControler();

    public List<Contact> GetContact()
    {


        using StreamReader reader = new(_filePath);
        var json = reader.ReadToEnd();


        List<Contact> contacts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Contact>>(json);
        contactListControler.PrintAllContacts(contacts);
        return contacts;
    }

 
    public void SaveContactAsJson( List<Contact> contacts)
    {
        try
        {
            Console.WriteLine(contacts.Count);
            using (var sw = new StreamWriter(_filePath))
            {

                string json = JsonSerializer.Serialize(contacts);
                Console.WriteLine(json);
                sw.WriteLine(json);
                
            }
         
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message);

            
        }
 
    }

    
}
