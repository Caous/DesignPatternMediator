using MediatorDesignPattern.Enumeradores;
using MediatorDesignPattern.Servicos;

namespace MediatorDesignPattern.Mediator;

public class ConcreteMediator : IMediator
{
    private readonly EsteticaServico _estetica;
    private readonly FreioServico _freio;
    private readonly OleoServico _oleo;

    public ConcreteMediator(EsteticaServico estetica, FreioServico freio, OleoServico oleo)
    {
        _estetica = estetica;
        _estetica.SetMediator(this);
        _freio = freio;
        _freio.SetMediator(this);
        _oleo = oleo;
        _oleo.SetMediator(this);
    }
    public void Notify(object sender, EServico servicos)
    {

        switch (servicos)
        {
            case EServico.Freios:
                _freio.CriarOrdemServico();
                break;
            case EServico.Oleo:
                _oleo.CriarOrdemServico();
                break;
            case EServico.Estetica:
                _estetica.CriarOrdemServico();
                break;
            default:
                break;
        }


    }
}
