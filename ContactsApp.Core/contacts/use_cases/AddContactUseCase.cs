using ContactsApp.Core.Contacts.Entities;
using ContactsApp.Core.Contacts.Interfaces;
using ContactsApp.Core.Contacts.Services;

namespace ContactsApp.Core.UseCases.Contacts
{
    public class AddContactUseCase
    {
        private readonly IContactRepository _repository;

        public AddContactUseCase(IContactRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Contact Execute(string name, string phone, string? email = null)
        {
            var contact = new Contact(name, phone, email);
            ContactValidator.Validate(contact);
            _repository.Add(contact);
            return contact; 
        }
    }
}
