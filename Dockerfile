FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
EXPOSE 80

COPY . ./
RUN dotnet restore
RUN dotnet publish ./src/CalculoCobranca.TaxaJuro.Api/CalculoCobranca.TaxaJuro.Api.csproj -c Release -o ./src/CalculoCobranca.TaxaJuro.Api/out --no-restore

ENTRYPOINT ["dotnet", "CalculoCobranca.TaxaJuro.Api.dll"]

