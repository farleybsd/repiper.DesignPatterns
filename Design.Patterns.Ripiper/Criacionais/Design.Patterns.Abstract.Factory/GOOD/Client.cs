namespace Design.Patterns.Abstract.Factory.GOOD;
// Interface Produto Abstrato
public interface IButton
{
    void Rerender();    
}
// Implementacao concreta dos produtos
public class WinButton : IButton
{
    public void Rerender()
    {
        Console.WriteLine("Rendering a button Windows style");
    }
}

//Implementacao Concreta dos produtos
public class MacButton : IButton
{
    public void Rerender()
    {
        Console.WriteLine("Rendering a button macOs style");
    }
}

// Interface da Fabrica Abstrata 
public interface IGuiFactory
{
    IButton CreateButton();
}

// Implementacao Da Fabrica Windows
public class WinFactory : IGuiFactory
{
    public IButton CreateButton()
    {
        return new WinButton();
    }
}

// Implementacao Da Fabrica Macos
public class MacosFactory : IGuiFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }
}

//Cliente que usa a Fabrica Abstrata
public class Client
{
    private readonly IGuiFactory _guiFactory;

    public Client(IGuiFactory guiFactory)
    {
        _guiFactory = guiFactory;
    }

    public void CreateUi()
    {
        var button = _guiFactory.CreateButton();
        button.Rerender();
    }
}