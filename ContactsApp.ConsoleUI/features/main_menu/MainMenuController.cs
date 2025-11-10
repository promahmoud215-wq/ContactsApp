using ContactsApp.ConsoleUI.Features.AddContact;
//using ContactsApp.ConsoleUI.Features.DeleteContact;
//using ContactsApp.ConsoleUI.Features.SearchContact;
//using ContactsApp.ConsoleUI.Features.UpdateContact;
//using ContactsApp.ConsoleUI.Features.ShowAllContacts;
//using ContactsApp.ConsoleUI.Features.Exit;
using ContactsApp.Core.Contacts.Interfaces;

namespace ContactsApp.ConsoleUI.Features.MainMenu
{
    public class MainMenuController
    {
        private readonly IContactRepository _repository;
        public MainMenuController(IContactRepository repository)
        {
            _repository = repository;
        }

        public void Run()
        {
            var view = new MainMenu.MainMenuView ();
            view.Render();

            var choice = view.GetUserChoice();
            switch (choice)
            {
                case 1:
                    var addContactController = new AddContactController (_repository);
                    addContactController.Run();
                    break;
                //case 1:
                //    var showAllContactsController = new ShowAllContactsController{ };
                //    showAllContactsController.Run();
                //    break;
                //case 3:
                //    var searchContactController = new SearchContactController { };
                //    searchContactController.Run();
                //    break;
                //case 4:
                //    var updateContactController = new UpdateContactController { };
                //    updateContactController.Run();
                //    break;
                //case 5:
                //    var deleteContactController = new DeleteContactController { };
                //    deleteContactController.Run();
                //    break;
                //case 6:
                //    var exitController = new ExitController { };
                //    exitController.Run();
                //    break;
                default:
                    break;
            }
        }
    }
}