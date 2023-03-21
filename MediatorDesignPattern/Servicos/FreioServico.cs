using MediatorDesignPattern.Base;
using MediatorDesignPattern.Enumeradores;
using MediatorDesignPattern.Mediator;

namespace MediatorDesignPattern.Servicos;

public class FreioServico : OrdemServicoBase
{
    public FreioServico(string servico, IMediator mediator = null) : base(servico, mediator)
    {
    }

    public void ServicoEfetuado()
    {
        Console.WriteLine($"Servico efetuado as {DateTime.Now} {CriarOrdemServico()}");
        this._mediator.Notify(this, EServico.Estetica);
    }
}
