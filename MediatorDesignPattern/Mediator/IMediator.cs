using MediatorDesignPattern.Enumeradores;

namespace MediatorDesignPattern.Mediator;

public interface IMediator
{
    void Notify(object sender, EServico servicos);
}
