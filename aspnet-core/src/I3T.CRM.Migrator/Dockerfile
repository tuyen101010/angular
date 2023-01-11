#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/I3T.CRM.Migrator/I3T.CRM.Migrator.csproj", "src/I3T.CRM.Migrator/"]
COPY ["src/I3T.CRM.EntityFrameworkCore/I3T.CRM.EntityFrameworkCore.csproj", "src/I3T.CRM.EntityFrameworkCore/"]
COPY ["src/I3T.CRM.Core/I3T.CRM.Core.csproj", "src/I3T.CRM.Core/"]
COPY ["src/I3T.CRM.Core.Shared/I3T.CRM.Core.Shared.csproj", "src/I3T.CRM.Core.Shared/"]
RUN dotnet restore "src/I3T.CRM.Migrator/I3T.CRM.Migrator.csproj"
COPY . .
WORKDIR "/src/src/I3T.CRM.Migrator"
RUN dotnet build "I3T.CRM.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "I3T.CRM.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "I3T.CRM.Migrator.dll", "-s"]
