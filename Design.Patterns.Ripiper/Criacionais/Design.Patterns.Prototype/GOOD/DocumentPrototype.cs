namespace Design.Patterns.Prototype.GOOD;

public class DocumentPrototype : ICloneable
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Footer { get; set; }

    public DocumentPrototype(string title, string content, string footer)
    {
        Title = title;
        Content = content;
        Footer = footer;
    }
    
    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Content: {Content}, Footer: {Footer}");
    }
    
    // Implementacao do Prototype : clonagem
    public object Clone()
    {
       return this.MemberwiseClone();
    }
}