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
