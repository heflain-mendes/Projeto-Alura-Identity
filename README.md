# Projeto-Alura-Identity - UsuarioApi

Projeto-Alura-Identity é uma aplicação WebApi construída usando ASP.NET Core 6, Entity Framework Core e Identity Core Framework. A aplicação é um exemplo prático de implementação de controle de usuário com autenticação e autorização.

## Tecnologias Utilizadas

- ASP.NET Core 6
- Entity Framework Core
- Identity Core Framework
- PostgreSQL

## Requisitos do Sistema

Certifique-se de que o seu ambiente de desenvolvimento atenda aos seguintes requisitos:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/) (opcional)
- [Visual Studio Code](https://code.visualstudio.com/) (opcional)
- [PostgreSQL](https://www.postgresql.org/) (para armazenamento de dados)

## Configurações de Segredos

Este projeto utiliza segredos para armazenar informações sensíveis, como strings de conexão com o banco de dados e chaves de API. Para saber mais sobre como gerenciar segredos no ASP.NET Core, consulte a [documentação oficial](https://learn.microsoft.com/pt-br/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows).

## Estrutura de Diretórios

A estrutura de diretórios do projeto é organizada da seguinte maneira:

- `UsuarioApi/` - O projeto principal da API.
- `UsuarioApi.Tests/` - Testes unitários e de integração.
- `UsuarioApi.Data/DTOs` - Camada de acesso as DTOs.
- `UsuarioApi.Models/` - Modelos de dados e entidades.
- `UsuarioApi.Services/` - Serviços de aplicação.
- `UsuarioApi.Controllers/` - Controladores da API.
- `UsuarioApi.Migration/` - Migrações de banco de dados.

## Instruções de Uso

1. Clone este repositório em sua máquina local:

   ```bash
   git clone https://github.com/heflain-mendes/Projeto-Alura-Identity.git
