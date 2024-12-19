namespace Design.Patterns.Ripiper.Composite.BAD;

/*
 * Tratamento diferente para arquivos e diretorios
 * Dificuldade de extensao
 * Baixa Flexibilidade
 */

// Classe para representar um arquivo
public class File
{
    public string Name { get; }

    public File(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine($" File: - {Name}");
    }
}

// Classe que representa um diretorio
public class Directory
{
    public string Name { get; }
    private readonly List<File> _files; // Evitar isso use Composicao
    private readonly List<Directory> _directories; // Evitar isso use Composicao

    public Directory(string name, List<File> files, List<Directory> directories)
    {
        Name = name;
        _files = files;
        _directories = directories;
    }

    public void AddFile(string fileName)
    {
        _files.Add(new File(fileName));
    }

    public void AddDirectory(Directory directoryName)
    {
        _directories.Add(directoryName);
    }

    public void Display()
    {
        Console.WriteLine($" Directory: - {Name}");
        
        foreach (var file in _files)
        {
            file.Display();
        }

        foreach (var directory in _directories)
        {
            directory.Display();
        }
    }
}
