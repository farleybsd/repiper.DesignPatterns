namespace DesignerPatterns.Chain_Of_Responsibility.GOOD;
// Classe Documento que Representa o Documento a Ser Aprovado
public class Document
{
    public string Title { get;  }
    public bool IsApproved { get; private set; }
    public string ApprovedBy { get; private set; }
    public Document(string title)
    {
        Title = title;
    }

    public void Approve(string approver)
    {
        IsApproved = true;
        ApprovedBy = approver;
        Console.WriteLine($"{Title} foi aprovado por {ApprovedBy}");
    }
}
// Interface para handlers da Cadeia
public abstract class Approver
{
    protected Approver _nextApprover;

    public void SetNextAprrover(Approver nextApprover)
    {
        _nextApprover = nextApprover;
    }
    public abstract void HandlerRequest(Document document);
}
// Handler para Assistente 
public class AssistantApprover : Approver
{
    public override void HandlerRequest(Document document)
    {
        if (CanApprove(document))
        {
            document.Approve("Assistente");
        } else if (_nextApprover != null)
        {
            _nextApprover.HandlerRequest(document);
        }
    }
    private bool CanApprove(Document document)
    {
        //Simulacao de Condicao de Aprovacao
        return false; // Nesse Caso o Assistente Nao Aprova
    }
}

// Handler para Gentente 
public class ManegerApprover : Approver
{
    public override void HandlerRequest(Document document)
    {
        if (CanManagerAprrove(document))
        {
            document.Approve("Gentente");
        } else if (_nextApprover != null)
        {
            _nextApprover.HandlerRequest(document);
        }
    }
    private bool CanManagerAprrove(Document document)
    {
        //Simulacao de Condicao de Aprovacao
        return false; // Nesse Caso o Gerente Nao Aprova
    }
}
// Handler para Diretor 
public class DirectorrApprover : Approver
{
    public override void HandlerRequest(Document document)
    {
        if (CanDiretorApprove(document))
        {
            document.Approve("Gentente");
        } else if (_nextApprover != null)
        {
            _nextApprover.HandlerRequest(document);
        }
    }
    private bool CanDiretorApprove(Document document)
    {
        //Simulacao de Condicao de Aprovacao
        return true; // Nesse Caso o Diretor  Aprova
    }
}