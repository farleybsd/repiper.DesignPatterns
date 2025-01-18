namespace DesignerPatterns.Chain_Of_Responsibility.BAD;

// Classe Documento que Representa o Documento a Ser Aprovado
public class DocumentBad
{
    public string Title { get;  }
    public bool IsApproved { get; private set; }
    public string ApprovedBy { get; private set; }
    public DocumentBad(string title)
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
// Classe de Processamento de Aprovacao de Documento
public class DocumentApprovalBad
{
    public void ApprovedDocument(DocumentBad document)
    {
        // Assistente tenta Aprovar
        if (CanApprove(document))
        {
            document.Approve("Assistente");
        }
        // Se o assistente nao puder aprovavar passa para o  gerente
        else if (CanManagerAprrove(document))
        {
            document.Approve("Gerente");
        }
        // Se o Gerente nao puder Aprovar passa para o Diretor
        else if (CanDiretorApprove(document))
        {
            document.Approve("Diretor");
        }
        else
        {
            Console.WriteLine($"{document.Title} nao pode ser aprovado.");
        }
    }

    private bool CanDiretorApprove(DocumentBad document)
    {
        //Simulacao de Condicao de Aprovacao
        return true; // Nesse Caso o Diretor  Aprova
    }

    private bool CanManagerAprrove(DocumentBad document)
    {
        //Simulacao de Condicao de Aprovacao
        return false; // Nesse Caso o Gerente Nao Aprova
    }

    private bool CanApprove(DocumentBad document)
    {
        //Simulacao de Condicao de Aprovacao
        return false; // Nesse Caso o Assistente Nao Aprova
    }
}