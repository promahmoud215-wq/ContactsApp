namespace ContactsApp.Core.Contacts.UseCases.AddContact
{
    public record AddContactInput(
        string FirstName,
        string LastName,
        string Phone,
        string? Email,
        string? Address,
        int CountryId
    );
}