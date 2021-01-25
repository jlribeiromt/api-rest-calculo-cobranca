FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app
EXPOSE 80


COPY . ./
RUN dotnet restore
RUN dotnet publish ./src/CalculoCobranca.TaxaJuro.Api/CalculoCobranca.TaxaJuro.Api.csproj -c Release -o ./src/CalculoCobranca.TaxaJuro.Api/out --no-restore


FROM mcr.microsoft.com/dotnet/runtime:5.0 AS runtime
WORKDIR /app
COPY --from=build-env /app/src/CalculoCobranca.TaxaJuro.Api/out ./

ENTRYPOINT ["dotnet", "CalculoCobranca.TaxaJuro.Api.dll"]
