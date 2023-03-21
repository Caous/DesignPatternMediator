using MediatorPOC.Domain.Enumeradores;

namespace MediatorPOC.Domain.Mediator;

public interface IMediator
{
    void Notify(object sender, EServico servicos);
}
