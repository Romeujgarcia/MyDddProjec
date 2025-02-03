MyDddProject
Este projeto é uma demonstração prática de Domain-Driven Design (DDD) utilizando a plataforma .NET 8.0. A implementação segue os princípios do DDD, dividindo a aplicação em camadas como Domínio, Aplicação, Infraestrutura e API. O objetivo é criar uma solução escalável, de fácil manutenção e alinhada às boas práticas de arquitetura de software.

Tecnologias Utilizadas
.NET 8.0: Framework utilizado para construir a aplicação.
Entity Framework Core: ORM para interação com o banco de dados relacional.
Moq: Biblioteca para mock de objetos em testes unitários.
Xunit: Framework de testes unitários utilizado para garantir a qualidade do código.
SQL Server: Banco de dados utilizado para persistência de dados.
Docker (opcional, se utilizado): Para containerização e facilitar o ambiente de execução.
Arquitetura do Projeto
O projeto segue a arquitetura de Domain-Driven Design (DDD), composta pelas seguintes camadas:

Domain: Contém as entidades e regras de negócio, representando o núcleo do sistema.
Application: Contém os serviços de aplicação que coordenam as interações entre as entidades do domínio.
Infrastructure: Implementação dos repositórios, serviços externos e acesso ao banco de dados.
API: Interface de comunicação com o usuário, implementada como uma API RESTful.
Como Rodar o Projeto
Pré-requisitos
Certifique-se de ter os seguintes pré-requisitos instalados:

.NET 8.0 SDK
SQL Server ou um banco de dados compatível
Docker (opcional)
