FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
EXPOSE 80


COPY . ./
RUN dotnet restore
RUN dotnet publish ./src/CalculoCobranca.CalculaJuro.Api/CalculoCobranca.CalculaJuro.Api.csproj -c Release -o ./src/CalculoCobranca.CalculaJuro.Api/out --no-restore

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=build-env /app/src/CalculoCobranca.CalculaJuro.Api/out ./


ENTRYPOINT ["dotnet", "CalculoCobranca.CalculaJuro.Api.dll"]

