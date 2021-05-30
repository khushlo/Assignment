FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["DatasetService/DatasetService.csproj", "DatasetService/"]
COPY ["OpenAPI/OpenAPI.csproj", "OpenAPI/"]
RUN dotnet restore "OpenAPI/OpenAPI.csproj"
COPY . .
WORKDIR /src/OpenAPI
RUN dotnet build "OpenAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "OpenAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "OpenAPI.dll"]
