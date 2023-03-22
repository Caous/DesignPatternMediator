# Designer Pattern Mediator / Padrão de projeto Mediador

Projeto com finalidade em mostrar o padrão de projeto Mediator com implementação

![Strategy](https://user-images.githubusercontent.com/38294660/209868622-2621a08e-5b3c-4d71-ace5-3d675066dd5d.png)


### <h2>Fala Dev, seja muito bem-vindo
   Está POC é para mostrar como podemos implementar o Design Pattern Mediator/Padrão de Projeto Mediador em diversos projetos com adaptação para o cenário que você precisar e contiver códigos legados ou evoluções no estilo MVP, também te explico o que é o Design Pattern Mediator/Padrão de Projeto Mediador e como usar em diversas situações. Espero que encontre o que procura <img src="https://media.giphy.com/media/WUlplcMpOCEmTGBtBW/giphy.gif" width="30"> 
</em></p></h5>
  
  </br>
  


<img align="right" src="https://refactoring.guru/images/patterns/diagrams/strategy/solution.png?id=0813a174b29a2ed5902d321aba28e5fc" width="300" height="300"/>


</br></br>

### <h2>Strategy <a href="https://refactoring.guru/pt-br/design-patterns/strategy" target="_blank"><img alt="Serilog" src="https://img.shields.io/badge/Strategy-blue?style=flat&logo=google-chrome"></a>

 <a href="https://refactoring.guru/pt-br/design-patterns/strategy" target="_blank">Design Pattern Strategy ou Padrão de Projeto Estratégia </a> é um padrão de projeto para <b>resolver um problema que já foi encontrado por outras pessoas</b>, sendo assim por este problema ter se repetido diversas vezes, criaram-se um padrão de solução ou como costumamos dizer Padrão de Projeto / Design Pattern para resolver este problema.
 
Esse padrão de projeto pode ser utilizado <b>INDIFERENTE DA LINGUAGEM DE PROMAÇÃO</b>, ou seja, pode ser aplicado em qualquer lugar. Mas fica um <b>Ponto de Atenção</b> para vocês, só implementem realmente se fizer sentido.
 
Design Pattern Strategy tem como objetivo conectar/centralizar códigos que tem o mesmo objetivo, mas para se chegar no resultado efetuam lógicas, etapas de validações, conexões difentes. Sendo assim é uma forma de conseguir centralizar aquele código <b>LEGADO</b> que não pode ser apagado porque ainda é utilizado, e misturar com o código novo, onde ambos vão mostrar o mesmo resultado para você.

Sendo assim Strategy utiliza 3 Pilares:

<b>Interface</b> que irá conter os métodos padrões que ambos os códigos vão fazer e chegam ao mesmo resultado ou seja sua saída é a mesma

<b>ConcreteStrategy</b> que irá conter as implementar da interface e os códigos necessários, ou seja, você terá uma classe que implementa a interface com o Código Legado e outra classe que implementa a interface com o Código Novo

<b>Context</b> que por último será a classe principal que irá automáticamente implementar as classes necessárias de acordo com a estratégia selecionada por você desenvolvedor ou usuário (caso seja controlado por ele em alguma tela)

<b>Dica: Você pode usar o padrão de projeto adaptativo/ designer pattern adapter para fazer uma implementação adaptada para sua regra de negócio, mas basicamente tente manter o Strategy o mais conservador possível

Legal né? Mas agora a pergunta é como posso usar o Strategy? Abaixo dou um exemplo de caso de uso.

</br></br>

### <h2>[Cenário de Uso]
Vamos imaginar o seguinte cenário, você tem um <b>WebService</b> que <b>consulta os dados de alunos em uma escola</b>, mas este WebService está começando a fica <b>defasado e muito lento para consultas</b>, então você cria ou encontra uma API atualizada e totalmente otimizada que lhe devolve a maior parte destes dados que são utilizados hoje. Sendo assim vamos agora colocar que seu WebService venha fica fora do ar e lhe responda <b> Time Out<b/>, seria muito útil utilizar aquela API agora certo? Mas como centralizar e ter a menor <b>refatoração de código possível</b>? É esse o objetivo do Strategy

### <h2> Criação de Classes

Vamos criar a interface que contém os métodos necessários para retornar os dados dos alunos, chamando o método de GetAllStudents
```C#
   public interface IStudent
    {
        ICollection<Student> GetAllStudents();
    }
```

Próxima etapa é criarmos as classes que vão implementar essa interface IStudent
```C#

///Classe que busca direto da API
 public class StudentApi : IStudent
    {
        public StudentApi()
        {

        }
        public ICollection<Student> GetAllStudents()
        {
            ICollection<Student> students = new List<Student>() { new Student() { FirstName = "Lionel", LastName = "Messi", Active = true }, new Student() { FirstName = "Cristiano", LastName = "Ronaldo", Active = true }, new Student() { FirstName = "Kylian", LastName = "Mbappe", Active = false } };
            return students;
        }
    }
    
    ///Classe que busca direto do banco de dados    
        public class StudentDb : IStudent
    {
        public StudentDb()
        {

        }
        public ICollection<Student> GetAllStudents()
        {
            ICollection<Student> students = new List<Student>() { new Student() { FirstName = "Neymar", LastName = "Junior", Active = true }, new Student() { FirstName = "Luka", LastName = "Modric", Active = true } };
            return students;
        }
    }
    
    ///Classe que busca direto do WebService
        public class StudentWebService : IStudent
    {
        public StudentWebService()
        {

        }
        public ICollection<Student> GetAllStudents()
        {
            return null;
        }

    }
```
</br>

Agora vamos criar nosso Context que irá chamar a interface e criar a estratégia a ser utilizada
```C#
 public class ContextStudent
    {
        IStudent student;
        public ContextStudent()
        {

        }

        public void SetStrategy(IStudent _student)
        {
            this.student = _student;
        }

        public ICollection<Student> ExecuteStrategy()
        {
            return student.GetAllStudents();
        }
    }
```

E por ultimo basta apenas chamar a classe context e implementar a estratégia de acordo com a regra de negócio

```C#
Console.WriteLine("Welcome to implementation design patterns Strategy");

ContextStudent contextStudent = new ContextStudent();

ICollection<Student> students;

StudentWebService studentWebService = new StudentWebService();

contextStudent.SetStrategy(studentWebService);

students = contextStudent.ExecuteStrategy();

if (students != null)
    foreach (var student in students)
        Console.WriteLine(student.ToString());

StudentApi studentApi = new StudentApi();

contextStudent.SetStrategy(studentApi);

students = contextStudent.ExecuteStrategy();

if (students != null)
    foreach (var student in students)
        Console.WriteLine(student.ToString());
```


### <h5> [IDE Utilizada]</h5>
![VisualStudio](https://img.shields.io/badge/Visual_Studio_2019-000000?style=for-the-badge&logo=visual%20studio&logoColor=purple)

### <h5> [Linguagem Programação Utilizada]</h5>
![C#](https://img.shields.io/badge/C%23-000000?style=for-the-badge&logo=c-sharp&logoColor=purple)



### <h5> [Web 🌐 - Utilizado]</h5>
![HTML5](https://img.shields.io/badge/-HTML5-000000?style=for-the-badge&logo=HTML5)
![CSS3](https://img.shields.io/badge/-CSS3-000000?style=for-the-badge&logo=CSS3)
![JavaScript](https://img.shields.io/badge/-JavaScript-000000?style=for-the-badge&logo=javascript)





### <h5> [Versionamento de projeto] </h5>
![Github](http://img.shields.io/badge/-Github-000000?style=for-the-badge&logo=Github&logoColor=green)

</br></br></br></br>


<p align="center">
  <i>🤝🏻 Vamos nos conectar!</i>

  <p align="center">
    <a href="https://www.linkedin.com/in/gusta-nascimento/" alt="Linkedin"><img src="https://github.com/nitish-awasthi/nitish-awasthi/blob/master/174857.png" height="30" width="30"></a>
    <a href="https://www.instagram.com/gusta.nascimento/" alt="Instagram"><img src="https://github.com/nitish-awasthi/nitish-awasthi/blob/master/instagram-logo-png-transparent-background-hd-3.png" height="30" width="30"></a>
    <a href="mailto:caous.g@gmail.com" alt="E-mail"><img src="https://github.com/nitish-awasthi/nitish-awasthi/blob/master/gmail-512.webp" height="30" width="30"></a>   
  </p>
