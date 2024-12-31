// Uso com o servico Antigo

using Design.Patterns.Adapter.BAD;
using Design.Patterns.Adapter.GOOD;

var legacyService = new LegacyMessageServiceBad();
var alertSystem = new AlerSystemBad(legacyService);
alertSystem.SendAlert("OI");

// Adapter

var newservice = new NewMessageService();
var adapterSystem = new NewMessageServiceAdapter(newservice);
var NovoMensagemService = new NewMessageServiceAdapter(newservice);
var alertSystemadpter= new AlertSystemGood(adapterSystem);
alertSystemadpter.SendAlert("oi");