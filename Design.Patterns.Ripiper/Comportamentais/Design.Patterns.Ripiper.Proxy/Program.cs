using Design.Patterns.Ripiper.Proxy.GOOD;
/*
 * Representante de um objeto
 * Camada de Controle
 *  Objeto Original Custoso
*/

// Uso com Proxy
var realDocument = new RealDocument("Relatorio1","Confidencial");
var documentProxy = new DocumentProxy(realDocument,"Funcionario");

var system = new DocumentAcessSsystem();
system.AcessDocumett(documentProxy);

var adminDocumentProxy = new DocumentProxy(realDocument,"Admin");
system.AcessDocumett(adminDocumentProxy);