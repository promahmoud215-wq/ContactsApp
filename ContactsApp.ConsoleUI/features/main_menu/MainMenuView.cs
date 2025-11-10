
namespace ContactsApp.ConsoleUI.Features.MainMenu   
{
    public class    MainMenuView
    {
        public void Render()
        {
            Console.WriteLine("\t\t\tMain Menu");
            Console.WriteLine("1- Add Contact");
            //Console.WriteLine("2- Delete Contact");
            //Console.WriteLine("3- Update Contact");
            //Console.WriteLine("4- Search Contact");
            //Console.WriteLine("5- Show All Contacts");
            //Console.WriteLine("6- Exit");
            Console.WriteLine("------------------------");
        }

        public int GetUserChoice()
        {
            Console.Write("Enter your choice: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                return choice;
            }
            return -1; // Invalid choice
        }



    }
}

