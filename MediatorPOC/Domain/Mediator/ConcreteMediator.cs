using MediatorPOC.Domain.Enumeradores;
using MediatorPOC.Domain.Servicos;

namespace MediatorPOC.Domain.Mediator;

public class ConcreteMediator : IMediator
{
    private readonly EsteticaServico _estetica;
    private readonly FreioServico _freio;
    private readonly OleoServico _oleo;

    public ConcreteMediator(EsteticaServico estetica, FreioServico freio, OleoServico oleo)
    {
        _estetica = estetica;
        _freio = freio;
        _oleo = oleo;
    }
    public void Notify(object sender, EServico servicos)
    {

        switch (servicos)
        {
            case EServico.Freios:
                this._freio.ServicoEfetuado();
                break;
            case EServico.Oleo:
                _oleo.ServicoEfetuado();
                break;
            case EServico.Estetica:
                _estetica.ServicoEfetuado();
                break;
            default:
                break;
        }


    }
}
