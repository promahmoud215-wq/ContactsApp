using ContactsApp.Infrastructure.Data;
using ContactsApp.ConsoleUI.Features.MainMenu;
using ContactsApp.Core.Contacts.Interfaces;
using ContactsApp.Infrastructure.Repositories;

namespace ContactsApp
{
    internal class Program
    {
//
        static void Main(string[] args)
        {
            DatabaseInitializer.Initialize();
            IContactRepository repository = new ContactRepository();
            MainMenuController ctr = new MainMenuController(repository);
            ctr.Run();
        }
    }
}
