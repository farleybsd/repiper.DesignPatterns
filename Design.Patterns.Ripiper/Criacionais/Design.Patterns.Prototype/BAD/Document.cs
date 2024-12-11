namespace Design.Patterns.Prototype.BAD;

public class Document
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Footer { get; set; }

    public Document(string title, string content, string footer)
    {
        Title = title;
        Content = content;
        Footer = footer;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Content: {Content}, Footer: {Footer}");
    }
}