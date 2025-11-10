using System.Linq;
using ContactsApp.Core.Contacts.Entities;
using ContactsApp.Core.Contacts.Exceptions;

namespace ContactsApp.Core.Contacts.Services
{
    public static class ContactValidator
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 30;

        public static void Validate(Contact contact)
        {
            if (contact.Name.Length < MinNameLength || contact.Name.Length > MaxNameLength)
                throw new InvalidContactDataException($"Name must be between {MinNameLength} and {MaxNameLength} characters.");

            if (!contact.Phone.All(char.IsDigit))
                throw new InvalidContactDataException("Phone must contain only digits.");
        }
    }
}
