namespace BasicContactList
{
    public class Contact
    {
        public string Name;
        public string PhoneNumber;
        public string Email;
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
    public class Contacts
    {
        private List<Contact> contacts;
        public Contacts()
        {
            contacts = new List<Contact>();
        }
        public void AddContact()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine()!;
            Console.WriteLine("Enter email: ");
            string email = Console.ReadLine()!;

            Contact contact = new Contact(name, phoneNumber, email);
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
        }

        public void ViewContacts()
    {
        Console.WriteLine("Contact List:");
        Console.WriteLine(" ---------------------------------------------------");
        Console.WriteLine("|   Name   |   Phone Number   |          Email       |");
        Console.WriteLine(" ---------------------------------------------------");

        foreach (var contact in contacts)
        {
            Console.WriteLine($"| {contact.Name,-9} | {contact.PhoneNumber,-15} | {contact.Email,-9} |");
        }
            Console.WriteLine(" ---------------------------------------------------");
    }

    public void SearchContacts()
    {
        Console.WriteLine("Enter the name to search: ");
        string searchName = Console.ReadLine()!;

        List<Contact> searchResults = contacts.FindAll(contact => contact.Name.Contains(searchName));

        if (searchResults.Count > 0)
        {
            Console.WriteLine("Search Results:");
            Console.WriteLine(" ---------------------------------------------------");
            Console.WriteLine("|   Name   |   Phone Number   |      Email           |");
            Console.WriteLine(" ---------------------------------------------------");

            foreach (var contact in searchResults)
            {
                Console.WriteLine($"| {contact.Name,-9} | {contact.PhoneNumber,-15} | {contact.Email,-9} |");
            }

            Console.WriteLine(" ---------------------------------------------------");
        }
        else
        {
            Console.WriteLine("No contacts found with the specified name.");
        }
    }
        public void UpdateContact()
        {
            Console.WriteLine("Enter the index of the contact to update: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < contacts.Count)
            {
                Console.WriteLine("Enter updated name: ");
                string name = Console.ReadLine()!;
                Console.WriteLine("Enter updated phone number: ");
                string phoneNumber = Console.ReadLine()!;
                Console.WriteLine("Enter updated email: ");
                string email = Console.ReadLine()!;

                contacts[index].Name = name;
                contacts[index].PhoneNumber = phoneNumber;
                contacts[index].Email = email;

                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid contact index.");
            }
        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter the index of the contact to delete: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < contacts.Count)
            {
                contacts.RemoveAt(index);
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid contact index.");
            }
        }
    }
}