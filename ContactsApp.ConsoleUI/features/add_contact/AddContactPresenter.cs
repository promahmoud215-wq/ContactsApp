using ContactsApp.Core.Contacts.Entities;

namespace ContactsApp.ConsoleUI.Features.AddContact
{
    public class AddContactPresenter
    {
        private readonly AddContactView _view;
        
        public AddContactPresenter(AddContactView view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }
        public void ShowAddResult(Contact? contact)
        {
            if (contact is not null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                _view.ShowMessage($"✅ Contact '{contact.Name}' added successfully!", ConsoleColor.Green);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                _view.ShowMessage("❌ Failed to add contact.", ConsoleColor.Red);
            }
            Console.ResetColor();
        }
    }
}
