using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace PhoneBook
{
    public class UserInput
    {
        public static void GetUserInput()
        {
            bool closeApp = false;
            while (!closeApp)
            {
                var userSelection = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("[red]What would you like to do?[/]")
                    .AddChoices(new[]
                    {
                        "Add a record", "Update a record", "Delete a record", "View a record", "View all records", "Quit"
                    }));
            }
        }
        
    }
}
