using BasicContactList;
public class Program
{
    static void Main(string[] args)
    {
        Contacts contactManager = new Contacts();

        while (true)
        {
            Console.WriteLine("Contact List");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. View Contacts");
            Console.WriteLine("3. Search Contacts");
            Console.WriteLine("4. Update Contact");
            Console.WriteLine("5. Delete Contact");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    contactManager.AddContact();
                    break;
                case "2":
                    contactManager.ViewContacts();
                    break;
                case "3":
                    contactManager.SearchContacts();
                    break;
                case "4":
                    contactManager.UpdateContact();
                    break;
                case "5":
                    contactManager.DeleteContact();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
