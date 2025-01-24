// Uso da boa pratica padrao Memento

using DesignPatterns.Ripiper.memento.GOOD;

var editor = new TextEditor();
var history = new EditorHistory();

history.SaveState(editor); // Salva o Estado Inicial
editor.Write("Ola Mundo");
history.SaveState(editor); // Salva o Estado Apos Escrever

editor.Write("Mais Texto");
Console.Write("Antes de Desfazer");
history.Undo(editor); // Desfaz mais uma Acao

Console.WriteLine("Depois de Desfazer");
history.Undo(editor); // Desfaz mais uma Acao
