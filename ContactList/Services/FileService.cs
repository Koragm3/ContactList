using System.Diagnostics;
using System.Text.Json;
using ContactList.Interface;
using ContactList.Models;

namespace ContactList.Services;

public class FileService : IFileService
{
    private readonly string _filePath = @"C:\Projects\content.txt";

    public string GetContact(string filepath)
    {
        try
        {
            using (var sr = new StreamReader(_filePath))
            {
                sr.ReadLine();
                string json = JsonSerializer.Deserialize(contact);


            }

        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        };
    }

  

    public void SaveContactAsJson( List<Contact> contacts)
    {
        try
        {
            using (var sw = new StreamWriter(_filePath))
            {
                string json = JsonSerializer.Serialize(contacts);
                sw.WriteLine(json);
                
            }
         
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message);

            
        }
 
    }

    
}
