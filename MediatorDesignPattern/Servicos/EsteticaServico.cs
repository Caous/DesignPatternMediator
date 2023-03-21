using MediatorDesignPattern.Base;
using MediatorDesignPattern.Mediator;

namespace MediatorDesignPattern.Servicos;

public class EsteticaServico : OrdemServicoBase
{
    public EsteticaServico(string servico, IMediator mediator = null) : base(servico, mediator)
    {
    }

    public void ServicoEfetuado()
    {
        Console.WriteLine($"Servico efetuado as {DateTime.Now} {base.CriarOrdemServico()}");
        this._mediator.Notify(this, Enumeradores.EServico.Estetica);
    }

}
