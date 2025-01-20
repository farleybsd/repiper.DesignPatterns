/*
  Padrao Chain Of Responsability
  * Cadeia de Handlers
 *  Desacoplar remetente de recepector
 * Multiplos objetos podem processar a informacao
*/

// Uso do Chain Of Responsability

using DesignerPatterns.Chain_Of_Responsibility.GOOD;

var assistant = new AssistantApprover();
var manager = new ManegerApprover();
var diretor = new DirectorrApprover();

assistant.SetNextAprrover(manager);
manager.SetNextAprrover(diretor);
var document = new Document("Relatorio Financeiro");
assistant.HandlerRequest(document);