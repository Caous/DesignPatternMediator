namespace MediatorPOC.Domain.Model;

public class Servico
{
    public Guid Id { get; private set; }
    public string Desc_Servico { get; private set; }
    public DateTime Dt_Solicitacao { get; private set; }

    public Servico(string descServico)
    {
        Desc_Servico = descServico;
        Id = Guid.NewGuid();
        Dt_Solicitacao = DateTime.Now;
    }

}
