#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ShoesShop.csproj", "."]
RUN dotnet restore "./ShoesShop.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./ShoesShop.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ShoesShop.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

COPY ["Data", "/app/publish/Data"]
RUN chmod o+w /app/publish/Data
RUN chmod 666 /app/publish/Data/Database/database.db
RUN chmod 666 /app/publish/Data/Database/database.db-shm
RUN chmod 666 /app/publish/Data/Database/database.db-wal

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShoesShop.dll"]