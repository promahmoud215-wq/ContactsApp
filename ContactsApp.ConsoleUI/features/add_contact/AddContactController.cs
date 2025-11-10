using ContactsApp.Core.Contacts.Interfaces;
using ContactsApp.Core.UseCases.Contacts; 

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
            try
            {
                var input = _view.Render();

                var useCase = new AddContactUseCase(_repository);
                var result = useCase.Execute(input.Name, input.Phone, input.Email);

                _presenter.ShowAddResult(result);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"❌ Error: {ex.Message}");
            }
        }
    }
}