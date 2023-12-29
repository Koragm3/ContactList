using ContactList.Models;
using ContactList.Services;
using System;
using System.Collections.Generic;
using Xunit;

public class ContactListControllerTests
{
    [Fact]
    public void Method_That_Adds_Contact_To_List()
    {
        // Arrange
        var controller = new ContactListControler();
        var contact = new Contact
        {
            FirstName = "Hans",
            LastName = "Mattin-Lassi",
            PhoneNumber = "1234567890",
            Email = "Hans@C#.com",
            Address = "Stockholm"
        };

        // Act
        controller.AddContactToList(contact);

        // Assert
        Assert.Single(controller.GetAllContact());
        Assert.Equal(contact, controller.GetAllContact()[0]);
    }

    [Fact]
    public void Method_ThatReturn_List()
    {
        // Arrange
        var controller = new ContactListControler();
        var contact1 = new Contact { Email = "test1@example.com" };
        var contact2 = new Contact { Email = "test2@example.com" };

        // Act
        controller.AddContactToList(contact1);
        controller.AddContactToList(contact2);

        // Assert
        Assert.Equal(new List<Contact> { contact1, contact2 }, controller.GetAllContact());
    }

    [Fact]
    public void Method_That_Return_Saved_Contacts_InList()
    {
        // Arrange
        var controller = new ContactListControler();
        var contact1 = new Contact
        {
            FirstName = "John",
            LastName = "Doe",
            PhoneNumber = "1234567890",
            Email = "john.doe@example.com",
            Address = "123 Main St"
        };

        // Act
        controller.AddContactToList(contact1);

        // Assert
        controller.PrintAllContacts(controller.GetAllContact());
        
    }

    [Fact]
    public void Method_That_Removes_Contact_From_The_List_By_Email()
    {
        // Arrange
        var controller = new ContactListControler();
        var contact = new Contact { Email = "test@example.com" };
        controller.AddContactToList(contact);

        // Act
        controller.RemoveContactFromListByEmail("test@example.com");

        // Assert
        Assert.Empty(controller.GetAllContact());
    }

    [Fact]
    public void AddList()
    {
        // Arrange
        var controller = new ContactListControler();
        var savedList = new List<Contact>
        {
            new Contact { Email = "test1@example.com" },
            new Contact { Email = "test2@example.com" }
        };

        // Act
        controller.AddList(savedList);

        // Assert
        Assert.Equal(savedList, controller.GetAllContact());
    }
}
