using Microsoft.EntityFrameworkCore;

namespace PhoneBook
{
    public class ContactsContext: DbContext
    {
        public DbSet<Contact> Contacts { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite($"Data Source = phonebook.db");
    }
}
