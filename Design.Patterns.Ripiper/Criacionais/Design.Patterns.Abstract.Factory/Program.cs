// See https://aka.ms/new-console-template for more information

using Design.Patterns.Abstract.Factory.GOOD;

var winFactory = new WinFactory();
var client = new Client(winFactory);
client.CreateUi();

var macFactory = new MacosFactory();
client = new Client(macFactory);
client.CreateUi();