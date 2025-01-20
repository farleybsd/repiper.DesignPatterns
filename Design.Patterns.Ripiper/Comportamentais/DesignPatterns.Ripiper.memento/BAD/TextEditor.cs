namespace DesignPatterns.Ripiper.memento.BAD;

//Classe que representa o editor de Texto
public class TextEditor
{
    public string Content { get; set; }

    public void Write(string text)
    {
        Content += text;
        Console.WriteLine($"Conteudo Atual: {Content}");
    }

    public void Clear()
    {
        Content = string.Empty;
        Console.WriteLine("Texto Limpo.");
    }
}
// Sistema que manipula o Editor de Texto sem Possibilidade de Desfazer
public class EditorSystem
{
    private readonly TextEditor _editor;

    public EditorSystem(TextEditor editor)
    {
        _editor = editor;
    }

    public void PerformWrite(string text)
    {
        _editor.Write(text);
    }

    public void PerformClear()
    {
        _editor.Clear();
    }
}