namespace Design.Patterns.Singleton.GOOD;

public class Logger
{
    private static Logger _instance;

    //Construtor Privado para impedir a instaciacao direta
    private Logger()
    {
    }

    // Metodo estatico para acessar a unica instancia de logger
    public static Logger Instamce
    {
        get
        {
            if (_instance == null)
                return new Logger();
            return _instance;
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"Log entry: {message}");
    }
}