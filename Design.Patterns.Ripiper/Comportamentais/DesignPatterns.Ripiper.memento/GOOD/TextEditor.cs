namespace DesignPatterns.Ripiper.memento.GOOD;
//classe memento que armazena o estado do editor de texto
public class TextEditorMemento
{
    public TextEditorMemento(string content)
    {
        Content = content;
    }

    public string Content { get; set; }
}
// Classe que representa o Editor de Texto com suporte ao Memento
public class TextEditor
{
    public string Content { get; set; }

    public void Write(string text)
    {
        Content += text;
        Console.WriteLine($"Conteudo Atual: {Content}");
    }

    public TextEditorMemento Save()
    {
        return new TextEditorMemento(Content);
    }

    public void Restore(TextEditorMemento memento)
    {
        Content = memento.Content;
        Console.WriteLine($"Conteudo Restaurado: {Content}");
    }
}
// Classe Que Gerencia o sistema de Undo usando o memento
public class EditorHistory
{
    private readonly Stack<TextEditorMemento> _history = new Stack<TextEditorMemento>();

    public void SaveState(TextEditor editor)
    {
        _history.Push(editor.Save());
    }

    public void Undo(TextEditor editor)
    {
        if (_history.Count > 0)
        {
            var memento = _history.Pop();
            editor.Restore(memento);
        }
    }
}