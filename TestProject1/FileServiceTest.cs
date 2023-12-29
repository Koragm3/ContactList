using ContactList.Models;
using ContactList.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace TestProject1
{
    public class FileServiceTest
    {
        [Fact]
        public void GetContact_Returns_Contacts_List_When_The_Saved_Json_File_Exists()
        {

            // Arrange
            
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"TestData" , "ValidJson.json");
            var fileService = new FileService(filePath);
            
            // Act
            var contacts = fileService.GetContact();

            // Assert
            Assert.NotNull(contacts);
            Assert.IsType<List<Contact>>(contacts);           
        }
    }
}
