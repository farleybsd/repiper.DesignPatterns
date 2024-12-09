namespace Design.Patterns.Abstract.Factory.BAD;

// Produto Conncreto 
public class WinButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a button windows style.");
    }
}

// Produto Concreto
public class MacButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a button macOs style.");
    }
}

// Cliente que usa os produtos concretos Diretamente
public class Client
{
    public void CreateUi(string osType)
    {
        if (osType=="Windows")
        {
            var button = new WinButton();
            button.Render();    
        }
        else if (osType == "Mac")
        {
            var button = new MacButton();
            button.Render();
        }
        else
        {
            throw new NotSupportedException("Unsupported OS");
        }
    }
}