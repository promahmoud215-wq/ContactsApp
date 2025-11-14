using ContactsApp.Core.Contacts.Entities;
using ContactsApp.Core.Contacts.Interfaces;

namespace ContactsApp.Core.Contacts.UseCases.AddContact
{
    public class AddContactUseCase
    {
        private readonly IContactRepository _repository;

        public AddContactUseCase(IContactRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public AddContactOutput Execute(AddContactInput input)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));
            var contact = new Contact(
                input.FirstName, 
                input.LastName, 
                input.Phone, 
                input.Email, 
                input.Address, 
                input.CountryId
            );
            
            _repository.AddContact(contact);
            
            var output = new AddContactOutput(
                contact.Id,
                $"{contact.FirstName} {contact.LastName}",
                contact.Phone,
                contact.Email,
                contact.Address,
                contact.CountryId
            );

            return output;
        }
    }
}
