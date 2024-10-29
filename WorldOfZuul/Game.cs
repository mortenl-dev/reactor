using Spectre.Console;
using static System.Console;
using Spectre.Console.Cli;
namespace Reactor
{
    public class Game
    {

        public Game()
        {

        }

        private static void PrintHelp()
        {
            var table = new Table();
            table.AddColumn("Commands");
            table.AddColumn("Description");

            table.AddRow(new string[]{"look", "inspects the current location."});
            table.AddRow(new string[]{"back", "moves you back to the previous room."});
            table.AddRow(new string[]{"help", "print this message again."});
            table.AddRow(new string[]{"quit", "alt+f4."});
            
            AnsiConsole.Write(table);
            Console.WriteLine("You are lost. You are alone. You wander");
            Console.WriteLine("around the university.");
            Console.WriteLine();
            Console.WriteLine("Navigate by typing 'north', 'south', 'east', or 'west'.");

            
        }

        public static void Morten() {
            
        }
    }
}
