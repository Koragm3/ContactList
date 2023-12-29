namespace ContactList.Interface
{
    public interface IContact
    {
        string Address { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}