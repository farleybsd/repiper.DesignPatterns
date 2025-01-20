namespace Design.Patterns.Ripiper.Proxy.BAD;

// Classe que representa um Documento
public class DocumentBad
{ 
    public string Title { get;}
    public string Content { get;}
    private readonly string _userRole;
    public DocumentBad(string userRole, string title, string content)
    {
        _userRole = userRole;
        Title = title;
        Content = content;
    }
    // Metodo que exibe o conteudo do documento com a verificacao de acesso
    public void DisplayContent()
    {
        if (_userRole == "Admin" || _userRole == "Gerente")
        {
            Console.WriteLine($"Documento:{Title} conteudo: {Content}");
        }
        else
        {
            Console.WriteLine("Acesso Negado: Voce nao tem permissao para visualizar esse documento.");
        }
    }
}

