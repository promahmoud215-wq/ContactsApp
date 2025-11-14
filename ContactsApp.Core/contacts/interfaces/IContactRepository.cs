using ContactsApp.Core.Contacts.Entities;

namespace ContactsApp.Core.Contacts.Interfaces
{
    public interface IContactRepository
    {
        void AddContact(Contact contact);
        //void DeleteContact(Guid id);
        //void UpdateContact(Contact contact);
        //Contact? GetById(Guid id);
        //IEnumerable<Contact> GetAll();
        //IEnumerable<Contact> Search(string keyword);
    }
}
