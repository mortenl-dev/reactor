using Spectre.Console;
using static System.Console;
using Spectre.Console.Cli;
namespace Reactor
{
    public class Game
    {

        public Game()
        {   
            PrintIntro();
            
            Reactor reactor = new Reactor( //INIT REACTOR WITH VALUES

                    new Structure() {
                        integrity = 5,
                    },
                    new Location() {
                        name = "Russia",
                        description = "russia desc",
                        entropy = 10,
                    },
                    new Cooling() {
                        name = "cool coolant",
                        description = "cooling desc",
                        coolingRate = 5,
                        price = 4,
                        turnover = 2,
                    },
                    new Fuel() {
                    name = "Uranium",
                    description = "insert desc",
                    consumptionRate = 5,
                    productionRate = 10,
                    price = 3,
                    turnover = 2,
                }) 
                {
                
            };
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

        private static void PrintIntro() {
            
        }
    }
}
