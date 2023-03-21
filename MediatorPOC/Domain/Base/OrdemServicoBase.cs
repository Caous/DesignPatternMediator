using MediatorPOC.Domain.Mediator;
using MediatorPOC.Domain.Model;

namespace MediatorPOC.Domain.Base;

public class OrdemServicoBase
{
    public Guid Id { get; private set; }
    public string Desc_Servico { get; private set; }
    public IEnumerable<Servico> Servicos_Oficinas { get; private set; }

    protected IMediator _mediator;

    public OrdemServicoBase(string servico, IMediator? mediator = null)
    {
        Id = Guid.NewGuid();
        Desc_Servico = servico;
        Servicos_Oficinas = CarregarServicos();
        _mediator = mediator;
    }

    public string CriarOrdemServico() => $"Ordem de servico criada número do chamado: {Id} para o serviço: {Desc_Servico}";

    private IEnumerable<Servico>? CarregarServicos()
    {
        throw new NotImplementedException();
    }

    public void SetMediator(IMediator mediator) => _mediator = mediator;
}
