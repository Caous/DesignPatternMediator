using MediatorDesignPattern.Mediator;

namespace MediatorDesignPattern.Base;

public class OrdemServicoBase
{
    public Guid Id { get; private set; }
    public string Desc_Servico { get; private set; }

    protected IMediator _mediator;

    public OrdemServicoBase(string servico, IMediator mediator = null)
    {
        Id = Guid.NewGuid();
        Desc_Servico = servico;
        _mediator = mediator;
    }

    public string CriarOrdemServico() => $"Ordem de servico criada número do chamado: {Id} para o serviço: {Desc_Servico}";

    public void SetMediator(IMediator mediator) => _mediator = mediator;
}
