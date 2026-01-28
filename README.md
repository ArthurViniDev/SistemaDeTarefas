# SistemaDeTarefas

SistemaDeTarefas é uma aplicação web desenvolvida para gerenciar tarefas de forma eficiente. Utilizando as mais recentes tecnologias da plataforma .NET, este projeto oferece uma API RESTful que permite a criação, leitura, atualização e exclusão de tarefas e usuários.

## Tecnologias e Ferramentas

- .NET 8 (SDK)
- C# 12
- ASP.NET Core Web API
- Entity Framework Core (EF Core)
- SQL Server (via `Microsoft.EntityFrameworkCore.SqlServer`)
- Swagger / Swashbuckle (`Swashbuckle.AspNetCore`)
- Visual Studio ou dotnet CLI

## Estrutura do projeto

- `Program.cs` — configuração de serviços e pipeline (DI, EF, Swagger)
- `SistemaDeTarefas.sln` — solução do Visual Studio
- `Controllers/` — controllers da API (ex.: `UsuarioController.cs`)
- `Data/` — `DbContext` do EF Core (ex.: `SistemaTarefasDBContext.cs`)
- `Models/` — modelos de domínio (ex.: `UsuarioModel.cs`, `TarefaModel.cs`)
- `Repositorios/` — implementações de repositório (ex.: `UsuarioRepositorio.cs`)
- `Repositorios/Interfaces/` — contratos dos repositórios (ex.: `IUsuarioRepositorio.cs`)
- `Enums/` — enums do domínio (ex.: `StatusTarefa`)

## Dependências NuGet recomendadas

- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Tools` (opcional, para migrações)
- `Swashbuckle.AspNetCore`

> Ajuste as versões conforme compatibilidade com .NET 8.

## Configuração

1. Atualize a string de conexão em `appsettings.json`. A chave usada no projeto é `DataBase`.
2. Exemplo de connection string (appsettings.json):

   "ConnectionStrings": {
     "DataBase": "Server=.;Database=SistemaTarefasDb;Trusted_Connection=True;"
   }

## Como executar

1. Restaurar pacotes: `dotnet restore`.
2. (Opcional) Criar migração EF Core: `dotnet ef migrations add InitialCreate`.
3. Aplicar migração: `dotnet ef database update`.
4. Executar a aplicação: `dotnet run` ou use o Visual Studio.
5. Acesse a documentação Swagger em `/swagger` quando a aplicação estiver em desenvolvimento.

## Observações

- O projeto utiliza injeção de dependência; verifique as configurações em `Program.cs` (`AddScoped<IUsuarioRepositorio, UsuarioRepositorio>`).
- Se for publicar, ajuste `UseSqlServer` e credenciais conforme o ambiente.
- A documentação da API está disponível via Swagger em `/swagger` quando em ambiente de desenvolvimento.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests para melhorias e correções.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).