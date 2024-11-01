using System.Security.AccessControl;
using Spectre.Console;
namespace Reactor {
    public class Reactor {
        #region Fields
        public Structure structure {get; private set;}
        public Location location {get; private set;}
        public Cooling cooling {get; private set;}
        public Fuel fuel {get; private set;}
        #endregion
        public Reactor(Structure s, Location l, Cooling c, Fuel f) {
            structure = s;
            location = l;
            cooling = c;
            fuel = f;
            SetUpDisplays();
        }
        #region Amounts
        public int fuel_Amount {get; private set;}
        public int cooling_Amount {get; private set;}
        public int money_Amount {get; private set;}
        public int totalEnergy {get; private set;} // FOR END OF GAME

        #endregion
        Map map = new Map(); //init new map, not sure if it is relevant what kind of fuel we're using, yada yada
        Bars bars = new Bars();
        private void SetUpDisplays() {
            fuel_Amount = 10;
            cooling_Amount = 15;
            money_Amount = 100;

            Update();
        }
        #region UpdateMethods
        private void Update() { //Doesnt really allow for text-based commands, should consider doing it selection-only.
            if (fuel_Amount == 0) Console.WriteLine("GAME OVER");

            Console.SetCursorPosition(0,0);
            AnsiConsole.Write(new BarChart()
            .Width(60)
            .Label("[green bold underline]Bars[/]")
            .CenterLabel()
            
            .AddItem("Fuel", fuel_Amount, Color.Yellow)
            .AddItem("Cooling", cooling_Amount, Color.Green)
            .AddItem("Money", money_Amount, Color.Red)
            .AddItem("Energy", fuel.productionRate, Color.Yellow));

            fuel_Amount -= fuel.consumptionRate; //basic implementation of how the bars are calculated
            totalEnergy += fuel.productionRate;
            
            //theoretical implementation: needs to be changed, => fuel is used as per the consumptionrate, should probably be changed
            //to the rate of cooling being used/available, back up with actual research beforehand though

            map.PrintMap(); //PRINT THE MAP

            //add function that prints the current situations selection options-->

            
            Thread.Sleep(1000);
            Update();
        }
        #endregion
        public void BuyFuel() {
            //could add a waiting meter or smth, like a truck away and coming back with the fuel
            money_Amount -= fuel.price;
            fuel_Amount += fuel.turnover;
        }
        
    }
}