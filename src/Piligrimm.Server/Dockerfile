#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /Web
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /Web

COPY ["./Server/Web/Web.csproj", "./Server/Web/"]
COPY ["./Server/Application/Application.csproj", "./Server/Application/"]
COPY ["./Server/Infrastructure/Infrastructure.csproj", "./Server/Infrastructure/"]

RUN dotnet restore "./Server/Web/Web.csproj"
COPY . .
WORKDIR "./Server/Web"
RUN dotnet build "./Web.csproj" -c $BUILD_CONFIGURATION -o /Web/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Web.csproj" -c $BUILD_CONFIGURATION -o /Web/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /Web
COPY --from=publish /Web/publish .
ENTRYPOINT ["dotnet", "Web.dll"]