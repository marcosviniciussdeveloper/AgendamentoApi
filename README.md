# AgendamentoAPI

Esta é uma API desenvolvida em ASP.NET Core com Entity Framework Core e Docker, que fornece funcionalidades de agendamento de operações.

## 🛠️ Tecnologias Utilizadas

* ASP.NET Core 8.0
* Entity Framework Core
* MySQL 8.0
* Docker
* Docker Compose

---

## 📦 Estrutura do Projeto

```
/AgendamentoAPI
│── Dockerfile
│── docker-compose.yml
│── AgendamentoAPI.sln
│── /AgendamentoAPI
│   │── AgendamentoAPI.csproj
│   │── Program.cs
│   │── appsettings.json
│   └── /Controllers
│   └── /Models
│   └── /Data
```

---

## 🚀 Como Executar a API

### Pré-requisitos:

* Docker Desktop
* .NET SDK 8.0

### 1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/agendamentoapi.git
cd agendamentoapi
```

### 2. Crie um arquivo `.env` na raiz do projeto com as variáveis de ambiente:

```
MYSQL_ROOT_PASSWORD=suporte1020
MYSQL_DATABASE=agendamentoapi
```

### 3. Execute o Docker Compose:

```bash
docker-compose up --build
```

A aplicação estará disponível em `http://localhost:5000`.

---

## 🛠️ Endpoints

* `GET /api/agendamentos` - Lista todos os agendamentos
* `POST /api/agendamentos` - Cria um novo agendamento
* `PUT /api/agendamentos/{id}` - Atualiza um agendamento
* `DELETE /api/agendamentos/{id}` - Deleta um agendamento

---

## 📝 Migrations e Banco de Dados

Para criar e aplicar as migrations, execute os comandos:

```bash
docker-compose exec api dotnet ef migrations add InitialCreate
```

```bash
docker-compose exec api dotnet ef database update
```

---

## 🔥 Parar e Remover os Containers:

```bash
docker-compose down -v
```

---

## 📌 Observações:

* Os volumes são armazenados na pasta `mysql_data` para persistência dos dados.
* As senhas e credenciais estão definidas no `docker-compose.yml` e `.env`.

---

## 🛠️ Autor

* Marcos Vinicius Conceicao
