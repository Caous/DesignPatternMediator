// See https://aka.ms/new-console-template for more information

using MediatorDesignPattern.Mediator;
using MediatorDesignPattern.Servicos;

EsteticaServico esteticaServico = new EsteticaServico("Vidrificação");
FreioServico freioServico = new FreioServico("Troca pastilho de freio");
OleoServico oleoServico = new OleoServico("Troca de oléo");

new ConcreteMediator(esteticaServico, freioServico, oleoServico);

esteticaServico.ServicoEfetuado();
freioServico.ServicoEfetuado();
oleoServico.ServicoEfetuado();