using ContactsApp.Core.Contacts.Interfaces;
using ContactsApp.Core.Contacts.UseCases.AddContact;

namespace ContactsApp.ConsoleUI.Features.AddContact
{ 
    public class AddContactController
    {
        private readonly IContactRepository _repository;
        private readonly AddContactPresenter _presenter;
        private readonly AddContactView _view;

        public AddContactController(IContactRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _view = new AddContactView();
            _presenter = new AddContactPresenter(_view);
        }

        public void Run()
        { 
            Console.WriteLine();
            try
            {
                var input = _view.Render();
                var useCase = new AddContactUseCase(_repository);
                var result = useCase.Execute(input);
                _presenter.ShowAddResult(result);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"❌ Error: {ex.Message}", ConsoleColor.Red);
            }
        }
    }
}