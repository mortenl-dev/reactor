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
        }
        #region Bars
        public int fuel_Bar {get; private set;}
        public int cooling_Bar {get; private set;}
        public int money_Bar {get; private set;}
        public int energyProduction_Bar {get; private set;}
        #endregion
        Map map = new Map(); //init new map, not sure if it is relevant what kind of fuel we're using, yada yada
        Bars bars = new Bars();
        private void SetUpDisplays() {
            
            UpdateBars();
            UpdateMap();
        }
        #region UpdateMethods
        private void UpdateBars() { //Update the variable bars every second 

            fuel_Bar -= fuel.consumptionRate; //basic implementation of how the bars are calculated
            energyProduction_Bar += fuel.productionRate;

            Thread.Sleep(1000);
            UpdateBars();
        }
        private void UpdateMap() { //also --> could steal adams idea by making the player move throughout the reactor by listening to keypresses

            Thread.Sleep(1000);
            UpdateMap();
        }
        #endregion
        public void BuyFuel() {
            //could add a waiting meter or smth, like a truck away and coming back with the fuel
            money_Bar -= fuel.price;
            fuel_Bar += fuel.turnover;
        }
        
    }
}