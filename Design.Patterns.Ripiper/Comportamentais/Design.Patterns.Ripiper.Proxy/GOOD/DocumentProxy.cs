namespace Design.Patterns.Ripiper.Proxy.GOOD;

// Interface que Define o Contrato para os Documentos
public interface IDocument
{
    void DisplayContent();
}
// Classe que reoresenta o documento real
public class RealDocument : IDocument
{
    public RealDocument(string title, string content)
    {
        Title = title;
        Content = content;
    }
    public string Title { get;}
    public string Content { get;}
    
    public void DisplayContent()
    {
        Console.WriteLine($"Documento:{Title} conteudo: {Content}");
    }
}
// Classe Proxy que Controla o acesso
public class DocumentProxy : IDocument
{
    private readonly RealDocument _realDocument;
    private readonly string _userRole;

    public DocumentProxy(RealDocument realDocument, string userRole)
    {
        _realDocument = realDocument;
        _userRole = userRole;
    }

    public void DisplayContent()
    {
        if (HasAccess())
        {
            _realDocument.DisplayContent();
        }
        else
        {   
            Console.WriteLine("Acesso Negado: Voce nao tem permissao para visualizar esse documento.");
        }
    }

    private bool HasAccess()
    {
        // Simulacao de Verificacao de permissoes
        return _userRole == "Admin" || _userRole == "Gerente";
    }
}

// Sistem que Acessa Documentos Atraves do Proxy
public class DocumentAcessSsystem
{
    public void AcessDocumett(IDocument document)
    {
        Console.WriteLine("Tentando acessar o documento...");
        document.DisplayContent();
    }
}