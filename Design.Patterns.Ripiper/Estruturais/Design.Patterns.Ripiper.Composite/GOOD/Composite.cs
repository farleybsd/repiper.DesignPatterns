namespace Design.Patterns.Ripiper.Composite.GOOD;

// Componente base (component) ou a Abstracao
public abstract class FileSystemComponent
{
    public string Name { get; }

    protected FileSystemComponent(string name)
    {
        Name = name;
    }
    public abstract void Display();
}

// Objeto Folha (Leaf) para representar um arquivo
public class File : FileSystemComponent
{
    public File(string name) : base(name) { }
    public override void Display()
    {
        Console.WriteLine($" File: - {Name}");
    }
}
// Objeto Composto (Composite) para representar um diretorio 
public class Directory : FileSystemComponent
{
    private readonly List<FileSystemComponent> _components = new List<FileSystemComponent>();
    
    public Directory(string name) : base(name) { }

    public void Add(FileSystemComponent component)
    {
        _components.Add(component);
    }

    public void Remove(FileSystemComponent component)
    {
        _components.Remove(component);
    }
    public override void Display()
    {
        Console.WriteLine($" Directory: - {Name}");
        foreach (var component in _components)
        {
            component.Display();
        }
    }
}