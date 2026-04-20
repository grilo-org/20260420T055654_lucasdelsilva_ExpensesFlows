<div align="center">

[![.NET][badge-dot-net]][dotnet-url]
[![Windows][badge-windows]][windows-url]
[![Visual Studio][badge-visual-studio]][visual-studio-url]
[![MySQL][badge-mysql]][mysql-url]
[![Swagger][badge-swagger]][swagger-url]

</div>

<!-- Badges -->
[badge-dot-net]: https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge
[badge-windows]: https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=fff&style=for-the-badge
[badge-visual-studio]: https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=fff&style=for-the-badge
[badge-mysql]: https://img.shields.io/badge/MySQL-4479A1?logo=mysql&logoColor=fff&style=for-the-badge
[badge-swagger]: https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=000&style=for-the-badge

<!-- URLs -->
[dotnet-url]: https://dotnet.microsoft.com/
[windows-url]: https://www.microsoft.com/windows/
[visual-studio-url]: https://visualstudio.microsoft.com/
[mysql-url]: https://www.mysql.com/
[swagger-url]: https://swagger.io/

# Sistema de Gerenciamento de Despesas (ExpenseFlow)

Um sistema completo de gerenciamento de despesas construído em C# utilizando princípios de arquitetura limpa. Esta aplicação permite aos usuários gerenciar suas despesas através de operações básicas CRUD (Criar, Ler, Atualizar, Deletar) com uma infraestrutura robusta e com Princípios SOLID.
## 🏗️ Estrutura do Projeto

A solução segue um padrão de arquitetura limpa com as seguintes camadas:

- **ExpenseFlow.Api**: Endpoints da API e configuração
  - Controllers
  - Middleware
  - Filters
  - Configurações da aplicação

- **ExpenseFlow.Application**: Lógica de negócio da aplicação
  - Casos de Uso
  - Configurações do AutoMapper
  - Configurações de injeção de dependência

- **ExpenseFlow.Communication**: Camada de comunicação
  - Modelos de Request/Response
  - Enums para comunicação

- **ExpenseFlow.Domain**: Lógica de negócio principal
  - Entidades
  - Interfaces de repositórios
  - Serviços de domínio
  - Relatórios
  - Extensions

- **ExpenseFlow.Infrastructure**: Acesso a dados e serviços externos
  - Implementações de acesso a dados
  - Implementações de repositório
  - Contexto do banco de dados

## 🚀 Funcionalidades Principais

- Gerenciamento completo de despesas (CRUD)
- Domain-Driven Design (DDD)
  - Estrutura organizada que facilita o entendimento do domínio
  - Separação clara de responsabilidades
  - Modelagem rica do domínio da aplicação
  
- Testes de Unidade
  - Utilização do FluentAssertions para asserções mais expressivas
  - Cobertura abrangente dos casos de uso
  - Garantia de qualidade e funcionamento correto

- Geração de Relatórios
  - Exportação para formatos PDF e Excel
  - Análise visual detalhada das despesas
  - Relatórios personalizáveis e intuitivos
  
- API RESTful com Swagger
  - Documentação completa dos endpoints
  - Interface interativa para testes
  - Facilitação da integração por outros desenvolvedores

- Sistema de middleware para processamento de requisições
- Comunicação baseada em recursos (REST)
- Arquitetura orientada a interfaces
- Integração com banco de dados SQL Server
- Sistema robusto de tratamento de erros

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- AutoMapper
- Injeção de Dependência
- SQL Server (Banco de Dados)

## 🏃‍♂️ Como Começar

### Pré-requisitos

- .NET 6.0 ou superior
- SQL Server
- Visual Studio 2022 ou IDE de preferência

### Instalação

1. Clone o repositório
```bash
git clone https://github.com/lucasdelsilva/ExpenseFlow.git
```

2. Navegue até o diretório do projeto
```bash
cd ExpenseFlow
```

3. Restaure os pacotes NuGet
```bash
dotnet restore
```

4. Atualize a string de conexão do banco de dados no `appsettings.json` (Deixei um exemplo de conexão **localhost**)

5. Aplique as configurações no seu banco de dados

6. Execute a aplicação
```bash
dotnet run --project ExpenseFlow.Api
```

## 🔄 Endpoints da API

### Despesas
- `GET /api/expenses` - Listar todas as despesas
- `GET /api/expenses/{id}` - Obter despesa específica
- `POST /api/expenses` - Criar nova despesa
- `PUT /api/expenses/{id}` - Atualizar despesa existente
```csharp
  {
    "title": "Exemplo",
    "description": "Exemplo",
    "date": "2024-12-05T20:00:00",
    "amount": 1145.20,
    "paymentType": 0
  }
```
- `DELETE /api/despesas/{id}` - Deletar despesa

## 🧪 Testes

A solução inclui dois projetos de teste:
- CommonTests: Utilitários de teste comuns e recursos compartilhados
- Validators.Tests: Testes de lógica de validação

Para executar os testes:
```bash
dotnet test
```

## 🏛️ Arquitetura

O projeto segue os princípios de arquitetura limpa com clara separação de responsabilidades:

1. **Camada de API**: Manipula requisições e respostas HTTP
2. **Camada de Aplicação**: Contém lógica de negócio e casos de uso
3. **Camada de Domínio**: Regras de negócio principais e entidades
4. **Camada de Infraestrutura**: Preocupações externas como acesso ao banco de dados
5. **Camada de Exception**: Tratamento de erros (Exceptions)

<!-- Badges -->
[badge-dot-net]: https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge
[badge-windows]: https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=fff&style=for-the-badge
[badge-visual-studio]: https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=fff&style=for-the-badge
[badge-mysql]: https://img.shields.io/badge/MySQL-4479A1?logo=mysql&logoColor=fff&style=for-the-badge
[badge-swagger]: https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=000&style=for-the-badge
