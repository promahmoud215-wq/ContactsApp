namespace ContactsApp.Core.Contacts.Entities
{
    public class Contact
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Phone { get; private set; }
        public string? Email { get; private set; }
        public string? Address { get; private set; }
        public int CountryId { get; private set; }
        
        public Contact(string firstName, string lastName, string phone, string? email = null, string? address = null, int countryId = 0)
        {
            SetFirstName(firstName, lastName);
            SetLastName(lastName);
            SetPhone(phone);
            SetEmail(email);
            SetAddress(address);
            SetCountryId(countryId);
        }

        public void SetFirstName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("FirstName cannot be empty.");
            FirstName = firstName.Trim();
        }
        public void SetLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name cannot be empty.");
            LastName = lastName.Trim();
        }
        public void SetPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone) )
                throw new ArgumentException("Phone number cannot be empty.");
            Phone = phone.Trim();
        }

        public void SetEmail(string? email)
        {
            if (email != null && (!email.Contains('@') || !email.Contains('.')))
                throw new ArgumentException("Invalid email format.");
            Email = email?.Trim();
        }

        public void SetAddress(string? address)
        {
            Address = address?.Trim();
        }
        
        public void SetCountryId(int countryId)
        {
            CountryId = countryId;
        }


    }
}
