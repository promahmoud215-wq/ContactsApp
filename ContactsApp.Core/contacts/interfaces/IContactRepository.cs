using ContactsApp.Core.Contacts.Entities;

namespace ContactsApp.Core.Contacts.Interfaces
{
    public interface IContactRepository
    {
        void Add(Contact contact);
        //void Update(Contact contact);
        //void Delete(Guid id);
        //Contact? GetById(Guid id);
        //IEnumerable<Contact> GetAll();
        //IEnumerable<Contact> Search(string keyword);
    }
}
