# Fase base - Build
FROM mcr.microsoft.com/dotnet/sdk:8.0-windowsservercore-ltsc2022 AS build
WORKDIR /src

# Copiar o arquivo de projeto e restaurar as dependências
COPY AgendamentoAPI.csproj .
RUN dotnet restore

# Copiar todos os arquivos e compilar
COPY . .
RUN dotnet build -c Release -o /app/build

# Fase de publicação
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

# Fase final - Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0-windowsservercore-ltsc2022 AS final
WORKDIR /app

# Copiar os arquivos publicados
COPY --from=publish /app/publish .

# Ajustar o caminho de trabalho explicitamente
WORKDIR /app

# Ponto de entrada
ENTRYPOINT ["dotnet", "AgendamentoAPI.dll"]
