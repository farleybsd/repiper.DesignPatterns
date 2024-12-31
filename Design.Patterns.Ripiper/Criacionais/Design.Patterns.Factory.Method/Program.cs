
using Design.Patterns.Factory.Method.GOOD;

var truckTransport = new TruckTransport();
truckTransport.Deliver();

var shipTransport = new ShipTransport();
shipTransport.Deliver();