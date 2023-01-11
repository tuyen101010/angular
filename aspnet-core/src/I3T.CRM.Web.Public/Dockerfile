#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/I3T.CRM.Web.Public/I3T.CRM.Web.Public.csproj", "src/I3T.CRM.Web.Public/"]
COPY ["src/I3T.CRM.Web.Core/I3T.CRM.Web.Core.csproj", "src/I3T.CRM.Web.Core/"]
COPY ["src/I3T.CRM.Application/I3T.CRM.Application.csproj", "src/I3T.CRM.Application/"]
COPY ["src/I3T.CRM.Application.Shared/I3T.CRM.Application.Shared.csproj", "src/I3T.CRM.Application.Shared/"]
COPY ["src/I3T.CRM.Core.Shared/I3T.CRM.Core.Shared.csproj", "src/I3T.CRM.Core.Shared/"]
COPY ["src/I3T.CRM.Core/I3T.CRM.Core.csproj", "src/I3T.CRM.Core/"]
COPY ["src/I3T.CRM.EntityFrameworkCore/I3T.CRM.EntityFrameworkCore.csproj", "src/I3T.CRM.EntityFrameworkCore/"]
COPY ["src/I3T.CRM.GraphQL/I3T.CRM.GraphQL.csproj", "src/I3T.CRM.GraphQL/"]
RUN dotnet restore "src/I3T.CRM.Web.Public/I3T.CRM.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/I3T.CRM.Web.Public"
RUN dotnet build "I3T.CRM.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "I3T.CRM.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "I3T.CRM.Web.Public.dll"]
