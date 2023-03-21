using MediatorPOC.Domain.Base;
using MediatorPOC.Domain.Mediator;

namespace MediatorPOC.Domain.Servicos;

public class EsteticaServico : OrdemServicoBase
{
    public EsteticaServico(string servico, IMediator? mediator = null) : base(servico, mediator)
    {
    }

    public string ServicoEfetuado()
    {
        _mediator.Notify(this, Enumeradores.EServico.Estetica);
        return $"Servico efetuado as {DateTime.Now.Date} {base.CriarOrdemServico()}";
    }

}
