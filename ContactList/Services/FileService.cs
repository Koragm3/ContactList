using System.Diagnostics;
using System.Text.Json;
using ContactList.Interface;
using ContactList.Models;



namespace ContactList.Services;

public class FileService : IFileService
{
    private string filePath;
    public FileService(string _filePath)
    {
        this.filePath = _filePath;
    }
    private ContactListControler contactListControler = new ContactListControler();

    //This method is for reading json info from saved file
    public List<Contact> GetContact()
    {


        using StreamReader reader = new(filePath);
        var json = reader.ReadToEnd();


        List<Contact> contacts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Contact>>(json);
        contactListControler.PrintAllContacts(contacts);
        return contacts;
    }

    // This method is for saving files in json form
    public void SaveContactAsJson( List<Contact> contacts)
    {
        try
        {
            Console.WriteLine(contacts.Count);
            using (var sw = new StreamWriter(filePath))
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
