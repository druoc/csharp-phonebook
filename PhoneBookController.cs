using Spectre.Console;

namespace PhoneBook
{
    public class PhoneBookController
    {
        public static void AddRecord()
        {
            var name = AnsiConsole.Ask<string>("Please enter the name: ");
            var email = AnsiConsole.Ask<string>("Please enter the e-mail: ");
            var phoneNumber = AnsiConsole.Ask<string>("Please enter the phone number: ");

            using var db = new ContactsContext();
            db.Add(new Contact { Name = name, Email = email, Phone = phoneNumber });
            db.SaveChanges();
        }

        public static void DeleteRecord()
        {
            throw new NotImplementedException();
        }

        public static void UpdateRecord()
        {
            throw new NotImplementedException();
        }

        public static void ViewAllRecords()
        {
            throw new NotImplementedException();
        }

        public static void ViewRecord()
        {
            throw new NotImplementedException();
        }
    }
}
