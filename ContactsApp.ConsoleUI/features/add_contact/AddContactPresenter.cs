using ContactsApp.Core.Contacts.UseCases.AddContact;

namespace ContactsApp.ConsoleUI.Features.AddContact
{
    public class AddContactPresenter
    {
        private readonly AddContactView _view;
        
        public AddContactPresenter(AddContactView view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }
        public void ShowAddResult(AddContactOutput? output)
        {
            if (output is not null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                _view.ShowMessage(
                    $"✅ Contact:\n" +
                    $"FullName: '{output.FullName}' \n" +
                    $"Phone: '{output.Phone}' \n" +
                    $"Email: '{output.Email}' \n" +
                    $"Address: '{output.Address}' \n" +
                    $"CountryId: '{output.CountryId}' \n" +
                    $"added successfully!\n", ConsoleColor.Green);
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