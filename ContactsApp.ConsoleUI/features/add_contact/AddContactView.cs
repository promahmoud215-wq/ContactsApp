namespace ContactsApp.ConsoleUI.Features.AddContact
{
    public class AddContactView
    {
        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public (string Name, string Phone, string? Email) Render()
        {
            Console.WriteLine();
            Console.WriteLine("=== Add New Contact ===");

            string name;
            do
            {
                Console.Write("Enter name (3–30 chars): ");
                name = Console.ReadLine() ?? string.Empty;
            } while (string.IsNullOrWhiteSpace(name));

            string phone;
            do
            {
                Console.Write("Enter phone: ");
                phone = Console.ReadLine() ?? string.Empty;
            } while (string.IsNullOrWhiteSpace(phone));

            Console.Write("Enter email (optional): ");
            string? email = Console.ReadLine();

            Console.WriteLine();
            return (name.Trim(), phone.Trim(), email?.Trim());
        }
    }

}
