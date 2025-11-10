namespace ContactsApp.Core.Contacts.Entities
{
    public class Contact
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string? Email { get; private set; }
            
        public Contact(string name, string phone, string? email = null)
        {
            SetName(name);
            SetPhone(phone);
            SetEmail(email);
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Contact name cannot be empty.");
            Name = name.Trim();
        }

        public void SetPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Phone number cannot be empty.");
            Phone = phone.Trim();
        }

        public void SetEmail(string? email)
        {
            if (email != null && !email.Contains('@'))
                throw new ArgumentException("Invalid email format.");
            Email = email?.Trim();
        }
    }
}
