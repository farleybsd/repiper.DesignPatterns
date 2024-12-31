//BAD
using Design.Patterns.Prototype.BAD;
using Design.Patterns.Prototype.GOOD;

var doc1 = new Document("Report","Content of Report","Company Confidencial");
var doc2 = new Document(doc1.Title,doc1.Content,doc1.Footer);

// Prototype
var doc3 = new DocumentPrototype("Report","Content of Report","Company Confidencial");
var doc4 = (DocumentPrototype)doc3.Clone(); // Copia usando o prototype
doc3.Display();
doc4.Display();
