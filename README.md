# 🚗 AgendamentoAPI

API REST para gerenciamento de agendamentos, construída com ASP.NET Core e MySQL, com suporte completo via Docker.

---

## 📆 Tecnologias Utilizadas

* ASP.NET Core 7.0+
* Entity Framework Core
* MySQL
* Docker & Docker Compose
* Swagger / OpenAPI

---

## 📊 O que a API faz

A API permite:

* Gerenciar agendamentos com CRUD completo
* Cadastrar e manter clientes
* Gerenciar profissionais
* Cadastrar tipos de serviços

### Principais rotas:

#### Agendamento

* `GET /api/Agendamento/Buscar`
* `POST /api/Agendamento/Cadastrar`
* `PUT /api/Agendamento/AtualizarAgendamento`
* `DELETE /api/Agendamento/DeletarAgendamento`

#### Cliente

* `GET /api/Cliente/Buscar`
* `POST /api/Cliente/Cadastrar`
* `PUT /api/Cliente/AtualizarCliente`
* `DELETE /api/Cliente/DeletarCliente`

#### Profissionais

* `GET /api/Profissionais/Buscar`
* `POST /api/Profissionais/Cadastrar`
* `PUT /api/Profissionais/AtualizarProfissional`
* `DELETE /api/Profissionais/DeletarProfissional`

#### Serviço

* `GET /api/controller/BuscarServico`
* `POST /api/controller/CriarServico`
* `PUT /api/controller/AtualizarServico`
* `DELETE /api/controller/DeletarServico`

---

## 📂 Estrutura de Pastas

```
AgendamentoAPI/
├── Controllers/           # Controllers da API
├── Models/                # Models/Entidades do sistema
├── Repository/            # Repositórios com acesso ao banco
├── Migrations/            # Migrations do Entity Framework
├── Program.cs             # Configuração principal da aplicação
├── appsettings.json       # Configurações gerais da aplicação
├── Dockerfile             # Dockerfile da aplicação
├── docker-compose.yml     # Orquestração com Docker Compose
├── AgendamentoAPI.csproj  # Projeto principal .NET
```

---

## ✅ Pré-requisitos

Antes de rodar a aplicação, você precisa ter instalado:

* [Docker Desktop](https://www.docker.com/products/docker-desktop)
* (Opcional) Git, para clonar o repositório
* (Opcional) .NET SDK 7.0+, caso queira rodar localmente sem Docker

---

## 🚀 Como executar o projeto

### 🐳 1. Clonar o repositório

```bash
git clone https://github.com/seu-usuario/agendamentoapi.git
cd agendamentoapi
```

### 🐳 2. Criar a imagem da aplicação

```bash
docker build -t agendamentoapi .
```

### 🐳 3. Subir os containers com Docker Compose

```bash
docker-compose up -d
```

Isso irá subir:

* A API na porta `5004`
* O banco MySQL na porta `3307`
* Uma rede Docker isolada (`agendamento-net`)

---

## 🌐 Acesso à API

Após subir os containers, acesse:

* Swagger UI: [http://localhost:5004/swagger](http://localhost:5004/swagger)
* Exemplo de endpoint: [http://localhost:5004/api/Cliente/Buscar](http://localhost:5004/api/Cliente/Buscar)

---

## 🥪 Migrations & Banco de Dados

As migrations podem ser aplicadas manualmente com:

```bash
dotnet ef database update
```

> Certifique-se de usar a string de conexão com `localhost:3307` ao rodar fora do Docker.

Se quiser aplicar automaticamente ao iniciar a aplicação, inclua no `Program.cs`:

```csharp
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<SeuDbContext>();
    db.Database.Migrate();
}
```

---

## 🔄 Alternar string de conexão conforme ambiente

* **Desenvolvimento local (fora do Docker):**

```json
"DefaultConnection": "Server=localhost;Port=3307;Database=agendamentoapi;User=apiuser;Password=Senha123;"
```

* **Produção ou execução em container Docker:**

```json
"DefaultConnection": "Server=mysql-api-prod;Port=3306;Database=agendamentoapi;User=apiuser;Password=Senha123;"
```

---

## 🚼 Limpeza de containers e volumes antigos (opcional)

```bash
docker container prune
docker volume prune
```

---

## 🙌 Contribuição

Sinta-se à vontade para enviar sugestões, melhorias ou correções via issues ou pull requests.

