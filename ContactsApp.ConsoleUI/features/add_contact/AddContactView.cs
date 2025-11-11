using Microsoft.IdentityModel.Tokens;

namespace ContactsApp.ConsoleUI.Features.AddContact
{
    public class AddContactView
    {
        public void ShowMessage(string msg, ConsoleColor color = ConsoleColor.Green)
        {
            var prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ForegroundColor = prev;
        }


        public (string firstName, string lastName, string? email, string phone, string? address, int countryId) Render()
        {
            Console.WriteLine();
            Console.WriteLine("\n=== Add New Contact ===\n");

            string firstName;
            do
            {
                Console.Write("Enter FirstName (3–30 chars): ");
                firstName = Console.ReadLine() ?? string.Empty;
            } while (firstName.Length < 3 || firstName.Length > 30 || string.IsNullOrWhiteSpace(firstName));

            string lastName;
            do
            {
                Console.Write("Enter LastName (3–30 chars): ");
                lastName = Console.ReadLine() ?? string.Empty;
            } while (lastName.Length < 3 || lastName.Length > 30 || string.IsNullOrWhiteSpace(lastName));

            string phone;
            do
            {
                Console.Write("Enter Phone: ");
                phone = Console.ReadLine() ?? string.Empty;
            } while (string.IsNullOrWhiteSpace(phone) || !phone.All(char.IsDigit));
            //phone.Any(c => !char.IsDigit(c))


            string email;
            Console.Write("Enter Email: ");
            email = Console.ReadLine() ?? string.Empty;

            while (!email.Contains("@") || !email.Contains(".") && (!string.IsNullOrWhiteSpace(email)))
            {
                Console.WriteLine("Invalid email format. Please try again.");
                Console.Write("Enter Email: ");
                email = Console.ReadLine() ?? string.Empty;
            }

            Console.Write("Enter Address (optional): ");
            string? address = Console.ReadLine();

            int countryId;
            do
            {
                Console.Write("Enter CountryId (numeric): ");
            } while (!int.TryParse(Console.ReadLine(), out countryId));

            Console.WriteLine("\nContact successfully captured.\n");

            Console.WriteLine();
            return (firstName.Trim(), lastName.Trim(), email?.Trim(), phone.Trim(), address?.Trim(), countryId);
        }
    }

}
